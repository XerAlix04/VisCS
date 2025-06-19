using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiDienTuTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void baiDienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu();
            bt.deBai = "My grandfather was born in China. He came from a very poor family " +
                "and was (1) _ of seven children. His parents lived (2) _ a small farm. " +
                "He didn't have a very good education. At the age of 17 he (3) _ home. " +
                "First he went to Shanghai and (4) _ he went to Hong Kong. He worked (5) _ a " +
                "waiter and then as a cook. When he was 21, he (6) _ my grandmother and had " +
                "four children.\r\nMy mother was (7) _ oldest. My grandmother died recently, and " +
                "my grandfather lives alone now. He is almost 80, (8) _ he is still very active " +
                "and interested in everything (9) _ is going on. He reads the papes and " +
                "(10) _ televison even though his eyesight is fairly poor.";
            bt.dapAn = "My grandfather was born in China. He came from a very poor family " +
                "and was (1) one of seven children. His parents lived (2) on a small farm. " +
                "He didn't have a very good education. At the age of 17 he (3) left home. " +
                "First he went to Shanghai and (4) then he went to Hong Kong. He worked (5) as a " +
                "waiter and then as a cook. When he was 21, he (6) married my grandmother and had " +
                "four children.\r\nMy mother was (7) the oldest. My grandmother died recently, and " +
                "my grandfather lives alone now. He is almost 80, (8) but he is still very active " +
                "and interested in everything (9) that is going on. He reads the papes and " +
                "(10) watches televison even though his eyesight is fairly poor.";
            
            List<string> list = new List<string>();
            list.Add("one");
            list.Add("on");
            list.Add("left");
            list.Add("then");
            list.Add("as");
            list.Add("married");
            list.Add("the");
            list.Add("but");
            list.Add("that");
            list.Add("watches");

            bt.dapAnTungCau = list;

            Form2 btdt = new Form2(bt);
            btdt.Show();
        }
    }
}
