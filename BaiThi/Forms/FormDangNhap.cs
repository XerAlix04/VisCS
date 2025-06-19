using BaiThi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThi.Forms
{
    public partial class FormDangNhap : Form
    {
        DataProcessor dtBase = new DataProcessor();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ tên đăng nhập và mật khẩu");
                return;
            }
            DataTable dt1 = dtBase.ReadData("Select * from Users where TenDN='" +
                txtTenDN.Text + "' and MatKhau='" + txtMatKhau.Text + "'");
            if (dt1.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }

            else
            {
                FormMain formMain = new FormMain();
                formMain.Show();
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            txtTenDN.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
        }
    }
}
