using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ShareCost
    {
        public long Common { set; get; }
        public decimal PriceCommon { set; get; }
        public long Prefer { set; get; }
        public decimal PricePrefer { set; get; }

        public ShareCost() { }

        public static ShareCost GetCostDate(DateTime dateTime, bool countLastDay, Holder holder)
        // Calculate quantity and cost shares on required day
        // countLastDay - include or not include trade during required day
        {
            ShareCost shareCost = new ShareCost();
            DataTable dt2 = ShareTrade.TradePeriod(holder, countLastDay ? dateTime : dateTime.AddDays(1), DateTime.Today);
            Holder fullHolder = Holder.GetOneHolder(holder.Id);
            if (dt2.Rows.Count == 0)
            {
                shareCost.Common = fullHolder.CommonShare;
                shareCost.Prefer = fullHolder.PreferShare;
            }
            else
            {
                shareCost.Common = fullHolder.CommonShare
                    - (dt2.Rows[0].IsNull("commonBuy") ? 0 : dt2.Rows[0].Field<Int32>("commonBuy"))
                    + (dt2.Rows[0].IsNull("commonSale") ? 0 : dt2.Rows[0].Field<Int32>("commonSale"));
                shareCost.Prefer = fullHolder.PreferShare
                    - (dt2.Rows[0].IsNull("preferBuy") ? 0 : dt2.Rows[0].Field<int>("preferBuy"))
                    + (dt2.Rows[0].IsNull("preferSale") ? 0 : dt2.Rows[0].Field<int>("preferSale"));
            }
            DataTable dt3 = PriceQuote.GetPriceQuoteDate(dateTime, "common");
            DataTable dt4 = PriceQuote.GetPriceQuoteDate(dateTime, "prefer");
            shareCost.PriceCommon = dt3.Rows[0].Field<decimal>("commonPrice");
            shareCost.PricePrefer = dt4.Rows[0].Field<decimal>("preferPrice");
            return shareCost;
        }
    }
}
