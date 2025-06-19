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

namespace QLPhongKham.Forms
{
    public partial class FormBenhNhan : Form
    {
        DataProcessor dtBase = new DataProcessor();
        Common cmm = new Common();
        int chucnang = 0;
        public FormBenhNhan()
        {
            InitializeComponent();
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dtBN = dtBase.ReadData("Select * from tblBenhNhan where iSodienthoai=" +
                    txtSDT.Text + "'");
                if (dtBN.Rows.Count > 0)
                {
                    txtMaP.Text = dtBN.Rows[0]["sMaBN"].ToString();
                    txtTenP.Text = dtBN.Rows[0]["sTenBN"].ToString();
                    txtDiaChi.Text = dtBN.Rows[0]["sDiaChi"].ToString();
                    cboGT.Text = dtBN.Rows[0]["sGioiTinh"].ToString();
                    dateTimePicker1.Text = dtBN.Rows[0]["dNgaySinh"].ToString();
                    txtTinhTrang.Text = dtBN.Rows[0]["sTinhtrangsuckhoe"].ToString();
                }
                else
                {
                    txtMaP.Text = "";
                    txtTenP.Text = "";
                    txtDiaChi.Text = "";
                    cboGT.Text = "";
                    dateTimePicker1.Text = "";
                    txtTinhTrang.Text = "";
                }
            }
        }

