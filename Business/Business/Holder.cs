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
    public enum HolderOrder
    {
        Id,
        FirstName,
        SecondName,
        CommonShare,
        PreferShare
    }

    public class Holder 
    {
        public long Id { set; get; } = 0;
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public long CommonShare { set; get; } = 0;
        public long PreferShare { set; get; } = 0;
        public decimal Balance { set; get; } = 0;
        public string Phone { set; get; }
        public string Email { set; get; }

        public static Dictionary<string, int> HolderColumnStringLength;

        public Holder () { }

        public static Holder GetOneHolder(long id)
        {
           string sql = $@"SELECT * 
                             FROM Holder 
                            WHERE idHolder = {id}";

            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                DataTable dt = new DataTable();
                conn.GetQueryResult(dt, sql);
                if (dt.Rows.Count == 0) return null;
                else return TableToBindingHolder(dt.Rows[0]);
            }
        }

        public static bool CheckSizeHolder(Holder someHolder)
        {
            var type = someHolder.GetType();
            foreach (var size in Holder.HolderColumnStringLength)
            {
                var propertyInfo = type.GetProperty(size.Key);
                string holderProperty = (string)propertyInfo.GetValue(someHolder);
                if (holderProperty != null)
                {
                    if (holderProperty.Trim().Length > size.Value) return false;
                    propertyInfo.SetValue(someHolder, holderProperty.Trim());
                }
            }
            return true;
        }

        public static Holder TableToBindingHolder(DataRow row)
        {
            Holder holders = new Holder()
            {
                Id = row.Field<int>("idHolder"),
                FirstName = row.Field<string>("firstName"),
                SecondName = row.Field<string>("secondName"),
                CommonShare = row.Field<int>("commonShareQty"),
                PreferShare = row.Field<int>("preferShareQty"),
                Balance = Math.Round(row.Field<decimal>("balance"), 2),
                Phone = row.Field<string>("phone"),
                Email = row.Field<string>("email")
            };
            return holders;
        }

        public static DataTable GetHolderTable(int portion) // If portion = 0, get all table rows
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql;
                if (portion == 0)
                {
                    sql = $@"SELECT *
                               FROM Holder 
                              ORDER BY idHolder";
                }
                else
                {
                    sql = $@"SELECT
                                TOP {portion} *
                               FROM Holder 
                              ORDER BY idHolder";
                }
                conn.GetQueryResult(dt, sql);
                return dt;
            }
        }

        public static DataTable GetHolderForMenu()
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql;
                sql = $@"SELECT idHolder,
                                FirstName,
                                SecondName,
                                CommonShareQty,
                                PreferShareQty
                           FROM Holder 
                       ORDER BY idHolder";
                conn.GetQueryResult(dt, sql);
                return dt;
            }
        }

        public static DataTable GetHolderTableNextPortion(int portion, Holder currentHolder, HolderOrder order, string upDown)
        {
            string direction = upDown == "ASC" ? ">" : "<";
            string reverseDirection = upDown == "ASC" ? "<" : ">";
            string filtrOrder;
            switch (order)
            {

                case HolderOrder.Id:
                    {
                        filtrOrder = $@"WHERE idHolder { direction} { currentHolder.Id}
                                     ORDER BY idHolder";
                        break;
                    }
                case HolderOrder.FirstName:
                    {
                        filtrOrder = StringQueryHolder("firstName", currentHolder.FirstName, currentHolder.Id, upDown);
                        break;
                    }
                case HolderOrder.SecondName:
                    {
                        filtrOrder = StringQueryHolder("secondName", currentHolder.SecondName, currentHolder.Id, upDown);
                        break;
                    }
                case HolderOrder.CommonShare:
                    {
                        filtrOrder = ScalarQueryHolder("commonShareQty", currentHolder.CommonShare, currentHolder.Id, upDown);
                        break;
                    }
                case HolderOrder.PreferShare:
                    {
                        filtrOrder = ScalarQueryHolder("preferShareQty", currentHolder.PreferShare, currentHolder.Id, upDown);
                        break;
                    }
                default:
                    {
                        filtrOrder = "";
                        break;
                    }

            }
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT
                                              TOP {portion} *
                                             FROM Holder a 
                                                  {filtrOrder} {upDown} ");
                return dt;
            }
        }

        // Create Holder Sql query for string properties
        private static string StringQueryHolder(string propertyName, string propertyValue, long currentId, string upDown)
        {
            string direction = upDown == "ASC" ? ">" : "<";
            string reverseDirection = upDown == "ASC" ? "<" : ">";

            return $@"WHERE {propertyName} { direction}= '{propertyValue}'
                    AND NOT ({propertyName} = '{propertyValue}' 
                        AND idHolder { reverseDirection}= { currentId})
                   ORDER BY {propertyName} {upDown}, idHolder ";
        }

        // Create Holder Sql query for scalar properties
        private static string ScalarQueryHolder(string propertyName, long propertyValue, long currentId, string upDown)
        {
            string direction = upDown == "ASC" ? ">" : "<";
            string reverseDirection = upDown == "ASC" ? "<" : ">";

            return $@"WHERE {propertyName} { direction}= {propertyValue}
                    AND NOT ({propertyName} = {propertyValue}
                        AND idHolder { reverseDirection}= { currentId})
                   ORDER BY {propertyName} {upDown}, idHolder ";
        }

        public static void ChangeHolder(Holder someHolder)
        {
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql = $@"UPDATE Holder
                                   SET firstName = @FirstName,
                                       secondName = @SecondName,
                                       phone = @Phone,
                                       email = @Email
                                 WHERE idHolder = @IdHolder ";
                SqlCommand command = new SqlCommand(sql, (SqlConnection)conn.Connection);
                CreateParamHolder(command, someHolder, true);
                command.ExecuteNonQuery();
            }
        }

        private static void CreateParamHolder(SqlCommand command, Holder someHolder, bool withId )
        {
            command.Parameters.Add(new SqlParameter("@FirstName", someHolder.FirstName));
            command.Parameters.Add(new SqlParameter("@SecondName", someHolder.SecondName));
            command.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, HolderColumnStringLength["Phone"]));
            command.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, HolderColumnStringLength["Email"]));
            if (withId) command.Parameters.Add(new SqlParameter("@IdHolder", someHolder.Id));
            command.Parameters["@Phone"].Value = someHolder.Phone == null ? Convert.DBNull : someHolder.Phone;
            command.Parameters["@Email"].Value = someHolder.Email == null ? Convert.DBNull : someHolder.Email;
        }

        public static long SaveNewHolder(Holder someHolder) // Return new holder Id
        {
            long newId = 0;
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql = $@"INSERT INTO Holder (firstName,
                                                     secondName,
                                                     commonShareQty,
                                                     preferShareQty,
                                                     balance,
                                                     phone,
                                                     email)
                                     VALUES (@FirstName,
                                             @SecondName,
                                              0,0,0,
                                             @Phone,
                                             @Email)";
                SqlCommand command = new SqlCommand(sql, (SqlConnection)conn.Connection);
                CreateParamHolder(command, someHolder, false);
                command.ExecuteNonQuery();
                newId = Decimal.ToInt32((decimal)conn.ExecuteScalar("SELECT IDENT_CURRENT('Holder')"));
            }
            return newId;
        }

        public static SqlException MovingBalance(long id, decimal Amount)
        {
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                try
                {
                    conn.BeginTransaction();
                    string sql1 = $@"UPDATE Holder
                                        SET balance = balance + @Amount
                                      WHERE idHolder = @Id";

                    string sql2 = $@"INSERT INTO OrderBalance ( idHolder,
                                                                date,
                                                                Amount)
                                          VALUES (@Id,
                                                  @Today,
                                                  @Amount)";
                    SqlCommand command1 = new SqlCommand(sql1, (SqlConnection)conn.Connection);
                    command1.Transaction = (SqlTransaction)conn.Transaction;
                    command1.Parameters.Add(new SqlParameter("@Amount", Amount));
                    command1.Parameters.Add(new SqlParameter("@Id", id));
                    command1.ExecuteNonQuery();

                    SqlCommand command2 = new SqlCommand(sql2, (SqlConnection)conn.Connection);
                    command2.Transaction = (SqlTransaction)conn.Transaction;
                    command2.Parameters.Add(new SqlParameter("@Id", id));
                    command2.Parameters.Add(new SqlParameter("@Today", DateTime.Today.ToString("yyyy-MM-dd")));
                    command2.Parameters.Add(new SqlParameter("@Amount", Amount));
                    command2.ExecuteNonQuery();

                    conn.Commit();
                }
                catch (SqlException e)
                {
                    conn.Rollback();
                    return e;
                }
            }
            return null;
        }

        public static SqlException SaveDividendToBalance(Dividend someDiv)
        {
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                try
                {
                    conn.BeginTransaction();
                    string sql1 = ($@"UPDATE Holder
                                         SET balance = balance + ISNULL(div.d,0)
                                        FROM Holder,
									         (SELECT (CommonShareQty * @AmountOneCommon 
                                                            + PreferShareQty * @AmountOnePrefer) as d,
                                                      IdHolder as i
											    FROM DivHolder
                                               WHERE idDiv = @IdDIv) div
									  WHERE idHolder = div.i");

                    string sql2 = ($@"UPDATE DividendCalculation
                                         SET Complete = 1
                                       WHERE idDiv = @IdDiv");

                    SqlCommand command1 = new SqlCommand(sql1, (SqlConnection)conn.Connection);
                    command1.Transaction = (SqlTransaction)conn.Transaction;
                    command1.Parameters.Add(new SqlParameter("@AmountOneCommon", someDiv.AmountOneCommon));
                    command1.Parameters.Add(new SqlParameter("@AmountOnePrefer", someDiv.AmountOnePrefer));
                    command1.Parameters.Add(new SqlParameter("@IdDiv", someDiv.Id));
                    command1.ExecuteNonQuery();

                    SqlCommand command2 = new SqlCommand(sql2, (SqlConnection)conn.Connection);
                    command2.Transaction = (SqlTransaction)conn.Transaction;
                    command2.Parameters.Add(new SqlParameter("@IdDiv", someDiv.Id));
                    command2.ExecuteNonQuery();

                    conn.Commit();
                }
                catch (SqlException e)
                {
                    conn.Rollback();
                    return e;
                }
            }
            return null;
        }
    }
}
