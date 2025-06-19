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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf|Document File (*.doc)|*.doc|All Files|*.*";
            openFileDialog.InitialDirectory = "C:\\Users\\LAPTOP-PC\\Desktop";
            openFileDialog.FilterIndex = 1;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf|Document File (*.doc)|*.doc|All Files|*.*";
            saveFileDialog.InitialDirectory = "C:\\Users\\LAPTOP-PC\\Desktop";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".rtf";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
                richTextBox1.SelectionColor = fontDialog.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = "";

        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = Clipboard.GetText();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(richTextBox1.SelectedText == "")
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
            }

            else
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
            }

            if (Clipboard.GetText() == "")
            {
                pasteToolStripMenuItem.Enabled = false;
            }
            else
            {
                pasteToolStripMenuItem.Enabled = true;
            }
        }
    }
}
