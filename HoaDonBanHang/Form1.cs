using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDonBanHang
{
    public partial class Form1 : Form
    {

        DataProcessor dtBase = new DataProcessor();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ tên đăng nhập và mật khẩu");
                return;
            }
            DataTable dt = dtBase.ReadData("Select * from tblNhanVien where MaNhanVien='" +
                textBox1.Text + "' and MatKhau='" + textBox2.Text + "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng");
            }
            else
            {
                Program.maNV = dt.Rows[0]["MaNhanVien"].ToString();
                Form2 form2 = new Form2();
                this.Close();
                form2.Show();
            }
        }
    }
}
