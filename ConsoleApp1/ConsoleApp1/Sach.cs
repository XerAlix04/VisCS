using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sach
    {
        public int MaSach { get; set; }
        public string TenSach {  get; set; }
        public string TenTacGia {  get; set; }
        public int Slg {  get; set; }
        public Sach() 
        {
            MaSach = 0;
            TenSach = "";
            TenTacGia = "";
            Slg = 0;
        }
        public Sach(int maSach, string tenSach, string tenTacGia, int slg)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TenTacGia = tenTacGia;
            Slg = slg;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma sach"); 
            MaSach = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten sach");
            TenSach = Console.ReadLine();
            Console.WriteLine("Nhap ten tac gia");
            TenTacGia = Console.ReadLine();
            Console.WriteLine("Nhap so luong");
            Slg = int.Parse(Console.ReadLine());
        }
    }
}
