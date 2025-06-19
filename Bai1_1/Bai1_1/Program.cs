using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so sinh vien: "); n = int.Parse(Console.ReadLine());
            DanhSach danhSach = new DanhSach(n);
            danhSach.Nhap();
            danhSach.KhoaLuanTN();
            danhSach.ChuyenDeTN();
        }
    }
}
