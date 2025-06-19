using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDonBanHang
{
    internal class Common
    {
        DataProcessor dtBase = new DataProcessor();
        public bool CheckID(string tableName, string primaryKey, string ID)
        {
            DataTable dt = dtBase.ReadData("Select * from " + tableName + " where " + primaryKey + 
                " = '" + ID + "'");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Trùng mã, bạn phải nhập mã khác");
                return true;
            }
            return false;
        }
        //Sinh mã tự động
        public string AutoSinhKey(string tableName, string startCode, string ID)
        {
            Random random = new Random();
            string id = "";
            bool check = false;
            do
            {
                id = startCode + random.Next(0, 100000).ToString();
                DataTable dtHD = dtBase.ReadData("Select * from " + tableName + " where " 
                    + ID + "='" + id + "'");
                if( dtHD.Rows.Count == 0)
                {
                    check = true;
                }
            }
            while( check == false );
            return id;
        }
    }
}
