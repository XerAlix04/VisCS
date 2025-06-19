using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaDonBanHang
{
    
    internal class DataProcessor
    {
        private static string connStr = "Data Source=DESKTOP-P9RRDLP\\SQLEXPRESS;Initial Catalog=QLBanHangLTTQ;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=True;" +
                "Trust Server Certificate=True;Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False";
        SqlConnection sqlConnection = new SqlConnection(connStr);

        private void OpenConnect()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        private void CloseConnect()
        {
            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, sqlConnection);
            dataAdapter.Fill(dt);
            CloseConnect();
            dataAdapter.Dispose();
            return dt;
        }

        public void ChangeData(string sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            CloseConnect();
            cmd.Dispose();
        }

        public DataProcessor()
        {

        }
    }
}
