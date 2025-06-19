using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class TuyenSinh: ThiSinh
    {
        private int KhuVuc;

        public TuyenSinh()
        {
            SBD = 0;
            HT = "";
            m1 = 0;
            m2 = 0;
            m3 = 0;
            KhuVuc = 1;
        }
        public TuyenSinh(int sBD, string hT, double m1, double m2, double m3, int khuVuc): base(sBD, hT, m1, m2, m3)
        {
            KhuVuc = khuVuc;
        }
        public int getKhuVuc() { return KhuVuc; }
        public void setKhuVuc(int khuVuc) { KhuVuc = khuVuc; }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap khu vuc"); KhuVuc = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("SBD: {0}. Ho ten: {1}. Diem 3 mon: {2}, {3}, {4}", getSBD(), getHT(), getM1(), getM2(), getM3());
        }
        public override double TongDiem()
        {
            if (KhuVuc == 1)
            {
                return base.TongDiem();
            }
            else if (KhuVuc == 2)
            {
                return base.TongDiem() + 1;
            }
            else
            {
                return base.TongDiem() + 2;
            }
        }
    }
}
