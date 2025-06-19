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
    public partial class FormHoaDon : Form
    {
        DataProcessor dtBase = new DataProcessor();
        Common cmm = new Common();
        int chucnang = 5;
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = "0";
            DataTable dtBN = dtBase.ReadData("Select sMaBN from tblBenhNhan");
            cboMaP.DataSource = dtBN;
            cboMaP.DisplayMember = "sMaBN";
            if(Program.loaiDN == 1)
            {
                DataTable dtHD = dtBase.ReadData("Select sMaHD from tblHoaDon inner join tblDonThuoc on tblHoaDon.sMaDT = tblDonThuoc.sMaDT where sMaBS ='" + Program.tenDN + "'");
                cboMaDon.DataSource = dtHD;
                cboMaDon.DisplayMember = "sMaHD";
                DataTable dtBS = dtBase.ReadData("Select sMaBS, sTenBS from tblBacSi where sMaBS='" +
                    Program.tenDN + "'");
                txtMaBS.Text = Program.tenDN;
                txtTenBS.Text = dtBS.Rows[0]["sTenBS"].ToString();
                txtMaBS.ReadOnly = true;
                txtTenBS.ReadOnly = true;

                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                DataTable dtHD = dtBase.ReadData("Select sMaHD from tblHoaDon");
                cboMaDon.DataSource = dtHD;
                cboMaDon.DisplayMember = "sMaHD";
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            chucnang = 0;
            txtMaDon.Text = cboMaDon.Text;
            DataTable dtHDtim = dtBase.ReadData("Select * from tblHoaDon where sMaHD='" + cboMaDon.Text + "'");
            dtpNgayLap.Text = dtHDtim.Rows[0]["dNgayLap"].ToString();
            txtTongTien.Text = dtHDtim.Rows[0]["fTongTien"].ToString();
            //TT BS
            string maDT = dtHDtim.Rows[0]["sMaDT"].ToString();
            DataTable dtBStim = dtBase.ReadData("Select tblBacSi.sMaBS, sTenBS from tblBacSi inner join tblDonThuoc" +
                " on tblBacSi.sMaBS = tblDonThuoc.sMaBS" +
                " where sMaDT='" + maDT + "'");
            txtMaBS.Text = dtBStim.Rows[0]["sMaBS"].ToString();
            txtTenBS.Text = dtBStim.Rows[0]["sTenBS"].ToString();
            //TT BN
            cboMaP.Text = dtHDtim.Rows[0]["sMaBN"].ToString();
            DataTable dtBNtim = dtBase.ReadData("Select * from tblBenhNhan where sMaBN='" +
                cboMaP.Text + "'");
            txtTenP.Text = dtBNtim.Rows[0]["sTenBN"].ToString();
            txtSDT.Text = dtBNtim.Rows[0]["iSodienthoai"].ToString();
            txtDiaChi.Text = dtBNtim.Rows[0]["sDiaChi"].ToString();
            //Danh sách HD
            loadChiTietHD(cboMaDon.Text);
            if (Program.loaiDN == 1)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        private void loadChiTietHD(string MaHD)
        {
            DataTable dtMa = dtBase.ReadData("Select sMaDT, sMaDV from tblHoaDon inner join tblHoaDon_DV" +
                " on tblHoaDon.sMaHD = tblHoaDon_DV.sMaHD where tblHoaDon.sMaHD ='" + MaHD + "'");
            DataTable dtDT = dtBase.ReadData("Select tblCT_DonThuoc.sMaThuoc, sTenThuoc, iSoLuong, " +
                "fGiaThuoc, sMaDT from tblCT_DonThuoc inner join tblThuoc on tblCT_DonThuoc.sMaThuoc = " +
                "tblThuoc.sMaThuoc where sMaDT='" + dtMa.Rows[0]["sMaDT"].ToString() + "'");
            DataTable dtDV = dtBase.ReadData("Select tblHoaDon_DV.sMaDV, sTenDV, fSoLuong, " +
                "fDonGia from tblHoaDon_DV inner join tblDichVuKham on tblHoaDon_DV.sMaDV = " +
                "tblDichVuKham.sMaDV where tblHoaDon_DV.sMaDV='" + dtMa.Rows[0]["sMaDV"].ToString() + "'");
            dataGridView1.DataSource = dtDT;
            dataGridView2.DataSource = dtDV;
            dataGridView1.Columns[0].HeaderText = "Mã thuốc";
            dataGridView1.Columns[1].HeaderText = "Tên thuốc";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Giá thuốc";
            dataGridView1.Columns["sMaDT"].Visible = false;

            dataGridView2.Columns[0].HeaderText = "Mã dịch vụ";
            dataGridView2.Columns[1].HeaderText = "Tên dịch vụ";
            dataGridView2.Columns[2].HeaderText = "Số lượng";
            dataGridView2.Columns[3].HeaderText = "Giá dịch vụ";
        }

        private void loadAllThuocDV()
        {
            DataTable dtDT = dtBase.ReadData("Select sMaThuoc, sTenThuoc, fGiaThuoc from tblThuoc");
            DataTable dtDV = dtBase.ReadData("Select sMaDV, sTenDV, fDonGia from tblDichVuKham");
            dataGridView1.DataSource = dtDT;
            dataGridView2.DataSource = dtDV;
            dataGridView1.Columns[0].HeaderText = "Mã thuốc";
            dataGridView1.Columns[1].HeaderText = "Tên thuốc";
            dataGridView1.Columns[2].HeaderText = "Giá thuốc";

            dataGridView2.Columns[0].HeaderText = "Mã dịch vụ";
            dataGridView2.Columns[1].HeaderText = "Tên dịch vụ";
            dataGridView2.Columns[2].HeaderText = "Giá dịch vụ";
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dtBN = dtBase.ReadData("Select * from tblBenhNhan where iSodienthoai=" + 
                    txtSDT.Text + "'");
                if (dtBN.Rows.Count > 0 )
                {
                    cboMaP.Text = dtBN.Rows[0]["sMaBN"].ToString();
                    txtTenP.Text = dtBN.Rows[0]["sTenBN"].ToString();
                    txtDiaChi.Text = dtBN.Rows[0]["sDiaChi"].ToString();
                }
                else
                {
                    cboMaP.Text = "";
                    txtTenP.Text = "";
                    txtDiaChi.Text = "";
                }
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

            txtMaThuoc.ReadOnly = true;
            txtTenThuoc.ReadOnly = true;
            txtSlgThuoc.ReadOnly = false;
            txtDonGiaThuoc.ReadOnly = true;
            txtMaDV.ReadOnly = true;
            txtTenDV.ReadOnly = true;
            txtSlgDV.ReadOnly = false;
            txtDonGiaDV.ReadOnly = true;

            DateTime dt = DateTime.Now;
            txtMaDon.Text = cmm.AutoSinhKey("tblHoaDon", "HD" + dt.Year.ToString(), "sMaHD");

            loadAllThuocDV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chucnang != 1)
            {
                txtMaThuoc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenThuoc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSlgThuoc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                float slg = float.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                float dg = float.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                txtDonGiaThuoc.Text = (slg * dg).ToString();

                txtMaThuoc.ReadOnly = true;
                txtDonGiaThuoc.ReadOnly = true;
                if (chucnang == 3)
                {
                    txtTenThuoc.ReadOnly = true;
                    txtSlgThuoc.ReadOnly = true;
                }
                if (chucnang == 2)
                {
                    txtTenThuoc.ReadOnly = false;
                    txtSlgThuoc.ReadOnly = false;
                }

                if (Program.loaiDN == 1)
                {
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
            else
            {
                txtMaThuoc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenThuoc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                txtMaThuoc.ReadOnly = true;
                txtTenThuoc.ReadOnly = true;
                txtDonGiaThuoc.ReadOnly = true;

                if (Program.loaiDN == 1)
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnLuu.Enabled = true;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(chucnang != 1)
            {
                txtMaDV.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtTenDV.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtSlgDV.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                float slg = float.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                float dg = float.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                txtDonGiaDV.Text = (slg * dg).ToString();

                txtMaDV.ReadOnly = true;
                txtDonGiaDV.ReadOnly = true;

                if(chucnang == 3)
                {
                    txtTenDV.ReadOnly = true;
                    txtSlgDV.ReadOnly = true;
                }
                if(chucnang == 2)
                {
                    txtTenDV.ReadOnly = false;
                    txtSlgDV.ReadOnly = false;
                }

                if (Program.loaiDN == 1)
                {
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
            else
            {
                txtMaDV.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtTenDV.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

                txtMaDV.ReadOnly = true;
                txtTenDV.ReadOnly = true;
                txtDonGiaDV.ReadOnly = true;

                if (Program.loaiDN == 1)
                {
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnLuu.Enabled = true;
                }
            }
        }

        private void txtSlgThuoc_TextChanged(object sender, EventArgs e)
        {
            float slg, dg;
            if (txtSlgThuoc.Text.Trim() == "") slg = 0;
            else slg = float.Parse(txtSlgThuoc.Text);
            dg = float.Parse(dataGridView1.CurrentRow.Cells["fGiaThuoc"].Value.ToString());
            txtDonGiaThuoc.Text = (slg * dg).ToString();
        }

        private void txtSlgDV_TextChanged(object sender, EventArgs e)
        {
            float slg, dg;
            if (txtSlgDV.Text.Trim() == "") slg = 0;
            else slg = float.Parse(txtSlgDV.Text);
            dg = float.Parse(dataGridView2.CurrentRow.Cells["fDonGia"].Value.ToString());
            txtDonGiaDV.Text = (slg * dg).ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chucnang = 4;
            if(Program.loaiDN == 1)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
            btnTim.Enabled = true;

            txtMaDon.Text = "";
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtSlgThuoc.Text = "";
            txtDonGiaThuoc.Text = "";
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtSlgDV.Text = "";
            txtDonGiaDV.Text = "";
            txtTongTien.Text = "0";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = 2;
            txtMaThuoc.ReadOnly = true;
            txtTenThuoc.ReadOnly = false;
            txtSlgThuoc.ReadOnly = false;
            txtDonGiaThuoc.ReadOnly = true;
            txtMaDV.ReadOnly = true;
            txtTenDV.ReadOnly = false;
            txtSlgDV.ReadOnly = false;
            txtDonGiaDV.ReadOnly = true;

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            chucnang = 3;

            txtMaThuoc.ReadOnly = true;
            txtTenThuoc.ReadOnly = true;
            txtSlgThuoc.ReadOnly = true;
            txtDonGiaThuoc.ReadOnly = true;
            txtMaDV.ReadOnly = true;
            txtTenDV.ReadOnly = true;
            txtSlgDV.ReadOnly = true;
            txtDonGiaDV.ReadOnly = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(chucnang == 0 || chucnang == 2 || chucnang == 3)
            {
                float tt, tongtien;
                float slg = float.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                float dg = float.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                tt = slg * dg;
                tongtien = float.Parse(txtTongTien.Text) - tt;
                dtBase.ChangeData("Update tblHoaDon set fTongTien='" + tongtien.ToString() +
                    "' where sMaHD='" + cboMaDon.Text + "'");
                txtTongTien.Text = tongtien.ToString();

                dtBase.ChangeData("Update tblHoaDon set sMaDT=null" +
                    " where sMaHD='" + cboMaDon.Text + "'");
                dtBase.ChangeData("Delete tblCT_DonThuoc where sMaDT='" +
                    dataGridView1.CurrentRow.Cells["sMaDT"].Value + "'");
                dtBase.ChangeData("Delete tblDonThuoc where sMaDT='" +
                    dataGridView1.CurrentRow.Cells["sMaDT"].Value + "'");
                loadChiTietHD(cboMaDon.Text);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chucnang == 0 || chucnang == 2 || chucnang == 3)
            {
                float tt, tongtien;
                float slg = float.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                float dg = float.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                tt = slg * dg;
                tongtien = float.Parse(txtTongTien.Text) - tt;
                dtBase.ChangeData("Update tblHoaDon set fTongTien='" + tongtien.ToString() +
                    "' where sMaHD='" + cboMaDon.Text + "'");
                txtTongTien.Text = tongtien.ToString();

                dtBase.ChangeData("Delete tblHoaDon_DV where sMaHD='" +
                    cboMaDon.Text + "'");
                loadChiTietHD(cboMaDon.Text);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maBS = txtMaBS.Text;
            string maHD = txtMaDon.Text;
            string maBN = cboMaP.Text;
            string tenBN = txtTenP.Text;
            string diachi = txtDiaChi.Text;
            int sdt = int.Parse(txtSDT.Text);
            string mathuoc = txtMaThuoc.Text;
            string tenthuoc = txtTenThuoc.Text;
            int slgthuoc = int.Parse(txtSlgThuoc.Text);
            float dgthuoc = float.Parse(txtDonGiaThuoc.Text);
            string madv = txtMaDV.Text;
            string tendv = txtTenDV.Text;
            float slgdv = float.Parse(txtSlgDV.Text);
            float dgdv = float.Parse(txtDonGiaDV.Text);
            bool checkDV = false;
            //string maDTthem = dataGridView1.CurrentRow.Cells["sMaDT"].Value.ToString();
            DateTime dt = DateTime.Now;
            string maDTThem = cmm.AutoSinhKey("tblDonThuoc", "DT" + dt.Year.ToString(), "sMaDT");
            float tongtien = (slgthuoc * dgthuoc) + (slgdv * dgdv);

            if (chucnang == 1)
            {
                if(maBN.Trim() == "" || tenBN.Trim() == "" || diachi.Trim() == "" 
                    || sdt.ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh nhân");
                    return;
                }
                else if (mathuoc.Trim() == "" || tenthuoc.Trim() == "" || slgthuoc.ToString() == ""
                    || dgthuoc.ToString() == "")
                {
                    MessageBox.Show("Vui lòng chọn đơn thuốc");
                    return;
                }
                //else if (madv.Trim() == "" || tendv.Trim() == "" || slgdv.ToString() == ""
                //    || dgdv.ToString() == "")
                //{
                //    MessageBox.Show("Vui lòng chọn dịch vụ");
                //    return;
                //}
                else
                {
                    if (madv.Trim() != "" && tendv.Trim() != "" && slgdv.ToString() != ""
                        && dgdv.ToString() != "")
                    {
                        checkDV = true;
                    }

                    dtBase.ChangeData("Insert into tblDonThuoc (sMaDT, sMaBS, sMaBN, dNgayLap) " +
                        "values (N'" + maDTThem + "', N'" + maBS + "', N'" + maBN + "', '" + string.Format("{0:MM/dd/yyyy}", dt) + "')");
                    dtBase.ChangeData("Insert into tblCT_DonThuoc (sMaDT, sMaThuoc, iSoLuong) " +
                        "values (N'" + maDTThem + "', N'" + mathuoc + "', " + slgthuoc + ")");
                    dtBase.ChangeData("Insert into tblHoaDon (sMaHD, sMaDT, sMaBN, dNgayLap, fTongTien) " +
                        "values (N'" + maHD + "', N'" + maDTThem + "', N'" + maBN + "', '" + string.Format("{0:MM/dd/yyyy}", dt) + "', " + tongtien + ")");
                    if(checkDV == true)
                    {
                        dtBase.ChangeData("Insert into tblHoaDon_DV (sMaHD, sMaDV, fSoLuong) " +
                        "values (N'" + maHD + "', N'" + madv + "', " + slgdv + ")");
                    }
                    MessageBox.Show("Thêm Thành Công");
                    txtMaDon.Text = "";
                    return;
                }
            }
            else if (chucnang == 2)
            {
                string maDTsua = dataGridView1.CurrentRow.Cells["sMaDT"].Value.ToString();
                if (mathuoc.Trim() == "" || tenthuoc.Trim() == "" || slgthuoc.ToString() == ""
                    || dgthuoc.ToString() == "")
                {
                    if (madv.Trim() == "" || tendv.Trim() == "" || slgdv.ToString() == ""
                        || dgdv.ToString() == "")
                    {
                        return;
                    }
                    dtBase.ChangeData("Update tblDichVuKham" +
                        "SET [sTenDV] = N'" + tendv + "' " +
                        "WHERE [sMaDV] = '" + madv + "'");
                    dtBase.ChangeData("Update tblHoaDon_DV" +
                        "SET [fSoLuong] = " + slgdv + " " +
                        "WHERE [sMaDV] = '" + madv + "' AND [sMaHD] = '" + maHD + "'");
                }
                else if (madv.Trim() == "" || tendv.Trim() == "" || slgdv.ToString() == ""
                    || dgdv.ToString() == "")
                {
                    dtBase.ChangeData("Update tblThuoc" +
                        "SET [sTenThuoc] = N'" + tenthuoc + "' " +
                        "WHERE [sMaThuoc] = '" + mathuoc + "'");
                    dtBase.ChangeData("Update tblCT_DonThuoc" +
                        "SET [iSoLuong] = " + slgthuoc + " " +
                        "WHERE [sMaThuoc] = '" + mathuoc + "' AND [sMaDT] = '" + maDTsua + "'");
                }
                else
                {
                    dtBase.ChangeData("Update tblDichVuKham" +
                        "SET [sTenDV] = N'" + tendv + "' " +
                        "WHERE [sMaDV] = '" + madv + "'");
                    dtBase.ChangeData("Update tblHoaDon_DV" +
                        "SET [fSoLuong] = " + slgdv + " " +
                        "WHERE [sMaDV] = '" + madv + "' AND [sMaHD] = '" + maHD + "'");
                    dtBase.ChangeData("Update tblThuoc" +
                        "SET [sTenThuoc] = N'" + tenthuoc + "' " +
                        "WHERE [sMaThuoc] = '" + mathuoc + "'");
                    dtBase.ChangeData("Update tblCT_DonThuoc" +
                        "SET [iSoLuong] = " + slgthuoc + " " +
                        "WHERE [sMaThuoc] = '" + mathuoc + "' AND [sMaDT] = '" + maDTsua + "'");
                }
                dtBase.ChangeData("Update tblHoaDon" +
                    "SET [fTongTien] = " + tongtien + " " +
                    "WHERE [sMaHD] = '" + maHD + "'");
                MessageBox.Show("Sửa thành công");
                loadChiTietHD(cboMaDon.Text);
            }
            else if (chucnang == 3)
            {
                if (!string.IsNullOrWhiteSpace(maHD))
                {
                    DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        dtBase.ChangeData("Delete from tblHoaDon_DV where sMaHD=N'" + maHD + "'");
                        dtBase.ChangeData("Delete from tblHoaDon where sMaHD=N'" + maHD + "'");
                        MessageBox.Show("Xóa thành công hóa đơn");
                        DataTable dtHD = dtBase.ReadData("Select sMaHD from tblHoaDon where dNgayLap >= DATEADD(day, -7, GETDATE())");
                        cboMaDon.DataSource = dtHD;
                        cboMaDon.DisplayMember = "sMaHD";
                        cboMaDon.SelectedIndex = 0;
                        loadChiTietHD(cboMaDon.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần xóa ");
                }
            }
        }

        private void cboMaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtBN = dtBase.ReadData("Select * from tblBenhNhan where sMaBN='" +
                    cboMaP.Text + "'");

            if (dtBN.Rows.Count > 0)
            {
                txtSDT.Text = dtBN.Rows[0]["iSodienthoai"].ToString();
                txtTenP.Text = dtBN.Rows[0]["sTenBN"].ToString();
                txtDiaChi.Text = dtBN.Rows[0]["sDiaChi"].ToString();
            }
        }

        private void FormHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.reload = true;
        }

        private void txtDonGiaThuoc_TextChanged(object sender, EventArgs e)
        {
            if(txtDonGiaThuoc.Text != "")
            {
                float dgt = float.Parse(txtDonGiaThuoc.Text);
                float tongtien = float.Parse(txtTongTien.Text) + dgt;
                txtTongTien.Text = tongtien.ToString();
            }
        }

        private void txtDonGiaDV_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaDV.Text != "") 
            {
                float dgdv = float.Parse(txtDonGiaDV.Text);
                float tongtien = float.Parse(txtTongTien.Text) + dgdv;
                txtTongTien.Text = tongtien.ToString();
            }
        }
    }
}
