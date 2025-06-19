using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so xe: "); n = int.Parse(Console.ReadLine());
            ThueXe[] ds = new ThueXe[n];
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i].Nhap();
                ds[i].TinhTienThue();
            }
            for(int i = 0;i < ds.Length;i++)
            {
                ds[i].Xuat();
            }
        }
    }
}
