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

// djgf;adjgf;lasjf;asjr;fl;lj
namespace Business
{
    public class Bid
    {
        public long IdBid { set; get; }
        public long IdTrader { set; get; }
        public string NameTrader { set; get; }
        public string TradeType { set; get; } // "buy" or "sale"
        public DateTime Date { set; get; }
        public long ShareBidQty { set; get; }
        public string ShareType { set; get; } // "common" or "prefer"
        public decimal Price { set; get; }
        public long ExecutedShareBidQty { set; get; }
        public bool Complete { set; get; }
        public Guid NameUser { set; get; }
        public bool Closed { set; get; }

        public Bid() { }

        public static Bid BidFromTable(DataRow t)
        {
           return  new Bid()
            {
                IdBid = t.Field<int>("idBid"),
                IdTrader = t.Field<int>("idHolder"),
                NameTrader = t.Field<string>("firstName").Trim() + ' ' + t.Field<string>("secondName").Trim(),
                TradeType = t.Field<string>("tradeType").Trim(),
                Date = t.Field<DateTime>("date"),
                ShareBidQty = t.Field<int>("shareBidQty"),
                ShareType = t.Field<string>("shareType").Trim(),
                Price = Math.Round(t.Field<decimal>("price"), 2),
                ExecutedShareBidQty = t.Field<int>("executedShareBidQty"),
                Complete = t.Field<int>("complete") > 0,
                NameUser = t.IsNull("GuidUser") ? Guid.Empty : t.Field<Guid>("GuidUser"),
                Closed = t.Field<int>("closed") > 0
            };
        }
        public static SqlException ReserveBid(long currentBid, Guid userGuid, bool reserve)
        {
            string guidString = reserve ? "'" + userGuid.ToString() + "'" : "NULL";
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                try
                {
                    string sql = $@"UPDATE Bid 
                                   SET GuidUser = @Guid
                                 WHERE idBid = @IdBid";
                    SqlCommand command = new SqlCommand(sql, (SqlConnection)conn.Connection);
                    command.Parameters.Add(new SqlParameter("@Guid", SqlDbType.UniqueIdentifier));
                    command.Parameters.Add(new SqlParameter("@IdBid", currentBid));
                    command.Parameters["@Guid"].Value = reserve ? userGuid : Convert.DBNull;
                    command.ExecuteNonQuery();
                    return null;
                }
                catch (SqlException e)
                {
                    return e;
                }
            }
        }

