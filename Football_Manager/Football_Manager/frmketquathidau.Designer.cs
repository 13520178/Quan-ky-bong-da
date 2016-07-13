namespace Football_Manager
{
    partial class frmketquathidau
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
            this.comboBox_MuaGiai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_MaThiDau = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_San = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_TenDoi1 = new System.Windows.Forms.TextBox();
            this.textBox_TenDoi2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_Luu = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mùa giải";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_MuaGiai
            // 
            this.comboBox_MuaGiai.FormattingEnabled = true;
            this.comboBox_MuaGiai.Location = new System.Drawing.Point(135, 19);
            this.comboBox_MuaGiai.Name = "comboBox_MuaGiai";
            this.comboBox_MuaGiai.Size = new System.Drawing.Size(159, 23);
            this.comboBox_MuaGiai.TabIndex = 6;
            this.comboBox_MuaGiai.SelectedIndexChanged += new System.EventHandler(this.comboBox_MuaGiai_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(361, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên đội khách";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên đội nhà";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_MaThiDau);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_MuaGiai);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_San);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_TenDoi1);
            this.groupBox1.Controls.Add(this.textBox_TenDoi2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 224);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trận Đấu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(361, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Thời gian";
            // 
            // comboBox_MaThiDau
            // 
            this.comboBox_MaThiDau.FormattingEnabled = true;
            this.comboBox_MaThiDau.Location = new System.Drawing.Point(135, 54);
            this.comboBox_MaThiDau.Name = "comboBox_MaThiDau";
            this.comboBox_MaThiDau.Size = new System.Drawing.Size(159, 23);
            this.comboBox_MaThiDau.TabIndex = 38;
            this.comboBox_MaThiDau.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaThiDau_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(465, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 23);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 21);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(360, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Vòng";
            // 
            // button_Them
            // 
            this.button_Them.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Them.FlatAppearance.BorderSize = 2;
            this.button_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.Black;
            this.button_Them.Image = global::Football_Manager.Properties.Resources.ADD;
            this.button_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Them.Location = new System.Drawing.Point(207, 178);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(217, 40);
            this.button_Them.TabIndex = 28;
            this.button_Them.Text = "Nhập Kết Quả Cho Trận Này";
            this.button_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_San
            // 
            this.textBox_San.Location = new System.Drawing.Point(135, 143);
            this.textBox_San.Name = "textBox_San";
            this.textBox_San.ReadOnly = true;
            this.textBox_San.Size = new System.Drawing.Size(159, 21);
            this.textBox_San.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(76, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Sân";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox_TenDoi1
            // 
            this.textBox_TenDoi1.Location = new System.Drawing.Point(135, 106);
            this.textBox_TenDoi1.Name = "textBox_TenDoi1";
            this.textBox_TenDoi1.ReadOnly = true;
            this.textBox_TenDoi1.Size = new System.Drawing.Size(159, 21);
            this.textBox_TenDoi1.TabIndex = 20;
            // 
            // textBox_TenDoi2
            // 
            this.textBox_TenDoi2.Location = new System.Drawing.Point(465, 106);
            this.textBox_TenDoi2.Name = "textBox_TenDoi2";
            this.textBox_TenDoi2.ReadOnly = true;
            this.textBox_TenDoi2.Size = new System.Drawing.Size(168, 21);
            this.textBox_TenDoi2.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(25, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "Mã Thi Đấu";
            // 
            // button_Luu
            // 
            this.button_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Luu.Image = global::Football_Manager.Properties.Resources.button_ok;
            this.button_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Luu.Location = new System.Drawing.Point(1226, 313);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(100, 48);
            this.button_Luu.TabIndex = 33;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Luu.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Football_Manager.Properties.Resources.exit;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(1226, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 42);
            this.button5.TabIndex = 32;
            this.button5.Text = "Thoát";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(493, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 41;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmketquathidau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 246);
            this.Controls.Add(this.button_Luu);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmketquathidau";
            this.Text = "KẾT QUẢ THI ĐẤU";
            this.Load += new System.EventHandler(this.frmketquathidau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_MuaGiai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_San;
        private System.Windows.Forms.TextBox textBox_TenDoi1;
        private System.Windows.Forms.TextBox textBox_TenDoi2;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox_MaThiDau;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;


    }
}