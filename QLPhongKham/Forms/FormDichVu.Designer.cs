namespace QLPhongKham.Forms
{
    partial class FormDichVu
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnAnh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục dịch vụ";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(141, 60);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(204, 22);
            this.txtMa.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(141, 128);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(204, 22);
            this.txtTen.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(141, 202);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(204, 22);
            this.txtGia.TabIndex = 8;
            // 
            // btnAnh
            // 
            this.btnAnh.Location = new System.Drawing.Point(464, 92);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(75, 23);
            this.btnAnh.TabIndex = 10;
            this.btnAnh.Text = "Ảnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(555, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 131);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 415);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(171, 415);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(338, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(664, 415);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(124, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Đơn giá";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(505, 415);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 23);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnh);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Name = "FormDichVu";
            this.Text = "Danh mục dịch vụ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDichVu_FormClosed);
            this.Load += new System.EventHandler(this.FormDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
    }
}