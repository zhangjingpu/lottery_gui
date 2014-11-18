using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace ParkLottery
{
    class DataAccess
    {
        public static string CONNECT_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+AppDomain.CurrentDomain.BaseDirectory+"\\Park.mdb";
        OleDbDataAdapter  dataAdapter = new  OleDbDataAdapter ();
      
        public DataSet GetDataSet(string sql)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection (CONNECT_STRING);
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "TABLE");
                conn.Close();
                return ds;
            }
            catch(Exception err)
            {
                return null;

            }
        }
	//Download by http://www.codefans.net
        public bool SQLExecute(string sql)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(CONNECT_STRING);
                conn.Open();
                OleDbCommand comm = new  OleDbCommand ();
                comm.Connection = conn;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                comm.Connection.Close();
                conn.Close();
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
