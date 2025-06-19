using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi.Classes
{
    internal class DataProcessor
    {
        private static string connStr = "Data Source=DESKTOP-P9RRDLP\\SQLEXPRESS;Initial Catalog=BaiThi;" +
        "Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connStr);

        private void OpenConnect()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
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
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sql;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            CloseConnect();
            cmd.Dispose();
        }

        public DataProcessor()
        {
            connStr = "Data Source=DESKTOP-P9RRDLP\\SQLEXPRESS;Initial Catalog=BaiThi;" +
                "Integrated Security=True";
            sqlConnection = new SqlConnection(connStr);
        }
    }
}
