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
    public class BalanceMovement
    {
        public DateTime Date { set; get; }
        public decimal Amount { set; get; }
        public string Comment { set; get; }

        public BalanceMovement () { }

        public BalanceMovement (DateTime date, decimal amount, string comment)
        {
            Date = date;
            Amount = amount;
            Comment = comment;
        }

        public static DataTable GetBalanceMovement(long accountId)
        // Generalized curency movement on holder balance
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT dateTrade as date, Amount, fields as Comment
                                             FROM (SELECT IIF(idSeller = {accountId}, ShareQty * Price, 0 ) as Sale,
                                                          IIF(idPurchaser = {accountId}, - ShareQty * Price, 0) as Purchase,
			                                              IIF(idSeller = {accountId}, - Comission, 0 ) as Comission,
			                                              dateTrade
	                                                 FROM Trade
		                                            WHERE idSeller = {accountId} OR idPurchaser = {accountId}
		                                          ) as v1
		                                          unpivot (Amount FOR fields in (Sale, Purchase, Comission )) as unpvt
                                            WHERE NOT Amount = 0
                                            UNION
                                           SELECT Date , Amount , 'Moving' as Comment
                                             FROM OrderBalance with (nolock)
                                            WHERE IdHolder = {accountId}
                                            UNION 
                                           SELECT Date as Date , ROUND(AmountOneCommon*commonShareQty+AmountOnePrefer*preferShareQty,2) as Amount, 'Dividends' as Comment
                                             FROM DividendCalculation,DivHolder with (nolock)
                                            WHERE DividendCalculation.idDiv=DivHolder.idDiv  AND idHolder = {accountId} AND Complete = 1 ");
                return dt;
            }
        }
    }
}
