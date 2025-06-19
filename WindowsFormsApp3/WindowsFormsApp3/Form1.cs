using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeBackColor(object sender, EventArgs e)
        {
            int r, g, b;
            r = vScrollBar1.Value;
            g = vScrollBar2.Value;
            b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
            label6.Text = r.ToString();
            label7.Text = g.ToString();
            label8.Text = b.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = comboBox1.SelectedItem.ToString();
            this.BackColor = Color.FromName(color);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font.Name, int.Parse(numericUpDown1.Value.ToString()), this.Font.Style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = 0;
            m = 0;
            h = 0;
            timer1.Start();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string hoten = listBox1.SelectedItem.ToString();
            textBox1.Text = hoten;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex  == -1)
            {
                MessageBox.Show("Phải chọn phần tử để sửa");
                return;
            }
            int index = listBox1.SelectedIndex;
            listBox1.Items[index] = textBox1.Text;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa SV này ko?","TB",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.FullOpen = true;
            Color c = new Color();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
                c = color.Color;
            }
            
            vScrollBar1.Value = int.Parse(c.R.ToString());
            vScrollBar2.Value = int.Parse(c.G.ToString());
            vScrollBar3.Value = int.Parse(c.B.ToString());
            label6.Text = vScrollBar1.Value.ToString();
            label7.Text = vScrollBar2.Value.ToString();
            label8.Text = vScrollBar3.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Nhập họ tên SV");
                return;
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s < 59)
            {
                s += 1;
            }
            else
            {
                if(m < 59)
                {
                    s = 0;
                    m += 1;
                }
                else
                {
                    s = 0;
                    m = 0;
                    h += 1;
                }
            }
            label9.Text = h + ":" + m + ":" + s;
        }
    }
}
