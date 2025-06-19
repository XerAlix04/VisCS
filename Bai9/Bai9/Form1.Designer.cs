namespace Bai9
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
            this.txtVanBan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdovntime = new System.Windows.Forms.RadioButton();
            this.rdovnuni = new System.Windows.Forms.RadioButton();
            this.rdotahoma = new System.Windows.Forms.RadioButton();
            this.rdovnArial = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoViolet = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkStrikeout = new System.Windows.Forms.CheckBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVanBan
            // 
            this.txtVanBan.Location = new System.Drawing.Point(320, 39);
            this.txtVanBan.Name = "txtVanBan";
            this.txtVanBan.Size = new System.Drawing.Size(335, 30);
            this.txtVanBan.TabIndex = 0;
            this.txtVanBan.Text = "Microsoft Visual C#";
            this.txtVanBan.FontChanged += new System.EventHandler(this.txtVanBan_FontChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdovnArial);
            this.groupBox1.Controls.Add(this.rdotahoma);
            this.groupBox1.Controls.Add(this.rdovnuni);
            this.groupBox1.Controls.Add(this.rdovntime);
            this.groupBox1.Location = new System.Drawing.Point(106, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu chữ";
            // 
            // rdovntime
            // 
            this.rdovntime.AutoSize = true;
            this.rdovntime.Location = new System.Drawing.Point(29, 43);
            this.rdovntime.Name = "rdovntime";
            this.rdovntime.Size = new System.Drawing.Size(95, 26);
            this.rdovntime.TabIndex = 0;
            this.rdovntime.TabStop = true;
            this.rdovntime.Text = ".vnTime";
            this.rdovntime.UseVisualStyleBackColor = true;
            // 
            // rdovnuni
            // 
            this.rdovnuni.AutoSize = true;
            this.rdovnuni.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdovnuni.Location = new System.Drawing.Point(29, 75);
            this.rdovnuni.Name = "rdovnuni";
            this.rdovnuni.Size = new System.Drawing.Size(131, 27);
            this.rdovnuni.TabIndex = 1;
            this.rdovnuni.TabStop = true;
            this.rdovnuni.Text = ".vnUniverse";
            this.rdovnuni.UseVisualStyleBackColor = true;
            // 
            // rdotahoma
            // 
            this.rdotahoma.AutoSize = true;
            this.rdotahoma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdotahoma.Location = new System.Drawing.Point(29, 107);
            this.rdotahoma.Name = "rdotahoma";
            this.rdotahoma.Size = new System.Drawing.Size(104, 28);
            this.rdotahoma.TabIndex = 2;
            this.rdotahoma.TabStop = true;
            this.rdotahoma.Text = "Tahoma";
            this.rdotahoma.UseVisualStyleBackColor = true;
            // 
            // rdovnArial
            // 
            this.rdovnArial.AutoSize = true;
            this.rdovnArial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdovnArial.Location = new System.Drawing.Point(29, 139);
            this.rdovnArial.Name = "rdovnArial";
            this.rdovnArial.Size = new System.Drawing.Size(70, 27);
            this.rdovnArial.TabIndex = 3;
            this.rdovnArial.TabStop = true;
            this.rdovnArial.Text = "Arial";
            this.rdovnArial.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoGreen);
            this.groupBox2.Controls.Add(this.rdoViolet);
            this.groupBox2.Controls.Add(this.rdoBlue);
            this.groupBox2.Controls.Add(this.rdoRed);
            this.groupBox2.Location = new System.Drawing.Point(701, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màu chữ";
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.ForeColor = System.Drawing.Color.Green;
            this.rdoGreen.Location = new System.Drawing.Point(29, 139);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(79, 26);
            this.rdoGreen.TabIndex = 3;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            // 
            // rdoViolet
            // 
            this.rdoViolet.AutoSize = true;
            this.rdoViolet.ForeColor = System.Drawing.Color.Violet;
            this.rdoViolet.Location = new System.Drawing.Point(29, 107);
            this.rdoViolet.Name = "rdoViolet";
            this.rdoViolet.Size = new System.Drawing.Size(79, 26);
            this.rdoViolet.TabIndex = 2;
            this.rdoViolet.TabStop = true;
            this.rdoViolet.Text = "Violet";
            this.rdoViolet.UseVisualStyleBackColor = true;
            this.rdoViolet.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdoBlue.Location = new System.Drawing.Point(29, 75);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(68, 26);
            this.rdoBlue.TabIndex = 1;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.ForeColor = System.Drawing.Color.Red;
            this.rdoRed.Location = new System.Drawing.Point(29, 43);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(63, 26);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkStrikeout);
            this.groupBox3.Controls.Add(this.chkUnderline);
            this.groupBox3.Controls.Add(this.chkItalic);
            this.groupBox3.Controls.Add(this.chkBold);
            this.groupBox3.Location = new System.Drawing.Point(412, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 196);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HIệu ứng";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkBold.Location = new System.Drawing.Point(34, 34);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(70, 27);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkItalic.Location = new System.Drawing.Point(35, 67);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(76, 26);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkUnderline.Location = new System.Drawing.Point(35, 99);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(110, 26);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // chkStrikeout
            // 
            this.chkStrikeout.AutoSize = true;
            this.chkStrikeout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkStrikeout.Location = new System.Drawing.Point(35, 131);
            this.chkStrikeout.Name = "chkStrikeout";
            this.chkStrikeout.Size = new System.Drawing.Size(103, 26);
            this.chkStrikeout.TabIndex = 3;
            this.chkStrikeout.Text = "Strikeout";
            this.chkStrikeout.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(234, 374);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(193, 49);
            this.btnLamLai.TabIndex = 4;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(579, 374);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(193, 49);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVanBan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVanBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdovnArial;
        private System.Windows.Forms.RadioButton rdotahoma;
        private System.Windows.Forms.RadioButton rdovnuni;
        private System.Windows.Forms.RadioButton rdovntime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoViolet;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkStrikeout;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
    }
}

