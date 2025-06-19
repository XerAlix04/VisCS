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
    public partial class FormMain : Form
    {
        DataProcessor dtBase = new DataProcessor();
        public FormMain()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            DataTable dt = dtBase.ReadData("Select * from DiemSV");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã môn";
            dataGridView1.Columns[1].HeaderText = "Tên môn";
            dataGridView1.Columns[2].HeaderText = "Số tín chỉ";
            dataGridView1.Columns[3].HeaderText = "Điểm thi";
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtSoTin.Text = "";
            txtDiemThi.Text = "";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void txtSoTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dtMaMon = dtBase.ReadData("Select MaMon from DiemSV where MaMon = '" + txtMaMon.Text + "'");
            float Diem = float.Parse(txtDiemThi.Text);
            if(dtMaMon.Rows.Count == 0 && Diem > 0 && Diem <= 10)
            {
                dtBase.ChangeData("Insert into DiemSV (MaMon, TenMon, SoTC, DiemThi) values (N'" + txtMaMon.Text + "', N'" + txtTenMon.Text + "', " + int.Parse(txtSoTin.Text) + ", " + float.Parse(txtDiemThi.Text) + ")");
                refresh();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
