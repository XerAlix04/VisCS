using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, dc;
            Console.WriteLine("Nhap so thi sinh: "); n = int.Parse(Console.ReadLine());
            TuyenSinh[] ds = new TuyenSinh[n];
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i].Nhap();
            }
            Console.WriteLine("Nhap diem chuan: "); dc = int.Parse(Console.ReadLine());
            for (int i = 0;i < ds.Length;i++)
            {
                if (ds[i].TongDiem() >= dc)
                {
                    ds[i].Xuat();
                }
            }
        }
    }
}
