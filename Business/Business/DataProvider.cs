using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Framework.Db;
using Business;
using Framework.Utils;
using System.Configuration;
using System.Collections.Generic;

namespace Data
{
    public static class DataProvider
    {
        public static string connectionString;

        public static CxDbConnection GetConnection()
        {
            return CxDbConnection.Create(NxDataProviderType.SqlClient, connectionString);
        }

        public static DataTable GetSettingsTable()
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT * 
                                             FROM Settings");
                return dt;
            }
        }

        public static DataTable GetDesingTable(string nameTable)
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT column_name, data_type, character_maximum_length    
                                             FROM INFORMATION_SCHEMA.COLUMNS
                                            WHERE table_name = '{nameTable}'");
                return dt;
            }
        }

        public static DataTable GetShareQty()
        {
            DataTable dt = new DataTable();
            using (CxDbConnection conn = GetConnection())
            {
                conn.GetQueryResult(dt, $@"SELECT SUM(CommonShareQty) as CommonShareTotal,
                                                  SUM(PreferShareQty) as PreferShareTotal
                                             FROM Holder");
                return dt;
            }
        }
       

        public static void ChangeSettingsCompany(decimal comission)
        {
            using (CxDbConnection conn = GetConnection())
            {
                string sql = $@"UPDATE Settings 
                                   SET PropertyValue = {comission.ToString()}
                                 WHERE PropertyName = 'TradeComission'";
                conn.ExecuteCommand(sql);
            }
        }
    }
} 
