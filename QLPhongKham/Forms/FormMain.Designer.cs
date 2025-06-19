namespace QLPhongKham.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnBN = new System.Windows.Forms.Button();
            this.btnDV = new System.Windows.Forms.Button();
            this.btnDMT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnHD);
            this.panel1.Controls.Add(this.btnBN);
            this.panel1.Controls.Add(this.btnDV);
            this.panel1.Controls.Add(this.btnDMT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnHD
            // 
            this.btnHD.Location = new System.Drawing.Point(35, 353);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(123, 45);
            this.btnHD.TabIndex = 3;
            this.btnHD.Text = "Hóa đơn";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnBN
            // 
            this.btnBN.Location = new System.Drawing.Point(35, 270);
            this.btnBN.Name = "btnBN";
            this.btnBN.Size = new System.Drawing.Size(123, 45);
            this.btnBN.TabIndex = 2;
            this.btnBN.Text = "Bệnh nhân";
            this.btnBN.UseVisualStyleBackColor = true;
            this.btnBN.Click += new System.EventHandler(this.btnBN_Click);
            // 
            // btnDV
            // 
            this.btnDV.Location = new System.Drawing.Point(35, 192);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(123, 45);
            this.btnDV.TabIndex = 1;
            this.btnDV.Text = "Dịch  vụ";
            this.btnDV.UseVisualStyleBackColor = true;
            this.btnDV.Click += new System.EventHandler(this.btnDV_Click);
            // 
            // btnDMT
            // 
            this.btnDMT.Location = new System.Drawing.Point(35, 108);
            this.btnDMT.Name = "btnDMT";
            this.btnDMT.Size = new System.Drawing.Size(123, 45);
            this.btnDMT.TabIndex = 0;
            this.btnDMT.Text = "Danh mục thuốc";
            this.btnDMT.UseVisualStyleBackColor = true;
            this.btnDMT.Click += new System.EventHandler(this.btnDMT_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 75);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.btnMR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 375);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 239);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(430, 278);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(123, 45);
            this.btnMR.TabIndex = 1;
            this.btnMR.Text = "Mở rộng";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Phần mềm quản lý phòng khám";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnBN;
        private System.Windows.Forms.Button btnDV;
        private System.Windows.Forms.Button btnDMT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}