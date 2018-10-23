using Business;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebHolder.Utils;

namespace WebHolder
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            
            InitCompany();
        }

        public void InitCompany()
        {
            Logger.InitLogger(); 

            Application["ConnectionString"] = WebConfigurationManager.ConnectionStrings["CompanyContext"].ConnectionString;
            DataProvider.connectionString = (string)Application["ConnectionString"];

            DataTable CompanySettings = DataProvider.GetSettingsTable();
            foreach (DataRow r in CompanySettings.Rows)
            {
                Application[r.Field<string>("PropertyName").Trim()] = r.Field<string>("PropertyValue").Trim();
            }

            DataTable holderDesign = DataProvider.GetDesingTable("Holder");
            Holder.HolderColumnStringLength = new Dictionary<string, int>();
            foreach (DataRow r in holderDesign.Rows)
            {
                if (!r.IsNull("character_maximum_length"))
                    Holder.HolderColumnStringLength.Add(r.Field<string>("column_name"), r.Field<int>("character_maximum_length"));
            }

            DataTable ShareQty = DataProvider.GetShareQty();
            Application["CommonShareQty"] = ShareQty.Rows[0].Field<int>("CommonShareTotal");
            Application["PreferShareQty"] = ShareQty.Rows[0].Field<int>("PreferShareTotal");
        }
    }
}
