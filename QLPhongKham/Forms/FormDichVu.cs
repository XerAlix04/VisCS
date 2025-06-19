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
    public partial class FormDichVu : Form
    {
        DataProcessor dtBase = new DataProcessor();
        OpenFileDialog ofd = new OpenFileDialog();
        int chucnang = 0;
        public FormDichVu()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            DataTable dtDV = dtBase.ReadData("Select sMaDV, sTenDV, fDonGia, sAnh from tblDichVuKham");
            dataGridView1.DataSource = dtDV;
            dataGridView1.Columns["sAnh"].Visible = false;

            txtMa.Text = "";
            txtTen.Text = "";
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
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void FormDichVu_Load(object sender, EventArgs e)
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

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtMa.Text = selectedRow.Cells["sMaDV"].Value.ToString();
                txtTen.Text = selectedRow.Cells["sTenDV"].Value.ToString();
                txtGia.Text = selectedRow.Cells["fDonGia"].Value.ToString();

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
                string madv = txtMa.Text;
                string tendv = txtTen.Text;
                if (string.IsNullOrEmpty(madv) || string.IsNullOrEmpty(tendv))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                float dongia = float.Parse(txtGia.Text);

                string anh = ofd.FileName;
                string[] arr = anh.Split('\\');
                anh = arr[arr.Length - 1];

                // Chuyen anh vao thu muc Image
                string sourcePath = ofd.FileName;
                string targetPath = Application.StartupPath + @"\Image\" + anh;
                if(sourcePath != "")
                { 
                    System.IO.File.Copy(sourcePath, targetPath, true); 
                }
                else
                {
                    anh = "NULL";
                }

                DataTable dataTable = dtBase.ReadData("Select sMaDV from tblDichVuKham where sMaDV = N'" +
                    madv + "'");
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Dịch vụ này đã tồn tại");
                    return;
                }
                else
                {
                    dtBase.ChangeData("Insert into tblDichVuKham (sMaDV, sTenDV, fDonGia, sAnh)" +
                    " values (N'" + madv + "',N'" + tendv + "','" + dongia + "',N'" + anh + "')");
                    MessageBox.Show("Thêm Thành Công");
                    refresh();
                }
            }
            else if (chucnang == 2)
            {
                string madv = txtMa.Text;
                string tendv = txtTen.Text;
                if (string.IsNullOrEmpty(madv) || string.IsNullOrEmpty(tendv))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                    return;
                }
                float dongia = float.Parse(txtGia.Text);

                string anh = ofd.FileName;
                string[] arr = anh.Split('\\');
                anh = arr[arr.Length - 1];

                dtBase.ChangeData("Update tblDichVuKham" +
                    "SET [sTenDV] = N'" + tendv + "', " +
                    "[fDonGia] = " + dongia + ", " +
                    "[sAnh] = N'" + anh + "' " +
                    "WHERE [sMaDV] = '" + madv + "'");
                MessageBox.Show("Sửa thành công");
                refresh();
            }
            else if (chucnang == 3)
            {
                if (!string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    txtMa.ReadOnly = true;
                    string madv = txtMa.Text;
                    DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        dtBase.ChangeData("Delete from tblDichVuKham where sMaDV=N'" + madv + "'");
                        MessageBox.Show("Xóa thành công dịch vụ");
                        refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa ");
                }
            }
        }

        private void FormDichVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.reload = true;
        }
    }
}
