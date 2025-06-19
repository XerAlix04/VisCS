using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_1
{
    internal class SinhVien
    {
        private string HT;
        private string DOB;
        private double LT;
        private double CSDL;
        private double TKW;

        public SinhVien()
        {
            HT = "";
            DOB = "";
            LT = 0;
            CSDL = 0; 
            TKW = 0;
        }
        public SinhVien(string hT, string dOB, double lT, double cSDL, double tKW)
        {
            HT = hT;
            DOB = dOB;
            LT = lT;
            CSDL = cSDL;
            TKW = tKW;
        }
        public string getHT() { return HT; }
        public string getDOB() { return DOB; }
        public double getLT() { return LT; }
        public double getCSDL() { return CSDL; }
        public double getTKW() { return TKW; }
        public void setHT(string hT) { HT = hT; }
        public void setDOB(string dOB) { DOB = dOB; }
        public void setLT(double lT) { LT = lT; }
        public void setCSDL(double cSDL) { CSDL = cSDL; }
        public void setTKW(double tKW) { TKW = tKW; }
        public bool CheckQuaMon()
        {
            if (LT >= 5 && CSDL >= 5 && TKW >= 5) { return true; }
            else { return false; }
        }
    }
}