        public static void CloseBid(long currentBid)
        {
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql = $@"UPDATE Bid 
                                   SET closed = 1
                                 WHERE idBid = @IdBid";
                SqlCommand command = new SqlCommand(sql, (SqlConnection)conn.Connection);
                command.Parameters.Add(new SqlParameter("@IdBid", currentBid));
                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetBidTable(string cutDayComplete)
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT idBid,
                                                  Bid.idHolder,
                                                  tradeType,
                                                  date,
                                                  shareBidQty,
                                                  shareType,
                                                  price,
                                                  executedShareBidQty,
                                                  complete,
                                                  firstName,
                                                  secondName,
                                                  GuidUser,
                                                  closed
                                             FROM Bid 
                                             JOIN Holder 
                                               ON Bid.idHolder = Holder.idHolder
                                            WHERE (complete = 0 AND closed = 0) 
                                               OR (date > '{cutDayComplete}')");
                return dt;

            }
        }

        public static long SaveNewBid(Bid newBid)
        {
            long newId;
            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                string sql = $@"INSERT INTO Bid (idHolder,
                                                 tradeType,
                                                 date,
                                                 shareBidQty,
                                                 shareType,
                                                 price,
                                                 executedShareBidQty,
                                                 complete,
                                                 closed)
                                     VALUES (@IdTrader,
                                             @TradeType,
                                             @Date,
                                             @ShareBidQty,
                                             @ShareType,
                                             @Price,
                                             0,0,0)";
                SqlCommand command = new SqlCommand(sql, (SqlConnection)conn.Connection);
                command.Parameters.Add(new SqlParameter("@IdTrader", newBid.IdTrader));
                command.Parameters.Add(new SqlParameter("@TradeType", newBid.TradeType));
                command.Parameters.Add(new SqlParameter("@Date", newBid.Date.ToString("yyyy-MM-dd")));
                command.Parameters.Add(new SqlParameter("@ShareBidQty", newBid.ShareBidQty));
                command.Parameters.Add(new SqlParameter("@ShareType", newBid.ShareType));
                command.Parameters.Add(new SqlParameter("@Price", newBid.Price));
                command.ExecuteNonQuery();
                newId = Decimal.ToInt32((decimal)conn.ExecuteScalar("SELECT IDENT_CURRENT('Bid')"));
            }
            return newId;
        }

        public static SqlException SaveExecutedBid(Bid bid, int shareQuantity, long idTrader, decimal comission, string nameUser)
        {
            int isComplete = bid.ShareBidQty - bid.ExecutedShareBidQty - shareQuantity == 0 ? 1 : 0;
            string sign, reverseSign;
            long seller, buyer;
            decimal BidTraderCommision;
            decimal TraderCommision;
            bid.ShareType = bid.ShareType.Trim();
            if (bid.TradeType == "sale")
            {
                sign = "+";
                reverseSign = "-";
                seller = bid.IdTrader;
                BidTraderCommision = Math.Round(shareQuantity * bid.Price * comission, 2);
                buyer = idTrader;
                TraderCommision = 0;
            }
            else
            {
                sign = "-";
                reverseSign = "+";
                seller = idTrader;
                TraderCommision = Math.Round(shareQuantity * bid.Price * comission, 2);
                buyer = bid.IdTrader;
                BidTraderCommision = 0;
            }

            using (CxDbConnection conn = DataProvider.GetConnection())
            {
                try
                {
                    conn.BeginTransaction();
                    string sqlBid = $@"UPDATE Bid
                                          SET complete = @isComplete,
                                              executedShareBidQty = executedShareBidQty + @ShareQuantity,
                                              GuidUser = NULL
                                        WHERE idBid = @IdBid ";

                    string sqlTrader1 = $@"UPDATE Holder
                                              SET {bid.ShareType}ShareQty = {bid.ShareType}ShareQty {sign} @ShareQuantity,
                                                  balance = balance {reverseSign} ROUND(@Amount,2)
                                            WHERE idHolder = @IdTrader";

                    string sqlTrader2 = $@"UPDATE Holder
                                              SET {bid.ShareType}ShareQty = {bid.ShareType}ShareQty {reverseSign} @ShareQuantity,
                                                  balance = balance {sign} ROUND(@Amount,2)
                                            WHERE idHolder = @IdTrader";

                    string sqlTrade =  $@"INSERT INTO Trade (dateTrade,
                                                             idSeller,
                                                             idPurchaser,
                                                             ShareQty,
                                                             ShareType,
                                                             price,
                                                             nameUser,
                                                             comission)
                                                     VALUES (@Today,
                                                             @Seller,
                                                             @Buyer,
                                                             @ShareQuantity,
                                                             @ShareType,
                                                             @Price,
                                                             @NameUser,
                                                             ROUND(@Comission,2))";
                    SqlCommand cmdBid = new SqlCommand(sqlBid, (SqlConnection)conn.Connection);
                    cmdBid.Transaction = (SqlTransaction)conn.Transaction;
                    cmdBid.Parameters.Add(new SqlParameter("@isComplete", isComplete));
                    cmdBid.Parameters.Add(new SqlParameter("@ShareQuantity", shareQuantity));
                    cmdBid.Parameters.Add(new SqlParameter("@IdBid", bid.IdBid));
                    cmdBid.ExecuteNonQuery();

                    SqlCommand cmdTrader1 = new SqlCommand(sqlTrader1, (SqlConnection)conn.Connection);
                    cmdTrader1.Transaction = (SqlTransaction)conn.Transaction;
                    cmdTrader1.Parameters.Add(new SqlParameter("@ShareQuantity", shareQuantity));
                    cmdTrader1.Parameters.Add(new SqlParameter("@Amount", shareQuantity * bid.Price - TraderCommision));
                    cmdTrader1.Parameters.Add(new SqlParameter("@IdTrader", idTrader));
                    cmdTrader1.ExecuteNonQuery();

                    SqlCommand cmdTrader2 = new SqlCommand(sqlTrader2, (SqlConnection)conn.Connection);
                    cmdTrader2.Transaction = (SqlTransaction)conn.Transaction;
                    cmdTrader2.Parameters.Add(new SqlParameter("@ShareQuantity", shareQuantity));
                    cmdTrader2.Parameters.Add(new SqlParameter("@Amount", shareQuantity * bid.Price - TraderCommision));
                    cmdTrader2.Parameters.Add(new SqlParameter("@IdTrader", bid.IdTrader));
                    cmdTrader2.ExecuteNonQuery();

                    SqlCommand cmdTrade = new SqlCommand(sqlTrade, (SqlConnection)conn.Connection);
                    cmdTrade.Transaction = (SqlTransaction)conn.Transaction;
                    cmdTrade.Parameters.Add(new SqlParameter("@Today", DateTime.Today.ToString("yyyy-MM-dd")));
                    cmdTrade.Parameters.Add(new SqlParameter("@Seller", seller));
                    cmdTrade.Parameters.Add(new SqlParameter("@Buyer", buyer));
                    cmdTrade.Parameters.Add(new SqlParameter("@ShareQuantity", shareQuantity));
                    cmdTrade.Parameters.Add(new SqlParameter("@ShareType", bid.ShareType));
                    cmdTrade.Parameters.Add(new SqlParameter("@Price", bid.Price));
                    cmdTrade.Parameters.Add(new SqlParameter("@NameUser", nameUser));
                    cmdTrade.Parameters.Add(new SqlParameter("@Comission", TraderCommision + BidTraderCommision));
                    cmdTrade.ExecuteNonQuery();

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

        public static Decimal DecimalFormat(decimal value)
        {
            string tvalue = value.ToString("F");
            return Math.Round(Decimal.Parse(tvalue), 2);
        }
    }
}
