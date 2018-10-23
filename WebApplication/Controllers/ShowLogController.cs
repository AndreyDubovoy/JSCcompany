using Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHolder.Filters;

namespace WebHolder.Controllers
{
    [ExceptionHandler]
    public class ShowLogController : BaseController
    {
        // GET: ShowLog
        public ActionResult Index()
        {
            GetCompanySettings();
            GetSession();
            if (mySession.Keys.Contains("CurrentHolder")) ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            else ViewBag.Holder = new Holder();
            return View();
        }

        public ActionResult ViewLog(HttpPostedFileBase upload)
        {
            string LogText;
            if (upload != null)
            {
                string fileName = Server.MapPath("~/Logs/" +upload.FileName);
                ViewBag.Title = upload.FileName;
                try
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        LogText = sr.ReadToEnd();
                    }
                    if (LogText == "") LogText = "This log file is empty";
                }
                catch (Exception ex)
                {
                    LogText = "Could not open file. Try later." + ex.Message;
                }
            }
            else
            {
                LogText = "File not found";
            }
            GetCompanySettings();
            GetSession();
            if (mySession.Keys.Contains("CurrentHolder")) ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            else ViewBag.Holder = new Holder();
            ViewBag.Text = LogText;
            return View("LogFile");
        }
    }
} 