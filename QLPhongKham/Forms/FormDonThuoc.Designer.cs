namespace QLPhongKham.Forms
{
    partial class FormDonThuoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenP = new System.Windows.Forms.TextBox();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtMaP = new System.Windows.Forms.TextBox();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSlg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý đơn thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đơn thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã bác sĩ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên bác sĩ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenP);
            this.groupBox1.Controls.Add(this.txtTenBS);
            this.groupBox1.Controls.Add(this.txtMaBS);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.txtMaP);
            this.groupBox1.Controls.Add(this.txtMaDon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(521, 133);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(205, 22);
            this.txtSDT.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(521, 94);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(205, 22);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtTenP
            // 
            this.txtTenP.Location = new System.Drawing.Point(521, 52);
            this.txtTenP.Name = "txtTenP";
            this.txtTenP.Size = new System.Drawing.Size(205, 22);
            this.txtTenP.TabIndex = 15;
            // 
            // txtTenBS
            // 
            this.txtTenBS.Location = new System.Drawing.Point(133, 133);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(205, 22);
            this.txtTenBS.TabIndex = 14;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(133, 94);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(205, 22);
            this.txtMaBS.TabIndex = 13;
            this.txtMaBS.TextChanged += new System.EventHandler(this.txtMaBS_TextChanged);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(133, 52);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(205, 22);
            this.txtNgayLap.TabIndex = 12;
            // 
            // txtMaP
            // 
            this.txtMaP.Location = new System.Drawing.Point(521, 15);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(205, 22);
            this.txtMaP.TabIndex = 11;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Location = new System.Drawing.Point(133, 15);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(205, 22);
            this.txtMaDon.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên bệnh nhân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã bệnh nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtSlg);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtTenThuoc);
            this.groupBox2.Controls.Add(this.txtMaThuoc);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 77);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thuốc";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(664, 33);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(95, 22);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(282, 33);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(95, 22);
            this.txtTenThuoc.TabIndex = 4;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(97, 33);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(95, 22);
            this.txtMaThuoc.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(605, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Đơn giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên thuốc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã thuốc";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 468);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(236, 468);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(446, 468);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(632, 468);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 23);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtSlg
            // 
            this.txtSlg.Location = new System.Drawing.Point(481, 33);
            this.txtSlg.Name = "txtSlg";
            this.txtSlg.Size = new System.Drawing.Size(95, 22);
            this.txtSlg.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(415, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Số lượng";
            // 
            // FormDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDonThuoc";
            this.Text = "Đơn thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenP;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMaP;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSlg;
        private System.Windows.Forms.Label label13;
    }
}