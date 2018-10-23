using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHolder.Filters;
using WebHolder.Models;

namespace WebHolder.Controllers
{
    [ExceptionHandler]
    public class RevenueController : BaseController
    {
        // GET: Revenue
        public ActionResult Index()
        {
            GetCompanySettings();
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            ViewBag.EmissionDate = companySettings.EmissionDate;
            RevenueBox revenueBox = CountRevenue(DateTime.Today.AddDays(-(double)settings.RevenueDays), DateTime.Today);
            AddMySession("RevenueBox", revenueBox);
            SaveSession();
            return View("Index", revenueBox);
        }

        public ActionResult RecountRevenue(string dateFrom, string dateTo)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            GetCompanySettings();
            RevenueBox revenueBox;
            DateTime DateFrom;
            DateTime DateTo;
            if (!DateTime.TryParseExact(dateFrom, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out  DateFrom) || 
                !DateTime.TryParseExact(dateTo, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTo))
            {
                ViewBag.Message = "Incorrect date value";
                revenueBox = (RevenueBox)mySession["RevenueBox"];
            }
            else
            {
                if(DateFrom > DateTo )
                {
                    ViewBag.Message = "Incorrect date order";
                    revenueBox = (RevenueBox)mySession["RevenueBox"];
                }
                else
                {
                    DateTime minDate = DateTime.ParseExact(companySettings.EmissionDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    if(DateFrom < minDate || DateTo < minDate)
                    {
                        ViewBag.Message = "Input date less emission date";
                        revenueBox = (RevenueBox)mySession["RevenueBox"];
                    }
                    else revenueBox = CountRevenue(DateFrom, DateTo);
                }
                    
            }
            ViewBag.EmissionDate = companySettings.EmissionDate;
            return PartialView("MainRevenue", revenueBox);
        }

        public RevenueBox CountRevenue(DateTime dateFrom, DateTime dateTo)
        {
            DateShare dateShareFrom = new DateShare(ShareCost.GetCostDate(dateFrom, true, (Holder)mySession["CurrentHolder"]), dateFrom.ToString("yyyy-MM-dd"), "dateFrom");
            DateShare dateShareTo = new DateShare(ShareCost.GetCostDate(dateTo, false, (Holder)mySession["CurrentHolder"]), dateTo.ToString("yyyy-MM-dd"), "dateTo");
            DataTable dt = ShareTrade.TradePeriod((Holder)mySession["CurrentHolder"], dateFrom, dateTo);
            DataTable dt1 = DivHolder.DividendPeriod((Holder)mySession["CurrentHolder"], dateFrom, dateTo);
            RevenueBox revenueBox = new RevenueBox();
            if (dt.Rows.Count == 0)
            {
                revenueBox.TradeRevenue = new TradeRevenue();
            }
            else
            {
                revenueBox.TradeRevenue = TableToTrade(dt);
            }
            if (dt1.Rows.Count == 0) revenueBox.TradeRevenue.Dividends = 0;
            else revenueBox.TradeRevenue.Dividends = Math.Round((dt1.Rows[0].IsNull("dividend") ? 0 : dt1.Rows[0].Field<decimal>("dividend")), 2);
            revenueBox.DateShareFrom = dateShareFrom;
            revenueBox.DateShareTo = dateShareTo;
            revenueBox.Revenue = revenueBox.DateShareTo.Common * revenueBox.DateShareTo.PriceCommon + revenueBox.DateShareTo.Prefer * revenueBox.DateShareTo.PricePrefer
                                - revenueBox.DateShareFrom.Common * revenueBox.DateShareFrom.PriceCommon - revenueBox.DateShareFrom.Prefer * revenueBox.DateShareFrom.PricePrefer
                                + revenueBox.TradeRevenue.SaleCommonAmount + revenueBox.TradeRevenue.SalePreferAmount - revenueBox.TradeRevenue.BuyCommonAmount - revenueBox.TradeRevenue.BuyPreferAmount
                                - revenueBox.TradeRevenue.Comission
                                + revenueBox.TradeRevenue.Dividends;
            return revenueBox;
        }

        public static TradeRevenue TableToTrade(DataTable dt)
        {
            TradeRevenue tradeRevenue = new TradeRevenue()
            {
                BuyCommonAmount = Math.Round((dt.Rows[0].IsNull("commonBuyAmount") ? 0 : dt.Rows[0].Field<decimal>("commonBuyAmount")), 2),
                BuyCommonQty = dt.Rows[0].IsNull("commonBuy") ? 0 : dt.Rows[0].Field<int>("commonBuy"),
                SaleCommonAmount = Math.Round((dt.Rows[0].IsNull("commonSaleAmount") ? 0 : dt.Rows[0].Field<decimal>("commonSaleAmount")), 2),
                SaleCommonQty = (dt.Rows[0].IsNull("commonSale") ? 0 : dt.Rows[0].Field<int>("commonSale")),
                BuyPreferAmount = Math.Round((dt.Rows[0].IsNull("preferBuyAmount") ? 0 : dt.Rows[0].Field<decimal>("preferBuyAmount")), 2),
                BuyPreferQty = dt.Rows[0].IsNull("preferBuy") ? 0 : dt.Rows[0].Field<int>("preferBuy"),
                SalePreferAmount = Math.Round((dt.Rows[0].IsNull("preferSaleAmount") ? 0 : dt.Rows[0].Field<decimal>("preferSaleAmount")), 2),
                SalePreferQty = dt.Rows[0].IsNull("preferSale") ? 0 : dt.Rows[0].Field<int>("preferSale"),
                Comission = Math.Round((dt.Rows[0].IsNull("comission") ? 0 : dt.Rows[0].Field<decimal>("comission")), 2)
            };
            return tradeRevenue;
        }


    }
}