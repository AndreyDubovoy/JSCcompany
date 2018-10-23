using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Framework.Db;
using Framework.Utils;

namespace Business
{
    public class Dividend
    {
        public long Id { set; get; }
        public DateTime Date { set; get; }
        public long AllCommon { set; get; }
        public long AllPrefer { set; get; }
        public decimal AmountRevenue { set; get; }
        public decimal AmountOnePrefer { set; get; }
        public decimal AmountOneCommon { set; get; }
        public bool Complete { set; get; }

        public Dividend () { }

        public static DataTable GetDividendTable(long id) // 0 - Get dividend table for all dividend ID
        {
            DataTable dt = new DataTable();
            string AddWhere = id == 0 ? "" : $@"WHERE idDiv={id}";
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT * 
                                             FROM DividendCalculation " + AddWhere);
                return dt;
            }
        }

        public static long SaveNewDiv(out SqlException ex)
        {
            long newId = 0;
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                try
                {
                    conn.BeginTransaction();
                    string sqlDivCalc = $@"INSERT INTO DividendCalculation (Date,
                                                                            AmountRevenue,
                                                                            AllCommonShareQty,
                                                                            AllPreferShareQty,
                                                                            AmountOneCommon,
                                                                            AmountOnePrefer,
                                                                            Complete)                                             
                                     VALUES (@Today,
                                              0,0,0,0,0,0)";
                    SqlCommand command1 = new SqlCommand(sqlDivCalc, (SqlConnection)conn.Connection);
                    command1.Transaction = (SqlTransaction)conn.Transaction;
                    command1.Parameters.Add(new SqlParameter("@Today", DateTime.Today.ToString("yyyy-MM-dd")));
                    command1.ExecuteNonQuery();
                    newId = Decimal.ToInt32((decimal)conn.ExecuteScalar("SELECT IDENT_CURRENT('DividendCalculation')"));

                    string sqlDivHolder = $@"INSERT INTO DivHolder (IdDiv,
                                                                    IdHolder, 
                                                                    CommonShareQty, 
                                                                    PreferShareQty)
                                             SELECT @IdDiv,
                                                    IdHolder,
                                                    CommonShareQty,
                                                    PreferShareQty
                                               FROM Holder
                                              WHERE (CommonShareQty > 0  OR PreferShareQty > 0)";
                    SqlCommand command2 = new SqlCommand(sqlDivHolder, (SqlConnection)conn.Connection);
                    command2.Transaction = (SqlTransaction)conn.Transaction;
                    command2.Parameters.Add(new SqlParameter("@IdDiv", newId));
                    command2.ExecuteNonQuery();
                   
                    string sqlUpdateDiv = $@"UPDATE DividendCalculation
                                                SET AllCommonShareQty = sum_.c, 
                                                    AllPreferShareQty = sum_.p
                                               FROM DividendCalculation, 
                                                    (SELECT SUM(CommonShareQty) as c,
	                                                        SUM(PreferShareQty) as p
                                                       FROM DivHolder
                                                      WHERE IdDiv = @IdDiv) sum_";
                    SqlCommand command3 = new SqlCommand(sqlUpdateDiv, (SqlConnection)conn.Connection);
                    command3.Transaction = (SqlTransaction)conn.Transaction;
                    command3.Parameters.Add(new SqlParameter("@IdDiv", newId));
                    command3.ExecuteNonQuery();
                    
                    conn.Commit();
                    ex = null;
                }
                catch (SqlException e)
                {
                    conn.Rollback();
                    ex = e;
                    return 0;
                }
            }
            return newId;
        }

        public static void ChangeDiv(Dividend someDiv)
        {
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql = $@"UPDATE DividendCalculation
                                   SET AmountRevenue = @AmountRevenue,
                                       AmountOnePrefer = @AmountOnePrefer,
                                       AmountOneCommon = @AmountOneCommon
                                 WHERE idDiv = @IdDiv";
                SqlCommand command = new SqlCommand(sql, (SqlConnection)conn.Connection);
                command.Parameters.Add(new SqlParameter("@AmountRevenue", someDiv.AmountRevenue));
                command.Parameters.Add(new SqlParameter("@AmountOnePrefer", someDiv.AmountOnePrefer));
                command.Parameters.Add(new SqlParameter("@AmountOneCommon", someDiv.AmountOneCommon));
                command.Parameters.Add(new SqlParameter("@IdDiv", someDiv.Id));
                command.ExecuteNonQuery();
            }
        }
    }
}
