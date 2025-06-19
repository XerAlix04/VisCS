namespace BaiThi.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtSoTin = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin điểm thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tín";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm thi";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(81, 359);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 50);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm vào danh sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Danh sách các môn";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(246, 359);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 50);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa thông tin";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(426, 359);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(113, 50);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(426, 235);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(113, 52);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "Xuất ra Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(426, 119);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(113, 50);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(570, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 319);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(219, 128);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(167, 22);
            this.txtMaMon.TabIndex = 12;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(219, 178);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(167, 22);
            this.txtTenMon.TabIndex = 13;
            // 
            // txtSoTin
            // 
            this.txtSoTin.Location = new System.Drawing.Point(219, 235);
            this.txtSoTin.Name = "txtSoTin";
            this.txtSoTin.Size = new System.Drawing.Size(167, 22);
            this.txtSoTin.TabIndex = 14;
            this.txtSoTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTin_KeyPress);
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(219, 293);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(167, 22);
            this.txtDiemThi.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.txtSoTin);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtSoTin;
        private System.Windows.Forms.TextBox txtDiemThi;
    }
}