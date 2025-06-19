using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_2
{
    internal class ThueXe
    {
        private int LoaiXe;
        private string NguoiThue;
        private int SoGioThue;
        private int TienThue;

        public ThueXe()
        {
            LoaiXe = 1;
            NguoiThue = string.Empty;
            SoGioThue = 0;
            TienThue = 0;
        }
        public ThueXe(int loaiXe, string nguoiThue, int soGioThue, int tienThue)
        {
            LoaiXe = loaiXe;
            NguoiThue = nguoiThue;
            SoGioThue = soGioThue;
            TienThue = tienThue;
        }
        public int getLoaiXe() {  return LoaiXe; }
        public string getNguoiThue() { return NguoiThue; }
        public int getSoGioThue() { return SoGioThue; }
        public int getTienThue() { return TienThue; }
        public void setLoaiXe(int loaiXe) { LoaiXe = loaiXe; }
        public void setNguoiThue(string nguoiThue) { NguoiThue = nguoiThue; }
        public void setSoGioThue(int soGioThue) { SoGioThue = soGioThue; }
        public void setTienThue(int tienThue) { TienThue = tienThue; }
        public void Nhap()
        {
            Console.WriteLine("Nhap loai xe: "); string txt = Console.ReadLine();
            if (string.Equals(txt, "XeDuLich", StringComparison.OrdinalIgnoreCase))
            {
                LoaiXe = 1;
            }
            else if (string.Equals(txt, "XeTai", StringComparison.OrdinalIgnoreCase))
            {
                LoaiXe = 2;
            }
            Console.WriteLine("Nhap ten nguoi thue"); NguoiThue = Console.ReadLine();
            Console.WriteLine("Nhap so gio thue"); SoGioThue = int.Parse(Console.ReadLine());
        }
        public void TinhTienThue()
        {
            if(LoaiXe == 1)
            {
                if (SoGioThue >= 1 ) { TienThue = 250000 + 70000 * (SoGioThue - 1); }
                else {  TienThue = 0; }
            }
            else if (LoaiXe == 2)
            {
                if (SoGioThue >= 1) { TienThue = 220000 + 85000 * (SoGioThue - 1); }
                else { TienThue = 0; }
            }
        }
        public void Xuat()
        {
            Console.Write("Nguoi thue: {0}\nSo gio thue: {1}\nTien thue: {2}\n", NguoiThue, SoGioThue, TienThue);
        }
    }
}
