using BaiKiemTra_16_11.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTra_16_11
{
    public partial class Form1 : Form
    {
        DataProcessor dtBase = new DataProcessor();
        public Form1()
        {
            InitializeComponent();
            txtTinChi.KeyPress += txtTinChi_KeyPress;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.GotFocus += TextBox_GotFocus;
                    textBox.LostFocus += TextBox_LostFocus;
                }
            }
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txtTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaMon_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string mamon = txtMaMon.Text;
            string tenmon = txtTenMon.Text;
            int tc = int.Parse(txtTinChi.Text);

            if (mamon.Length == 0)
            {
                if(tenmon.Length == 0)
                {
                    if(txtTinChi.Text.Length == 0)
                    {
                        DataTable dt = dtBase.ReadData("Select * from tblMonHoc");
                    }
                    else
                    {
                        DataTable dt = dtBase.ReadData("Select * from tblMonHoc where SoTC="+ tc + "");
                    }
                }
            }

            DataTable dtb = dtBase.ReadData("Select * from tblMonHoc where MaMon = '' and TenMon = '' and SoTC =");
        }
    }
}
