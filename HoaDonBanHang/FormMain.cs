using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDonBanHang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            if (Program.maNV == "")
            {
                danhMụcToolStripMenuItem.Enabled = false;
                bánHàngToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
                đăngXuấtToolStripMenuItem.Enabled = false;
            }
            else
            {
                danhMụcToolStripMenuItem.Enabled = true;
                bánHàngToolStripMenuItem.Enabled = true;
                thốngKêToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = true;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
