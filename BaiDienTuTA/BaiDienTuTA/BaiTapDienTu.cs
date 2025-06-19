using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiDienTuTA
{
    public class BaiTapDienTu
    {
        public string deBai;
        public string dapAn;
        public List<string> dapAnTungCau;
        public BaiTapDienTu() { }
        public BaiTapDienTu(string deBai, string dapAn)
        {
            this.deBai = deBai;
            this.dapAn = dapAn;
        }
        public BaiTapDienTu(string deBai, string dapAn, List<string> dapAnTungCau)
        {
            this.deBai = deBai;
            this.dapAn = dapAn;
            this.dapAnTungCau = dapAnTungCau;
        }
        
        
    }
}
