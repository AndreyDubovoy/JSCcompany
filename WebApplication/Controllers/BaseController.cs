using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHolder.Models;

namespace WebHolder.Controllers
{
    public class BaseController : Controller
    {
        public Dictionary<string, object> mySession;
        public CompanySettings companySettings;
        public Settings settings;
        public bool GetSession()
        {
            GetCookies();
            mySession = new Dictionary<string, object>();
            if (Session.Count == 0) return false;
            var keys = Session.Keys;
            foreach (var k in keys)
            {
                mySession.Add((string)k, Session[(string)k]);
            }
            return true;
        }

        public void SaveSession()
        {
            foreach (var s in mySession)
            {
                Session[s.Key] = s.Value;
            }
        }

        public void AddMySession(string key, object value)
        {
            if (mySession.ContainsKey(key)) mySession[key] = value;
            else mySession.Add(key, value);
        }

        public void RemoveMySession(string key)
        {
            if (mySession.ContainsKey(key))
            {
                mySession.Remove(key);
                Session[key] = null;
            } 
 
        }
        public void GetCompanySettings()
        {
            companySettings = new CompanySettings();
            companySettings.NameCompany = (string)HttpContext.Application["NameCompany"];
            companySettings.EmissionDate = (string)HttpContext.Application["EmissionDate"];
            companySettings.CommonShareTotal = (int)HttpContext.Application["CommonShareQty"];
            companySettings.PreferShareTotal = (int)HttpContext.Application["PreferShareQty"];
            companySettings.TradeComission = Decimal.Parse((string)HttpContext.Application["TradeComission"], NumberStyles.Any, new CultureInfo("en-US"));
            ViewBag.CompanySettings = companySettings;
        }

        public void SetCookies()
        {
            var type = settings.GetType();
            foreach (var member in type.GetProperties())
            {
                HttpContext.Response.Cookies[member.Name].Value = member.GetValue(settings).ToString();
            }

        }

        public void GetCookies()
        {
            settings = new Settings();
                var type = settings.GetType();
                foreach (var member in type.GetProperties())
                { 
                    if(HttpContext.Request.Cookies[member.Name] != null)
                        member.SetValue(settings, Int32.Parse(HttpContext.Request.Cookies[member.Name].Value));
                }
        }
    }
}