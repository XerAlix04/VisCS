using QLPhongKham.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPhongKham.Forms
{
    public partial class FormDangNhap : Form
    {
        DataProcessor dtBase = new DataProcessor();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đủ tên đăng nhập và mật khẩu");
                return;
            }
            DataTable dt1 = dtBase.ReadData("Select * from tblBacSi where sMaBS='" +
                txtDangNhap.Text + "' and sMatKhau='" + txtMatKhau.Text + "'");
            DataTable dt2 = dtBase.ReadData("Select * from tblBenhNhan where sMaBN='" +
                txtDangNhap.Text + "' and sMatKhau='" + txtMatKhau.Text + "'");
            if (dt1.Rows.Count == 0 && dt2.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
            else if (dt2.Rows.Count == 0)
            {
                Program.tenDN = dt1.Rows[0]["sMaBS"].ToString();
                Program.loaiDN = 1;
                FormMain formMain = new FormMain();
                
                formMain.Show();
            }
            else
            {
                Program.tenDN = dt2.Rows[0]["sMaBN"].ToString();
                FormMain formMain = new FormMain();
                
                formMain.Show();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
        }
    }
}
