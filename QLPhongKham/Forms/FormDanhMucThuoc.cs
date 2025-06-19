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
    public partial class FormDanhMucThuoc : Form
    {
        DataProcessor dtBase = new DataProcessor();
        OpenFileDialog ofd = new OpenFileDialog();
        int chucnang = 0;
        public FormDanhMucThuoc()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            DataTable dtThuoc = dtBase.ReadData("Select sMaThuoc, sTenThuoc, fGiaThuoc, sAnh, sTenLoaiThuoc " +
                "from tblThuoc inner join tblLoaiThuoc on tblThuoc.sMaLoaiThuoc = tblLoaiThuoc.sMaLoaiThuoc");
            DataTable dtLoai = dtBase.ReadData("Select * from tblLoaiThuoc");
            dataGridView1.DataSource = dtThuoc;
            dataGridView1.Columns["sAnh"].Visible = false;
            cboLoai.Items.Clear();
            if (dtLoai.Rows.Count > 0)
            {
                foreach (DataRow dr in dtLoai.Rows)
                {
                    cboLoai.Items.Add(dr["sTenLoaiThuoc"].ToString());
                }
            }
            txtMa.Text = "";
            txtTen.Text = "";
            cboLoai.SelectedIndex = 1;
            txtGia.Text = "";
            pictureBox1.Image = null;

            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtGia.ReadOnly = true;

            if(Program.loaiDN == 1)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
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

        private void FormDanhMucThuoc_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp|TIFF Files (*.tiff)|*.tiff|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string Anh = ofd.FileName;
                pictureBox1.Image = Image.FromFile(Anh);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Mở tệp thất bại");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtGia.ReadOnly = true;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtMa.Text = selectedRow.Cells["sMaThuoc"].Value.ToString();
                txtTen.Text = selectedRow.Cells["sTenThuoc"].Value.ToString();
                cboLoai.Text = selectedRow.Cells["sTenLoaiThuoc"].Value.ToString();
                txtGia.Text = selectedRow.Cells["fGiaThuoc"].Value.ToString();

                string imagePath = selectedRow.Cells["sAnh"].Value.ToString();
                // Dữ liệu chỉ có tên ảnh, không có đường dẫn đầy đủ
                // Gán đường dẫn đầy đủ cho imagePath với dữ liệu được lưu ở bin\Debug\Image
                // Cat chuoi imagePath de lay ten anh
                //imagePath = imagePath.Substring(imagePath.LastIndexOf('\\') + 1);
                imagePath = Application.StartupPath + @"\Image\" + imagePath;
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        ofd.FileName = imagePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở hình ảnh: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Đường dẫn hình ảnh không hợp lệ.");
                }
            }
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
            txtMa.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtGia.ReadOnly = false;
            pictureBox1.Image = null;
            txtMa.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            ofd.FileName = "";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chucnang = 2;
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = false;
            txtGia.ReadOnly = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            chucnang = 3;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            ofd.FileName = "";
            
            if(Program.loaiDN == 1)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucnang == 1)
            {
                string mathuoc = txtMa.Text;
                string tenthuoc = txtTen.Text;
                if(string.IsNullOrEmpty(mathuoc) || string.IsNullOrEmpty(tenthuoc))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                string loaithuoc = cboLoai.Text;
                float giathuoc = float.Parse(txtGia.Text);

                string anh = ofd.FileName;
                string[] arr = anh.Split('\\');
                anh = arr[arr.Length - 1];

                // Chuyen anh vao thu muc Image
                string sourcePath = ofd.FileName;
                string targetPath = Application.StartupPath + @"\Image\" + anh;
                if (sourcePath != "") 
                {
                    System.IO.File.Copy(sourcePath, targetPath, true);
                }
                else
                {
                    anh = "NULL";
                }
                

                DataTable dtMaLoai = dtBase.ReadData("Select sMaLoaiThuoc from tblLoaiThuoc where " +
                    "sTenLoaiThuoc = N'" + loaithuoc + "'");
                string maloai = dtMaLoai.Rows[0]["sMaLoaiThuoc"].ToString();

                DataTable dataTable = dtBase.ReadData("Select sMaThuoc from tblThuoc where sMaThuoc = N'" +
                    mathuoc + "'");
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Thuốc này đã tồn tại");
                    return;
                }
                else
                {
                    dtBase.ChangeData("Insert into tblThuoc (sMaThuoc, sTenThuoc, fGiaThuoc, sAnh, sMaLoaiThuoc)" +
                    " values (N'" + mathuoc + "',N'" + tenthuoc + "'," + giathuoc + ",N'" + anh + "',N'" + maloai + "')");
                    MessageBox.Show("Thêm Thành Công");
                    refresh();
                }
            }
            else if (chucnang == 2)
            {
                string mathuoc = txtMa.Text;
                string tenthuoc = txtTen.Text;
                if (string.IsNullOrEmpty(mathuoc) || string.IsNullOrEmpty(tenthuoc))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                string loaithuoc = cboLoai.Text;
                DataTable dtMaLoai = dtBase.ReadData("Select sMaLoaiThuoc from tblLoaiThuoc where " +
                    "sTenLoaiThuoc = N'" + loaithuoc + "'");
                string maloai = dtMaLoai.Rows[0]["sMaLoaiThuoc"].ToString();
                float giathuoc = float.Parse(txtGia.Text);

                string anh = ofd.FileName;
                string[] arr = anh.Split('\\');
                anh = arr[arr.Length - 1];

                dtBase.ChangeData("Update tblThuoc" +
                    "SET [sTenThuoc] = N'" + tenthuoc + "', " +
                    "[sMaLoaiThuoc] = N'" + maloai + "', " +
                    "[fGiaThuoc] = " + giathuoc + ", " +
                    "[sAnh] = N'" + anh + "' " +
                    "WHERE [sMaThuoc] = '" + mathuoc + "'");
                MessageBox.Show("Sửa thành công");
                refresh();
            }
            else if (chucnang == 3)
            {
                if (!string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    txtMa.ReadOnly = true;
                    string mathuoc = txtMa.Text;
                    DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        dtBase.ChangeData("Delete from tblThuoc where sMaThuoc=N'" + mathuoc + "'");
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

        private void FormDanhMucThuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.reload = true;
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtThuoc = dtBase.ReadData("Select sMaThuoc, sTenThuoc, fGiaThuoc, sAnh, sTenLoaiThuoc " +
                "from tblThuoc inner join tblLoaiThuoc on tblThuoc.sMaLoaiThuoc = tblLoaiThuoc.sMaLoaiThuoc " +
                "where tblLoaiThuoc.sTenLoaiThuoc = '" + cboLoai.Text + "'");
            dataGridView1.DataSource = dtThuoc;
        }
    }
}
