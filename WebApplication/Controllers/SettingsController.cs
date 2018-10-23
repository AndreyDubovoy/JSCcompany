using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHolder.Filters;
using WebHolder.Models;

namespace WebHolder.Controllers
{
    [ExceptionHandler]
    public class SettingsController : BaseController
    {
        // GET: Settings
        public ActionResult Index()
        {
            GetCompanySettings();
            GetSession();
            if (mySession.Keys.Contains("CurrentHolder")) ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            else ViewBag.Holder = new Holder();
            ViewBag.Settings = settings;
            return View();
        }

        public ActionResult EditSettings(Settings newSettings)
        {
            if (Request["Save"] == "Save")
            {
                GetCookies();
                var type = newSettings.GetType();
                foreach (var member in type.GetProperties())
                {
                    if (member.GetValue(newSettings) != null)
                    {
                        member.SetValue(settings, member.GetValue(newSettings));
                    }
                }
                ViewBag.Message = "Settings are changed";
                SetCookies();
            }
             else  ViewBag.Message = "Settings don't changed";
            return PartialView("EditSettingsResult");
        }
    }
}