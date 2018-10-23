using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

using System.Data;
using Framework.Db;
using Data;


namespace Business
{
    public class ShareTrade 
    {
        public long IdTrade { set; get; }
        public DateTime DateTrade { set; get; }
        public long IdSeller { set; get; }
        public string NameSeller { set; get; }
        public long IdPurchaser { set; get; }
        public string NamePurchaser { set; get; }
        public long ShareQty { set; get; }
        public string ShareType { set; get; }
        public decimal Price { set; get; }

        public ShareTrade()  { }

        public static DataTable GetTradeTable()
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT * 
                                             FROM Trade ");
                return dt;
            }
        }

        public static DataTable GetTradeTablePortion(long tradeId)
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT idTrade,
                                                  dateTrade,
                                                  idPurchaser,
                                                  a.FirstName,
                                                  a.SecondName,
                                                  idSeller,
                                                  b.FirstName,
                                                  b.SecondName,
                                                  ShareQty,
                                                  ShareType,
                                                  price
                                             FROM Trade,
                                                  Holder a,
                                                  Holder b
                                            WHERE ( idPurchaser = {tradeId} 
                                               OR idSeller = {tradeId})
                                              AND (idPurchaser = a.idHolder 
                                              AND idSeller = b.idHolder)
                                         ORDER BY dateTrade DESC");
                return dt;
            }
        }

        public static void GetTrade(Holder someHolder, BindingList<ShareTrade> bindingTrade)
        {
            DataTable tableTrade = ShareTrade.GetTradeTablePortion(someHolder.Id);

            foreach (DataRow t in tableTrade.Rows)
            {
                bindingTrade.Add(new ShareTrade()
                {
                    IdTrade = t.Field<int>("idTrade"),
                    DateTrade = t.Field<DateTime>("dateTrade"),
                    IdSeller = t.Field<int>("idSeller"),
                    NameSeller = t.Field<string>("firstName1").Trim() + ' ' + t.Field<string>("secondName1").Trim(),
                    IdPurchaser = t.Field<int>("idPurchaser"),
                    NamePurchaser = t.Field<string>("firstName").Trim() + ' ' + t.Field<string>("secondName").Trim(),
                    ShareQty = t.Field<int>("ShareQty"),
                    ShareType = t.Field<string>("ShareType"),
                    Price = Math.Round(t.Field<decimal>("price"), 2)
                });
            }
        }

        public static DataTable TradePeriod(Holder someHolder, DateTime fromDate, DateTime toDate)
        // Get total trade for some holder during period
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT SUM(IIF(ShareType = 'common' AND idSeller = {someHolder.Id}, ShareQty*Price, 0)) as commonSaleAmount,
                                                  SUM(IIF(ShareType = 'common' AND idSeller = {someHolder.Id}, ShareQty, 0)) as commonSale,
                                                  SUM(IIF(ShareType = 'common' AND idPurchaser = {someHolder.Id}, ShareQty*Price, 0)) as commonBuyAmount,
                                                  SUM(IIF(ShareType = 'common' AND idPurchaser = {someHolder.Id}, ShareQty, 0)) as commonBuy,
                                                  SUM(IIF(ShareType = 'prefer' AND idSeller = {someHolder.Id}, ShareQty*Price, 0)) as preferSaleAmount,
                                                  SUM(IIF(ShareType = 'prefer' AND idSeller = {someHolder.Id}, ShareQty, 0)) as preferSale,
                                                  SUM(IIF(ShareType = 'prefer' AND idPurchaser = {someHolder.Id}, ShareQty*Price, 0)) as preferBuyAmount,
                                                  SUM(IIF(ShareType = 'prefer' AND idPurchaser = {someHolder.Id}, ShareQty, 0)) as preferBuy,
                                                  SUM(IIF(idSeller = {someHolder.Id}, comission, 0)) as comission
                                             FROM Trade
                                            WHERE (datetrade between '{fromDate.ToString("yyyy-MM-dd")}' AND '{toDate.ToString("yyyy-MM-dd")}')
                                                  AND (idSeller = {someHolder.Id} OR idPurchaser = {someHolder.Id})");
                return dt;
            }
        }
    }
}
