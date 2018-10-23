using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Framework.Db;

namespace Business
{
    public class PriceQuote
    {
        public DateTime Date { set; get; }
        public decimal CommonPrice { set; get; }
        public decimal PreferPrice { set; get; }

        public PriceQuote() { }

        public static PriceQuote QuoteFromTable(DataRow t)
        {
            return new PriceQuote()
            {
                Date = t.Field<DateTime>("date"),
                CommonPrice = Math.Round(t.Field<decimal>("commonPrice"), 2),
                PreferPrice = Math.Round(t.Field<decimal>("preferPrice"), 2)
            };
        }

        public static DataTable CheckQuotePrice() // Control  do you need refresh quote table
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT datetrade 
                                             FROM Trade
                                           EXCEPT 
                                           SELECT date 
                                             FROM PriceQuote");
                return dt;
            }
        }

        public static DataTable GetPriceQuoteDate(DateTime date, string shareType)
        // Get price quote near required date
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql =  $@"SELECT
                                    TOP 1 {shareType}Price
                                   FROM PriceQuote
                                  WHERE date <= '{date.ToString("yyyy-MM-dd")}' AND NOT {shareType}Price = 0
                               ORDER BY date DESC ";
                conn.GetQueryResult(dt, sql);
                return dt;
            }
        }

        public static DataTable GetPriceQuoteTable(int quantityDays)
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT
                                              TOP {quantityDays} *
                                             FROM PriceQuote
                                         ORDER BY date DESC ");
                return dt;
            }
        }

        public static void SaveNewQuote()
        // Calculate and save new price quote using Sql view
        // weighted average trade price for every day
        {
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql = $@"INSERT INTO PriceQuote(Date,
                                                       CommonPrice,
                                                       PreferPrice)
                                SELECT datetrade,
                                       ROUND(PriceCommon,2),
                                       ROUND(PricePrefer,2)
                                  FROM view_quote ";
                conn.ExecuteCommand(sql);
            }
        }
    }
}
