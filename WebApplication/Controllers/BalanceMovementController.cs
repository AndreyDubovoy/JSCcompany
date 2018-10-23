using Business;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHolder.Filters;
using WebHolder.Models;
using WebHolder.Utils;

namespace WebHolder.Controllers
{
    [ExceptionHandler]
    public class BalanceMovementController : BaseController
    {
        public Holder CurrentHolder;

        // GET: BalanceMovements
        public ActionResult Index()
        {
            GetCompanySettings();
            if (!GetSession()) return Redirect("/Home/SessionOut");
            CurrentHolder = (Holder)mySession["CurrentHolder"];
            AddMySession("Portion", settings.BalancePortion);
            AddMySession("BalanceFilterOrder", new BalanceFilterOrder());
            SaveSession();
            ViewBag.Holder = CurrentHolder;
            return View("Balance");
        }

        [HttpPost]
        public ActionResult Balance()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            CurrentHolder = (Holder)mySession["CurrentHolder"];
            ViewBag.FilterOrder = (BalanceFilterOrder)mySession["BalanceFilterOrder"];

            ViewBag.NextPortion = false;
            DataTable dt = BalanceMovement.GetBalanceMovement(CurrentHolder.Id);
            List<BalanceMovement> BalanceList = new List<BalanceMovement>();
            foreach (DataRow r in dt.Rows)
            {
                BalanceList.Add(new BalanceMovement(r.Field<DateTime>("Date"), Math.Round(r.Field<decimal>("Amount"), 2), r.Field<string>("Comment").Trim()));
            }

            AddMySession("BalanceList", BalanceList);
            SetBalanceFilterOrder SetBalanceFO = new SetBalanceFilterOrder();
            SetBalanceFO.balanceFO = (BalanceFilterOrder)mySession["BalanceFilterOrder"];
            var FiltredBalanceList = SetBalanceFO.GetBalanceFiltrOrder(BalanceList);
            AddMySession("FiltredBalanceList", FiltredBalanceList);
            SaveSession();
            return PartialView("BalanceDetails", GetShortBalance(FiltredBalanceList, (int)mySession["Portion"]));
        }

 
        public IEnumerable<BalanceMovement> GetShortBalance(IEnumerable<BalanceMovement> FullBalance, int portion)
        {
            int count = FullBalance.Count();
            if (count > portion)
            {
                ViewBag.NextPortion = true;
                return FullBalance.Take((int)mySession["Portion"]);
            }
            else
            {
                ViewBag.NextPortion = false;
                return FullBalance;
            }
        }

        public ActionResult NextPortion()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            mySession["Portion"] = (int)mySession["Portion"] +settings.BalancePortion;
            ViewBag.FilterOrder = (BalanceFilterOrder)mySession["BalanceFilterOrder"];
            SaveSession();
            return PartialView("Details", GetShortBalance((IEnumerable<BalanceMovement>)mySession["FiltredBalanceList"], (int)mySession["Portion"])); 
        }

        public PartialViewResult RefillWithdraw()
        {
            if (Request["Refill"] == "Refill") ViewBag.MovingType = "Refill";
                else ViewBag.MovingType = "Withdraw";

            return PartialView("MovingBalance");
        }

        public ActionResult MovingResult(string MovingType, string Amount)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            CurrentHolder = (Holder)mySession["CurrentHolder"];
            ViewBag.Message = "";
            if (!(Request["Cancel"] == "Cancel"))
            {
                if (!GetSession()) return Redirect("/Home/SessionOut");
                CurrentHolder = (Holder)mySession["CurrentHolder"];
                decimal amount = Decimal.Parse(Amount.Replace('.', ','));
                if (MovingType == "Withdraw") amount = -amount;
                SqlException ex = Holder.MovingBalance(CurrentHolder.Id, amount);
                if (ex == null)
                {
                    if (mySession.ContainsKey("BalanceList"))
                    {
                        List<BalanceMovement> BalanceList = (List<BalanceMovement>)mySession["BalanceList"];
                        BalanceList.Insert(0, new BalanceMovement()
                        {
                            Date = DateTime.Today,
                            Amount = Bid.DecimalFormat(amount),
                            Comment = "Moving"
                        });
                        mySession["BalanceList"] = BalanceList;
                        SetBalanceFilterOrder SetBalanceFO = new SetBalanceFilterOrder
                        {
                            balanceFO = (BalanceFilterOrder)mySession["BalanceFilterOrder"]
                        };
                        var FiltredBalanceList = SetBalanceFO.GetBalanceFiltrOrder((List<BalanceMovement>)mySession["BalanceList"]);
                        AddMySession("FiltredBalanceList", FiltredBalanceList);
                    }
                    CurrentHolder.Balance = CurrentHolder.Balance + amount;
                    mySession["CurrentHolder"] = CurrentHolder;
                    SaveSession();
                    ViewBag.Message = MovingType + " " + Amount + (MovingType == "Refill" ? " from" : " to") + " your card ";
                }
                else
                {
                    ViewBag.Message = "Transaction is rejection: " + ex.Message;
                }
            }
            ViewBag.Holder = CurrentHolder;
            return PartialView("BalanceContent");
        }

        public ActionResult ChangeFilterOrder()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.FilterOrder = (BalanceFilterOrder)mySession["BalanceFilterOrder"];
            return PartialView("FilterOrder");
        }

        public ActionResult SetFilterOrder(BalanceFilterOrder BalanceFO)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            if (Request["OK"] == "Apply")
            {
                SetBalanceFilterOrder SetBalanceFO = new SetBalanceFilterOrder
                {
                    balanceFO = BalanceFO
                };
                var FiltredBalanceList = SetBalanceFO.GetBalanceFiltrOrder((List<BalanceMovement>)mySession["BalanceList"]);
                AddMySession("FiltredBalanceList", FiltredBalanceList);
                AddMySession("BalanceFilterOrder", BalanceFO);
                SaveSession();
            }
            ViewBag.FilterOrder = (BalanceFilterOrder)mySession["BalanceFilterOrder"];
            return PartialView("BalanceDetails", GetShortBalance((IEnumerable<BalanceMovement>)mySession["FiltredBalanceList"], (int)mySession["Portion"]));
        }
    }
}