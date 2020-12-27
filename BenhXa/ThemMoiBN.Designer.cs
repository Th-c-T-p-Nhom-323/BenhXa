namespace BenhXa
{
    partial class ThemMoiBN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_donvi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_Sex = new System.Windows.Forms.ComboBox();
            this.dtp_NS = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_capbac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tenBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(343, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM MỚI BỆNH NHÂN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_donvi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbb_Sex);
            this.panel1.Controls.Add(this.dtp_NS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_capbac);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_tenBN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_chucvu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 246);
            this.panel1.TabIndex = 1;
            // 
            // txt_donvi
            // 
            this.txt_donvi.Location = new System.Drawing.Point(126, 193);
            this.txt_donvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(165, 22);
            this.txt_donvi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đơn vị";
            // 
            // cbb_Sex
            // 
            this.cbb_Sex.FormattingEnabled = true;
            this.cbb_Sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_Sex.Location = new System.Drawing.Point(450, 117);
            this.cbb_Sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_Sex.Name = "cbb_Sex";
            this.cbb_Sex.Size = new System.Drawing.Size(169, 24);
            this.cbb_Sex.TabIndex = 11;
            // 
            // dtp_NS
            // 
            this.dtp_NS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NS.Location = new System.Drawing.Point(450, 61);
            this.dtp_NS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NS.Name = "dtp_NS";
            this.dtp_NS.Size = new System.Drawing.Size(178, 22);
            this.dtp_NS.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giới tính";
            // 
            // txt_capbac
            // 
            this.txt_capbac.Location = new System.Drawing.Point(724, 58);
            this.txt_capbac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_capbac.Name = "txt_capbac";
            this.txt_capbac.Size = new System.Drawing.Size(165, 22);
            this.txt_capbac.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cấp bậc";
            // 
            // txt_tenBN
            // 
            this.txt_tenBN.Location = new System.Drawing.Point(126, 114);
            this.txt_tenBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenBN.Name = "txt_tenBN";
            this.txt_tenBN.Size = new System.Drawing.Size(165, 22);
            this.txt_tenBN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ và tên";
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Location = new System.Drawing.Point(724, 122);
            this.txt_chucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Size = new System.Drawing.Size(165, 22);
            this.txt_chucvu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BN";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(403, 346);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 25);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // ThemMoiBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 388);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemMoiBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới bệnh nhân";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_Sex;
        private System.Windows.Forms.DateTimePicker dtp_NS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_capbac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tenBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_donvi;
        private System.Windows.Forms.Label label8;
    }
}