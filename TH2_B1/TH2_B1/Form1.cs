using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddComboBox()
        {
            comboBox1.Items.Add("Tin học đại cương");
            comboBox1.Items.Add("Giải tích F1");
            comboBox1.Items.Add("Tiếng Anh A0");
            comboBox1.Items.Add("Triết học Mác-Lênin");
            comboBox1.Items.Add("Vật lý F1");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();
            this.KeyPreview = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if(textBox2.Text.Length == 0)
            {
                MessageBox.Show("Nhập lại vì chưa nhập điểm");
                kt = 0;
            }
            if(kt == 1)
            {
                listBox1.Items.Add(comboBox1.Text + "|" + textBox1.Text + "|" + textBox2.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tin học đại cương")
                textBox1.Text = "2";
            if (comboBox1.Text == "Giải tích F1")
                textBox1.Text = "3";
            if (comboBox1.Text == "Tiếng Anh A0")
                textBox1.Text = "3";
            if (comboBox1.Text == "Triết học Mác-Lênin")
                textBox1.Text = "2";
            if (comboBox1.Text == "Vật lý F1")
                textBox1.Text = "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Thêm môn học vào danh sách");
            }
            else
            {
                int tongTinChi = 0;
                double tongDiem = 0;
                foreach (var monHoc in listBox1.Items)
                {
                    string[] parts = monHoc.ToString().Split('|');
                    int soTinChi = int.Parse(parts[1].Trim().Split(' ')[0]);
                    double diem = double.Parse(parts[2].Trim().Split(' ')[1]);

                    tongTinChi += soTinChi;
                    tongDiem += diem;
                }
                double diemTB = tongDiem / tongTinChi;
                textBox3.Text = tongTinChi.ToString();
                textBox4.Text = tongDiem.ToString("0.0");
                textBox5.Text = diemTB.ToString("0.0");
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string selection = comboBox1.SelectedIndex.ToString();
            if (selection == "Tin học đại cương" || selection == "Triết học Mác-Lênin")
            {
                textBox1.Text = "2";
            }
            else if (selection == "Giải tích F1" || selection == "Tiếng Anh A0" || selection == "Vật lý F1")
            {
                textBox1.Text = "3";
            }
        }
    }
}
