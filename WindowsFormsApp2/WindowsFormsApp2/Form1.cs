using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) == false && Char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            if(textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Phai nhap so luong phan tu cua day");
                textBox1.Focus();
                return;
            }
            int n = int.Parse(textBox1.Text);
            int[] a = new int[n];
            Random random = new Random();
            label2.Text = "Dãy số: ";
            for(i = 0; i < n; i++)
            {
                a[i] = random.Next(1,100);
                label2.Text = label2.Text + a[i].ToString() + " " ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int S = 0, i;
            int n = int.Parse(textBox1.Text);
            for (i = 0; i<n; i++)
            {
                S += a[i];
            }
            label3.Text = "Tổng dãy: ";
            label3.Text += S.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
