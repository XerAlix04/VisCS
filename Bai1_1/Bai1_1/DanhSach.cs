using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_1
{
    internal class DanhSach
    {
        private int n;
        private SinhVien[] ds;

        public DanhSach()
        {
            n = 1;
            ds[0] = new SinhVien();
        }
        public DanhSach(int n)
        {
            this.n = n;
            for(int i = 0; i<n; i++)
            {
                ds[i] = new SinhVien();
            }
        }
        public DanhSach(int n, SinhVien[] ds)
        {
            this.n = n;
            this.ds = ds;
        }
        public void Nhap()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu {0}", i);
                Console.WriteLine("Nhap ho ten: "); ds[i].setHT(Console.ReadLine());
                Console.WriteLine("Nhap ngay sinh: "); ds[i].setDOB(Console.ReadLine());
                Console.WriteLine("Nhap diem mon Lap trinh"); ds[i].setLT(double.Parse(Console.ReadLine()));
                Console.WriteLine("Nhap diem mon Co so du lieu"); ds[i].setCSDL(double.Parse(Console.ReadLine()));
                Console.WriteLine("Nhap diem mon Thiet ke Web"); ds[i].setTKW(double.Parse(Console.ReadLine()));
            }
        }
        public int ChuyenDeTN()
        {
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (ds[i].CheckQuaMon())
                {
                    res++;
                }
            }
            return res;
        }
        public int KhoaLuanTN()
        {
            int res = 0;
            for(int i = 0; i < n; i++)
            {
                if (ds[i].getLT() + ds[i].getCSDL() + ds[i].getTKW() >= 24 && ds[i].CheckQuaMon())
                {
                    res++;
                }
            }
            return res;
        }
    }
}
