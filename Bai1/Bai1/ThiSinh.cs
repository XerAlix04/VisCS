using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class ThiSinh
    {
        protected int SBD;
        protected string HT;
        protected double m1;
        protected double m2;
        protected double m3;

        public ThiSinh()
        {
            SBD = 0;
            HT = "";
            m1 = 0;
            m2 = 0;
            m3 = 0;
        }
        public ThiSinh(int sBD, string hT, double m1, double m2, double m3)
        {
            SBD = sBD;
            HT = hT;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public int getSBD() {  return SBD; }
        public string getHT() { return HT; }
        public double getM1() { return m1; }
        public double getM2() { return m2; }
        public double getM3() { return m3; }
        public void setSBD(int sBD) { SBD = sBD; }
        public void setHT(string hT) { HT = hT; }
        public void setM1(double m) { m1 = m; }
        public void setM2(double m) { m2 = m; }
        public void setM3(double m) { m3 = m; }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap so bao danh"); SBD = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten"); HT = Console.ReadLine();
            Console.WriteLine("Nhap diem mon 1"); m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem mon 2"); m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem mon 3"); m3 = double.Parse(Console.ReadLine());
        }
        public virtual double TongDiem()
        {
            return m1 + m2 + m3;
        }
    }
}
