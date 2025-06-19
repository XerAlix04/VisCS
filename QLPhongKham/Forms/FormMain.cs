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
    public partial class FormMain : Form
    {
        DataProcessor dtBase = new DataProcessor();
        int type = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void GetDataTable(int type)
        {
            if (type == 0)
            {
                DataTable dtDMT = dtBase.ReadData("Select sMaThuoc, sTenThuoc, sTenLoaiThuoc, fGiaThuoc from " +
                "tblThuoc inner join tblLoaiThuoc on tblThuoc.sMaLoaiThuoc = tblLoaiThuoc.sMaLoaiThuoc");
                dataGridView1.DataSource = dtDMT;
            }
            else if (type == 1) 
            { 
                DataTable dtDV = dtBase.ReadData("Select sMaDV, sTenDV, fDonGia from tblDichVuKham"); 
                dataGridView1.DataSource = dtDV;
            }
            else if (type == 2) 
            {
                DataTable dtBN = dtBase.ReadData("Select top 10 sMaBN, sTenBN, sGioiTinh, dNgaySinh, iSodienthoai " +
                "from tblBenhNhan");
                dataGridView1.DataSource = dtBN;
            }
            else if (type == 3) 
            {
                DataTable dtHD = dtBase.ReadData("Select sMaHD, tblHoaDon.sMaBN, sMaBS, tblHoaDon.dNgayLap from tblHoaDon inner join" +
                " tblDonThuoc on tblHoaDon.sMaDT = tblDonThuoc.sMaDT");
                //where tblHoaDon.dNgayLap >= DATEADD(day, -7, GETDATE())
                dataGridView1.DataSource = dtHD;
            }
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(Program.loaiDN == 1)
            {
                DataTable dtTen = dtBase.ReadData("Select sTenBS from tblBacSi where sMaBS = '" + Program.tenDN + "'");
                string ten = dtTen.Rows[0]["sTenBS"].ToString();
                label1.Text = "Xin chào bác sĩ " + ten + "!";
            }
            else if(Program.loaiDN == 0)
            {
                DataTable dtTen = dtBase.ReadData("Select sTenBN from tblBenhNhan where sMaBN = '" + Program.tenDN + "'");
                string ten = dtTen.Rows[0]["sTenBN"].ToString();
                label1.Text = "Xin chào bệnh nhân " + ten + "!";
            }
        }

        private void btnDMT_Click(object sender, EventArgs e)
        {
            type = 0;
            GetDataTable(type);
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            type = 1;
            GetDataTable(type);
        }

        private void btnBN_Click(object sender, EventArgs e)
        {
            type = 2;
            GetDataTable(type);
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            type = 3;
            GetDataTable(type);
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if(type == 0)
            {
                FormDanhMucThuoc formDanhMucThuoc = new FormDanhMucThuoc();
                formDanhMucThuoc.Show();
            }
            else if (type == 1)
            {
                FormDichVu formDichVu = new FormDichVu();
                formDichVu.Show();
            }
            else if (type == 2)
            {
                FormBenhNhan formBenhNhan = new FormBenhNhan();
                formBenhNhan.Show();
            }
            else if (type == 3)
            {
                FormHoaDon formHoaDon = new FormHoaDon();
                formHoaDon.Show();
            }
        }

        private void reload()
        {
            if(Program.reload == true)
            {
                GetDataTable(type);
                Program.reload = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.tenDN = "";
            Program.loaiDN = 0;
            this.Close();
        }
    }
}
