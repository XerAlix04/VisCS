using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTNgheNhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddComboBox1()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                comboBox1.Items.Add(drive.Name);
            }
        }
        private void AddComboBox2(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] dirs = directory.GetDirectories("*.*");
            FileInfo[] files = directory.GetFiles();
            foreach (DirectoryInfo dir in dirs)
            {
                comboBox2.Items.Add(dir.Name);
            }
        }
        private void AddListBox1()
        {
            listBox1.Items.Clear();
            richTextBox1.Text = string.Empty;
            string[] files = Directory.GetFiles(comboBox1.Text+comboBox2.Text);
            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }
        private void PlayMusic(string music, string lyrics)
        {
            FileStream fs = new FileStream(lyrics, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            String value = sr.ReadToEnd();
            richTextBox1.Text = value;

            axWindowsMediaPlayer1.URL = music;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox1();
            this.KeyPreview = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = comboBox1.SelectedItem.ToString();
            AddComboBox2(path);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddListBox1();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: pull music url & lyrics URL
            string music = Path.GetFileName(listBox1.SelectedItem.ToString());
            string lyrics = Path.ChangeExtension(Path.GetFileName(music), ".txt");
            PlayMusic(music, lyrics);
        }
    }
}
