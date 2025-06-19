using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace HoaDonBanHang
{
    public partial class Form2 : Form
    {
        DataProcessor dtBase = new DataProcessor();
        Common cmm = new Common();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dtHD = dtBase.ReadData("Select MaHDBan from tblHDBan where NgayBan >= DATEADD(day, -7, GETDATE())");
            comboBox1.DataSource = dtHD;
            comboBox1.DisplayMember = "MaHDBan";
            if(Program.maNV != "")
            {
                DataTable dtNhanVien = dtBase.ReadData("Select MaNhanVien, TenNhanVien from tblNhanVien where MaNhanVien='" +
                    Program.maNV + "'");
                textBox3.Text = Program.maNV;
                textBox4.Text = dtNhanVien.Rows[0]["TenNhanVien"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtHDBan = dtBase.ReadData("Select * from tblHDBan where MaHDBan='" +
                comboBox1.Text + "'");
            textBox1.Text = dtHDBan.Rows[0]["MaHDBan"].ToString();
            dateTimePicker1.Text = dtHDBan.Rows[0]["NgayBan"].ToString();
            textBox13.Text = dtHDBan.Rows[0]["TongTien"].ToString();
            //TT Nhân viên
            textBox3.Text = dtHDBan.Rows[0]["MaNhanVien"].ToString();
            DataTable dtNV = dtBase.ReadData("Select * from tblNhanVien where MaNhanVien='" +
                    textBox3.Text + "'");
            textBox4.Text = dtNV.Rows[0]["TenNhanVien"].ToString();
            //TT Khách
            comboBox2.Text = dtHDBan.Rows[0]["MaKhach"].ToString();
            DataTable dtKhach = dtBase.ReadData("Select * from tblKhach where MaKhach='" +
                comboBox2.Text + "'");
            textBox5.Text = dtKhach.Rows[0]["TenKhach"].ToString();
            textBox7.Text = dtKhach.Rows[0]["SoDienThoai"].ToString();
            textBox6.Text = dtKhach.Rows[0]["DiaChi"].ToString();
            //Danh sách SP
            loadChiTietHDBan(comboBox1.Text);
        }

        void loadChiTietHDBan(string HDBan)
        {
            DataTable dtChiTiet = dtBase.ReadData("Select tblChiTietHDBan.MaHang, TenHang, " +
                "tblChiTietHDBan.SoLuong, DonGiaBan, GiamGia, ThanhTien " +
                "from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang = tblHang.MaHang " +
                "where MaHDBan='" + HDBan + "'");
            dataGridView1.DataSource = dtChiTiet;
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Giảm giá %";
            dataGridView1.Columns[5].HeaderText = "Thành tiền";
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dtKH = dtBase.ReadData("Select * from tblKhach where SoDienThoai='" +
                    textBox7.Text + "'");
                if (dtKH.Rows.Count > 0)
                {
                    comboBox2.Text = dtKH.Rows[0]["MaKhach"].ToString();
                    textBox5.Text = dtKH.Rows[0]["TenKhach"].ToString();
                    textBox6.Text = dtKH.Rows[0]["DiaChi"].ToString();
                }
                else
                {
                    comboBox2.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            textBox1.Text = cmm.AutoSinhKey("tblHDBan", "HDB" + dt.Day.ToString() + dt.Month.ToString()
                + dt.Year.ToString(), "MaHDBan");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double giamgia, sl, dongia, tt;
            if (textBox10.Text == "") giamgia = 0;
            else giamgia = double.Parse(textBox10.Text);
            if(textBox8.Text.Trim()=="") sl = 0;
            else sl = double.Parse(textBox8.Text);
            dongia = double.Parse(textBox11.Text);
            tt = dongia * sl * (1 - giamgia / 100);
            textBox12.Text = tt.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox8_TextChanged(sender, e);
            
        }

        //Lưu
        private void button3_Click(object sender, EventArgs e)
        {
            int slBan, slCon, slKho;
            DateTime dtNgayBan = dateTimePicker1.Value;
            //Kiểm tra ràng buộc các ttin nhập vào
            DataTable dtHDBan = dtBase.ReadData("Select * from tblHDBan where MaHDBan='" +
                textBox1.Text + "'");
            if(dtHDBan.Rows.Count == 0)
            {
                //insert HDBan
                dtBase.ChangeData("Insert into tblHDBan values('" + textBox1.Text + 
                    "','" + textBox3.Text + "','" + comboBox2.Text + "','" + 
                    string.Format("{0:MM/dd/yyyy}", dtNgayBan) + "','0')");
            }
            //Kiểm tra số lượng có đủ không
            DataTable dtHang = dtBase.ReadData("Select * from tblHang where MaHang='" +
                comboBox3.Text + "'");
            slKho = int.Parse(dtHang.Rows[0]["SoLuong"].ToString());
            slBan = int.Parse(textBox8.Text);
            slCon = slKho - slBan;
            if(slCon<0)
            {
                MessageBox.Show("Không đủ số lượng để bán. Kho chỉ còn " + slKho);
                return;
            }
            //Kiểm tra hàng đã chọn đã có trong chi tiết chưa?

            //Thêm sản phẩm vào ChiTietHDBan
            dtBase.ChangeData("Insert into tblChiTietHDBan values('" + textBox1.Text + "','" +
                comboBox3.Text + "'," + slBan + "," + int.Parse(textBox10.Text) + ",'" +
                textBox12.Text + "')");

            //update số lượng trong bảng tblHang
            dtBase.ChangeData("Update tblHang set SoLuong=" + slCon + " where MaHang='" + 
                comboBox3.Text + "'");
            //update HDBan
            //Tính lại tổng tiền HD
            dtHDBan = dtBase.ReadData("Select * from tblHDBan where MaHDBan='" + textBox1.Text + "'");
            double tongtien = double.Parse(dtHDBan.Rows[0]["TongTien"].ToString() +
                double.Parse(textBox12.Text));
            dtBase.ChangeData("Update tblHDBan set TongTien=" + tongtien.ToString() + " where MaHDBan='" +
                textBox1.Text + "'");
            //Load dl
            loadChiTietHDBan(textBox1.Text);
            textBox13.Text = tongtien.ToString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int slCon;
            //Tính lại tổng tiền cho hóa đơn và update lại bảng hóa đơn bán
            double tt, tongtien;
            tt = double.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            tongtien = double.Parse(textBox13.Text) - tt;
            dtBase.ChangeData("Update tblHDBan set TongTien='" + tongtien.ToString() +
                "' where MaHDBan='" + textBox1.Text + "'");
            textBox13.Text = tongtien.ToString();
            //Cập nhật lại số lượng trong bảng hàng
            DataTable dtHang = dtBase.ReadData("Select MaHang, SoLuong from tblHang where MaHang='" +
                dataGridView1.CurrentRow.Cells[0].Value + "'");
            slCon = int.Parse(dtHang.Rows[0]["SoLuong"].ToString());
            dtBase.ChangeData("Update tblHang set SoLuong=" + slCon + " where MaHang='" +
                dataGridView1.CurrentRow.Cells[0].Value + "'");
            //Xóa hàng trong bảng chi tiết hóa đơn
            dtBase.ChangeData("Delete tblChiTietHDBan where MaHang='" +
                dataGridView1.CurrentRow.Cells[0].Value + "' and MaHDBan='" + textBox1.Text + "'");
            //Load lại dữ liệu
            loadChiTietHDBan(textBox1.Text);
        }

        //Xóa
        private void button4_Click(object sender, EventArgs e)
        {
            int slCon;
            //Duyệt qua từng chitietHD, tính lại số lượng cho hàng, xóa chi tiết -> xóa hóa đơn
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //Cập nhật số lượng hàng
                DataTable dtHang = dtBase.ReadData("Select MaHang, SoLuong from tblHang where MaHang='"
                    + dataGridView1.Rows[i].Cells[0].Value + "'");
                slCon = int.Parse(dtHang.Rows[0]["SoLuong"].ToString()) +
                    int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                dtBase.ChangeData("update tblHang set SoLuong =" + slCon + " where MaHang='" +
                    dataGridView1.Rows[i].Cells[0].Value + "'");
                //Xóa hàng trong bảng chitietHDBan
                dtBase.ChangeData("delete tblChiTietHDBan where MaHang='" +
                    dataGridView1.Rows[i].Cells[0].Value + "' and MaHDBan='" + textBox1.Text + "'");
            }
            //Xóa hóa đơn
            dtBase.ChangeData("delete tblHDBan where MaHDBan='" + comboBox1.Text + "'");
            DataTable dtHD = dtBase.ReadData("Select MaHDBan from tblHDBan where NgayBan >= DATEADD(day, -7, GETDATE())");
            comboBox1.DataSource = dtHD;
            comboBox1.DisplayMember = "MaHDBan";
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook workbook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[0];
            Excel.Range exRange = (Excel.Range)worksheet.Cells[1, 1];
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "SIÊU THỊ MINI BÌNH AN";

            Excel.Range dc = (Excel.Range)(worksheet.Cells[2, 1]);
            dc.Font.Size = 13;
            dc.Font.Color = Color.Blue;
            dc.Value = "Số 156-Hai Bà Trưng";

            worksheet.Range["D4"].Font.Size = 20;
            worksheet.Range["D4"].Font.Bold = true;
            worksheet.Range["D4"].Font.Color = Color.Red;
            worksheet.Range["D4"].Value = "HOA DON BAN";

            worksheet.Range["A5:A8"].Font.Size = 12;
            worksheet.Range["A5"].Value = "Ma hoa don: " + textBox1.Text;
            worksheet.Range["A6"].Value = "Khach hang";
            worksheet.Range["A7"].Value = "Dia chi";
            worksheet.Range["A8"].Value = "Dien thoai";

            worksheet.Range["A10:G10"].Font.Size = 12;
            worksheet.Range["A10:G10"].Font.Bold = true;
            worksheet.Range["C10"].ColumnWidth = 25;
            worksheet.Range["G10"].ColumnWidth = 25;
            worksheet.Range["A10"].Value = "STT";
            worksheet.Range["B10"].Value = "Ma hang";
            worksheet.Range["C10"].Value = "Ten hang";
            worksheet.Range["D10"].Value = "So luong";
            worksheet.Range["E10"].Value = "Don gia ban";
            worksheet.Range["F10"].Value = "Giam gia";
            worksheet.Range["G10"].Value = "Thanh tien";

            int dong = 11;
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                worksheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                worksheet.Range["B" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                worksheet.Range["C" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                worksheet.Range["D" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                worksheet.Range["E" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                worksheet.Range["F" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[0].Value.ToString() + "%";
                worksheet.Range["G" + (dong + i).ToString()].Value = dataGridView1.Rows[i].Cells[0].Value.ToString() + "dong";
            }
            dong = dong + dataGridView1.Rows.Count;
            worksheet.Range["F" + dong.ToString()].Value = textBox13.Text + "dong";
            worksheet.Name = textBox1.Text;

            workbook.Activate();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 97-2002 Workbook|*.xls|Excel Workbook|*.xlsx|All Files|*.*";
            save.FilterIndex = 2;
            if(save.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(save.FileName);
            }
            exApp.Quit();
        }
    }
}
