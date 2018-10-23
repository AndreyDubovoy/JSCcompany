using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Framework.Db;
using Business;

namespace Business
{
    public class DivHolder
    {
        public long IdHolder { set; get; }
        public string Name { set; get; }
        public decimal AmountCommon { set; get; }
        public decimal AmountPrefer { set; get; }

        public DivHolder() { }

        public static DataTable DividendPeriod(Holder someHolder, DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT sum(commonShareQty * AmountOneCommon+ preferShareQty*AmountOnePrefer) as dividend
                                             FROM DividendCalculation, DivHolder
                                            WHERE (date between '{fromDate.ToString("yyyy-MM-dd")}' AND '{toDate.ToString("yyyy-MM-dd")}')
                                                  AND DividendCalculation.idDiv = DivHolder.idDiv AND idHolder = {someHolder.Id}");
                return dt;
            }
        }

        public static DataTable GetDivHolderTable(long idDiv)
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT idDiv,
                                                  DivHolder.idHolder,
                                                  DivHolder.commonShareQty,
                                                  DivHolder.preferShareQty,
                                                  firstName,
                                                  secondName
                                             FROM DivHolder, Holder 
                                            WHERE idDiv = {idDiv} AND DivHolder.idHolder = Holder.idHolder");
                return dt;
            }
        }
    }
}
