using Business;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHolder.Filters;
using WebHolder.Models;
using WebHolder.Utils;

namespace WebHolder.Controllers
{
    [ExceptionHandler]
    public class HomeController : BaseController
    {
        public Holder CurrentHolder;
  
        public ActionResult Index(Holder holder = null)
        {
            GetCompanySettings();
            GetSession();
            CurrentHolder = new Holder();
            ViewBag.Holder = holder;
            if (mySession.ContainsKey("Message"))
            {
                ViewBag.Message = mySession["Message"];
                RemoveMySession("Message");
            }
            if (mySession.ContainsKey("CurrentLogin")) ViewBag.CurrentLogin = mySession["CurrentLogin"];
            else ViewBag.CurrentLogin = "1";
            return View();
        }

        public ActionResult ErrorView(string message)
        {
            return View("ReturnToHome");
        }

         public ActionResult SessionOut()
        {
            return View("ReturnToEntry");
        }

        [HttpGet]
        public ActionResult UserEntry(int login, string password)
        {
            CurrentHolder = Holder.GetOneHolder(login);
            GetCompanySettings();
            GetSession();
            if (CurrentHolder == null)
            {
                AddMySession("Message", "Holder with such login not found. Try again");
                AddMySession("CurrentLogin", login);
                SaveSession();
                return Redirect("/Home/Index");
            }
            ViewBag.Holder = CurrentHolder;
            ViewBag.Message = "";
            AddMySession("CurrentHolder",CurrentHolder);
            AddMySession("UserGuid", new Guid());
            SaveSession();
            return View("HolderHome");
        }


        public ActionResult HolderHome()
        {
            if (!GetSession()) return Redirect("/Home/Index");
            GetCompanySettings();
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            ViewBag.Message = "";
            return View("HolderHome");
        }

        public ActionResult LastTrade()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            BindingList<ShareTrade> bindingTrade = new BindingList<ShareTrade>();
            ShareTrade.GetTrade((Holder)mySession["CurrentHolder"], bindingTrade);
            AddMySession("FullTrade", bindingTrade);
            AddMySession("PortionMyTrade", settings.TradePortion);
            SaveSession();
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            return PartialView("TradeDetails", GetShortTrade(bindingTrade, (int)mySession["PortionMyTrade"]));
        }

        public IEnumerable<ShareTrade> GetShortTrade(IEnumerable<ShareTrade> listTrade, int portion)
        {
            int count = listTrade.Count();
            if (count > portion)
            {
                ViewBag.NextPortion = true;
                return listTrade.Take(portion);
            }
            else
            {
                ViewBag.NextPortion = false;
                return listTrade;
            }
        }

        public ActionResult NextPortion()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            mySession["PortionMyTrade"] = (int)mySession["PortionMyTrade"] + settings.TradePortion;
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            SaveSession();

            return PartialView("TradeDetails", GetShortTrade((IEnumerable<ShareTrade>)mySession["FullTrade"], (int)mySession["PortionMyTrade"]));
        }

        [HttpGet]
        public ActionResult EditHolder()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            ViewBag.PropertySize = Holder.HolderColumnStringLength;
            return PartialView("HolderEdit");
        }

        [HttpPost]
        public ActionResult EditHolder(Holder holder)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            CurrentHolder = (Holder)mySession["CurrentHolder"];
            ViewBag.Holder = CurrentHolder;
            ViewBag.Message = "";
            if (Request["OK"] == "OK")
            {
                if (Holder.CheckSizeHolder(holder))
                {
                    ChangePropertyValue(holder);
                    Holder.ChangeHolder(CurrentHolder);
                    CurrentHolder = Holder.GetOneHolder(CurrentHolder.Id);
                    AddMySession("CurrentHolder", CurrentHolder);
                    SaveSession();
                    ViewBag.Holder = CurrentHolder;
                    ViewBag.Message = "Changes are complete";
                }
                else
                {
                    ViewBag.Message = "Property size is wrong";
                }
            }
            return PartialView("ShowHolder");
        }
 

        public void ChangePropertyValue(Holder someHolder)
        {
            var type = someHolder.GetType();
            foreach (var member in type.GetProperties())
            {
                if (member.GetValue(someHolder) != null)
                {
                    member.SetValue(CurrentHolder, member.GetValue(someHolder));
                }
            }
        }
    }
}