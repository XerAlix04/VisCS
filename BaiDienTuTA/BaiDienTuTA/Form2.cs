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
    public partial class Form2 : Form
    {
        BaiTapDienTu bt;
        public Form2(BaiTapDienTu baitap)
        {
            InitializeComponent();
            bt = baitap;
            textBox1.Text = (bt.deBai);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diem = 0;
            string string1 = textBox2.Text;
            string string2 = textBox3.Text;
            string string3 = textBox4.Text;
            string string4 = textBox5.Text;
            string string5 = textBox6.Text;
            string string6 = textBox7.Text;
            string string7 = textBox8.Text;
            string string8 = textBox9.Text;
            string string9 = textBox10.Text;
            string string10 = textBox11.Text;

            if (string1.Equals(bt.dapAnTungCau[0]))
            {
                textBox2.BackColor = Color.Green;
                diem++;
            }
            if (string2.Equals(bt.dapAnTungCau[1]))
            {
                textBox3.BackColor = Color.Green;
                diem++;
            }
            if (string3.Equals(bt.dapAnTungCau[2]))
            {
                textBox4.BackColor = Color.Green;
                diem++;
            }
            if (string4.Equals(bt.dapAnTungCau[3]))
            {
                textBox5.BackColor = Color.Green;
                diem++;
            }
            if (string5.Equals(bt.dapAnTungCau[4]))
            {
                textBox6.BackColor = Color.Green;
                diem++;
            }
            if (string6.Equals(bt.dapAnTungCau[5]))
            {
                textBox7.BackColor = Color.Green;
                diem++;
            }
            if (string7.Equals(bt.dapAnTungCau[6]))
            {
                textBox8.BackColor = Color.Green;
                diem++;
            }
            if (string8.Equals(bt.dapAnTungCau[7]))
            {
                textBox9.BackColor = Color.Green;
                diem++;
            }
            if (string9.Equals(bt.dapAnTungCau[8]))
            {
                textBox10.BackColor = Color.Green;
                diem++;
            }
            if (string10.Equals(bt.dapAnTungCau[9]))
            {
                textBox11.BackColor = Color.Green;
                diem++;
            }
            MessageBox.Show("Điểm của bạn là: " + diem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (bt.dapAn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (bt.deBai);
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