        private void txtMaP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dtBN = dtBase.ReadData("Select * from tblBenhNhan where sMaBN=" +
                    txtMaP.Text + "'");
                if (dtBN.Rows.Count > 0)
                {
                    txtSDT.Text = dtBN.Rows[0]["iSodienthoai"].ToString();
                    txtTenP.Text = dtBN.Rows[0]["sTenBN"].ToString();
                    txtDiaChi.Text = dtBN.Rows[0]["sDiaChi"].ToString();
                    cboGT.Text = dtBN.Rows[0]["sGioiTinh"].ToString();
                    dateTimePicker1.Text = dtBN.Rows[0]["dNgaySinh"].ToString();
                    txtTinhTrang.Text = dtBN.Rows[0]["sTinhtrangsuckhoe"].ToString();
                }
                else
                {
                    txtSDT.Text = "";
                    txtTenP.Text = "";
                    txtDiaChi.Text = "";
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtMaP.Text = cboMaP.Text;
            DataTable dtBNtim = dtBase.ReadData("Select * from tblBenhNhan where sMaBN = '" + cboMaP.Text + "'");
            txtTenP.Text = dtBNtim.Rows[0]["sTenBN"].ToString();
            cboGT.Text = dtBNtim.Rows[0]["sGioiTinh"].ToString();
            dateTimePicker1.Text = dtBNtim.Rows[0]["dNgaySinh"].ToString();
            txtDiaChi.Text = dtBNtim.Rows[0]["sDiaChi"].ToString();
            txtSDT.Text = dtBNtim.Rows[0]["iSodienthoai"].ToString();
            txtTinhTrang.Text = dtBNtim.Rows[0]["sTinhtrangsuckhoe"].ToString();

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormBenhNhan_Load(object sender, EventArgs e)
        {
            refresh();
            loadCTBN();
        }

        private void loadCTBN()
        {
            DataTable dtBN = dtBase.ReadData("Select * from tblBenhNhan");
            dataGridView1.DataSource = dtBN;
            dataGridView1.Columns[0].HeaderText = "Mã bệnh nhân";
            dataGridView1.Columns[1].HeaderText = "Tên bệnh nhân";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[5].HeaderText = "SDT";
            dataGridView1.Columns["sTinhtrangsuckhoe"].Visible = false;
            dataGridView1.Columns["sMatKhau"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaP.Text = cboMaP.Text;
            DataTable dtBNtim = dtBase.ReadData("Select * from tblBenhNhan where sMaBN = '" + cboMaP.Text + "'");
            txtTenP.Text = dtBNtim.Rows[0]["sTenBN"].ToString();
            cboGT.Text = dtBNtim.Rows[0]["sGioiTinh"].ToString();
            dateTimePicker1.Text = dtBNtim.Rows[0]["dNgaySinh"].ToString();
            txtDiaChi.Text = dtBNtim.Rows[0]["sDiaChi"].ToString();
            txtSDT.Text = dtBNtim.Rows[0]["iSodienthoai"].ToString();
            txtTinhTrang.Text = dtBNtim.Rows[0]["sTinhtrangsuckhoe"].ToString();

            if(Program.loaiDN == 1)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            chucnang = 1;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTim.Enabled = false;

            txtMaP.ReadOnly = false;
            txtTenP.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTinhTrang.ReadOnly = false;
            cboGT.Enabled = true;
            dateTimePicker1.Enabled = true;

            DateTime dt = DateTime.Now;
            txtMaP.Text = cmm.AutoSinhKey("tblBenhNhan", "BN" + dt.Year.ToString(), "sMaBN");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            txtMaP.ReadOnly = true;
            txtTenP.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTinhTrang.ReadOnly = false;
            cboGT.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            chucnang = 3;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            txtMaP.ReadOnly = true;
            txtTenP.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTinhTrang.ReadOnly = true;
            cboGT.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (Program.loaiDN == 1)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
            btnTim.Enabled = true;

            txtMaP.Text = "";
            txtTenP.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTinhTrang.Text = "";
            cboGT.Enabled = true;
            dateTimePicker1.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(chucnang == 1)
            {
                string maBN = txtMaP.Text;
                string tenBN = txtTenP.Text;
                if (string.IsNullOrEmpty(maBN) || string.IsNullOrEmpty(tenBN))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                DataTable dtBN = dtBase.ReadData("Select sMaBN from tblBenhNhan where sMaBN ='" + maBN + "'");
                if(dtBN.Rows.Count > 0)
                {
                    MessageBox.Show("Mã bệnh nhân này đã có trong danh sách");
                    return;
                }
                else
                {
                    string gioitinh = cboGT.Text;
                    string diachi = txtDiaChi.Text;
                    int sdt = int.Parse(txtSDT.Text);
                    string tinhtrang = txtTinhTrang.Text;
                    DateTime dt = dateTimePicker1.Value;
                    dtBase.ChangeData("Insert into tblBenhNhan (sMaBN, sTenBN, sGioiTinh, dNgaySinh, " +
                        "sDiaChi, iSodienthoai, sTinhtrangsuckhoe) values (N'" + maBN + "', N'" + tenBN + "', N'" + gioitinh + "', " + dt + ", N'" + diachi + "', " + sdt + ", N'" + tinhtrang + "')");
                    MessageBox.Show("Thêm Thành Công");
                    refresh();
                }

            }
            else if(chucnang == 2)
            {
                string maBN = txtMaP.Text;
                string tenBN = txtTenP.Text;
                if (string.IsNullOrEmpty(maBN) || string.IsNullOrEmpty(tenBN))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                string gioitinh = cboGT.Text;
                string diachi = txtDiaChi.Text;
                int sdt = int.Parse(txtSDT.Text);
                string tinhtrang = txtTinhTrang.Text;
                DateTime dt = dateTimePicker1.Value;
                dtBase.ChangeData("Update tblBenhNhan" +
                    "SET [sTenBN] = N'" + tenBN + "', " +
                    "[sGioiTinh] = N'" + gioitinh + "', " +
                    "[dNgaySinh] = " + dt + ", " +
                    "[sDiaChi] = N'" + diachi + "' " +
                    "[iSodienthoai] = " + sdt + ", " +
                    "[sTinhtrangsuckhoe] = N'" + tinhtrang + "' " +
                    "WHERE [sMaBN] = '" + maBN + "'");
                MessageBox.Show("Sửa thành công");
                refresh();
            }
            else if(chucnang == 3)
            {
                if (!string.IsNullOrWhiteSpace(txtMaP.Text))
                {
                    txtMaP.ReadOnly = true;
                    string maBN = txtMaP.Text;
                    DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        dtBase.ChangeData("Delete from tblBenhNhan where sMaBN=N'" + maBN + "'");
                        MessageBox.Show("Xóa thành công sản phẩm ");
                        refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa ");
                }
            }
        }

        private void refresh()
        {
            DataTable dtMaBN = dtBase.ReadData("Select sMaBN from tblBenhNhan");
            cboMaP.DataSource = dtMaBN;
            cboMaP.DisplayMember = "sMaBN";

            txtMaP.Text = "";
            txtTenP.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTinhTrang.Text = "";

            txtMaP.ReadOnly = true;
            txtTenP.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTinhTrang.ReadOnly = true;

            if(Program.loaiDN == 1)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        private void FormBenhNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.reload = true;
        }
    }
}
