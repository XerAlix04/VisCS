namespace BaiKiemTra_16_11
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số TC";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(109, 63);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(363, 22);
            this.txtMaMon.TabIndex = 3;
            this.txtMaMon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMaMon_MouseClick);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(109, 134);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(363, 22);
            this.txtTenMon.TabIndex = 4;
            // 
            // txtTinChi
            // 
            this.txtTinChi.Location = new System.Drawing.Point(109, 212);
            this.txtTinChi.MaxLength = 2;
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.Size = new System.Drawing.Size(363, 22);
            this.txtTinChi.TabIndex = 5;
            this.txtTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTinChi_KeyPress);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(621, 63);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(127, 51);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(621, 134);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(127, 51);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(59, 272);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(44, 16);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTinChi);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cập nhật danh mục môn học";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtTinChi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

