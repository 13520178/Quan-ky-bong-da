namespace Football_Manager
{
    partial class frmcauthu
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
            this.comboBox_Madoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_MaCT = new System.Windows.Forms.TextBox();
            this.textBox_TenCT = new System.Windows.Forms.TextBox();
            this.textBox_Ghichu = new System.Windows.Forms.TextBox();
            this.comboBox_LoaiCT = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Vitri = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_SoAo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_HuyBo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_CauThu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đội";
            // 
            // comboBox_Madoi
            // 
            this.comboBox_Madoi.FormattingEnabled = true;
            this.comboBox_Madoi.Location = new System.Drawing.Point(297, 8);
            this.comboBox_Madoi.Name = "comboBox_Madoi";
            this.comboBox_Madoi.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Madoi.TabIndex = 10;
            this.comboBox_Madoi.SelectedIndexChanged += new System.EventHandler(this.comboBox_Madoi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã CT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên CT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(6, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 21);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(9, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Loại CT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(9, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ghi chú";
            // 
            // textBox_MaCT
            // 
            this.textBox_MaCT.Enabled = false;
            this.textBox_MaCT.Location = new System.Drawing.Point(63, 20);
            this.textBox_MaCT.Name = "textBox_MaCT";
            this.textBox_MaCT.Size = new System.Drawing.Size(100, 21);
            this.textBox_MaCT.TabIndex = 5;
            // 
            // textBox_TenCT
            // 
            this.textBox_TenCT.Location = new System.Drawing.Point(63, 48);
            this.textBox_TenCT.Name = "textBox_TenCT";
            this.textBox_TenCT.Size = new System.Drawing.Size(185, 21);
            this.textBox_TenCT.TabIndex = 6;
            // 
            // textBox_Ghichu
            // 
            this.textBox_Ghichu.Location = new System.Drawing.Point(68, 180);
            this.textBox_Ghichu.Name = "textBox_Ghichu";
            this.textBox_Ghichu.Size = new System.Drawing.Size(238, 21);
            this.textBox_Ghichu.TabIndex = 7;
            // 
            // comboBox_LoaiCT
            // 
            this.comboBox_LoaiCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LoaiCT.FormattingEnabled = true;
            this.comboBox_LoaiCT.Items.AddRange(new object[] {
            "Nội",
            "Ngoại"});
            this.comboBox_LoaiCT.Location = new System.Drawing.Point(94, 143);
            this.comboBox_LoaiCT.Name = "comboBox_LoaiCT";
            this.comboBox_LoaiCT.Size = new System.Drawing.Size(91, 23);
            this.comboBox_LoaiCT.TabIndex = 11;
            this.comboBox_LoaiCT.SelectedIndexChanged += new System.EventHandler(this.comboBox_LoaiCT_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox_Vitri);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_SoAo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_HuyBo);
            this.groupBox1.Controls.Add(this.comboBox_LoaiCT);
            this.groupBox1.Controls.Add(this.textBox_Ghichu);
            this.groupBox1.Controls.Add(this.textBox_TenCT);
            this.groupBox1.Controls.Add(this.textBox_MaCT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin CT";
            // 
            // comboBox_Vitri
            // 
            this.comboBox_Vitri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Vitri.FormattingEnabled = true;
            this.comboBox_Vitri.Items.AddRange(new object[] {
            "GK",
            "CB",
            "LCB",
            "RCB",
            "RB",
            "LB",
            "CDM ",
            "RM",
            "LM",
            "CAM",
            "LW",
            "ST",
            "RW",
            "CM",
            "RCM",
            "LCM"});
            this.comboBox_Vitri.Location = new System.Drawing.Point(296, 147);
            this.comboBox_Vitri.Name = "comboBox_Vitri";
            this.comboBox_Vitri.Size = new System.Drawing.Size(91, 23);
            this.comboBox_Vitri.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(211, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vi trí ";
            // 
            // textBox_SoAo
            // 
            this.textBox_SoAo.Location = new System.Drawing.Point(324, 49);
            this.textBox_SoAo.Name = "textBox_SoAo";
            this.textBox_SoAo.Size = new System.Drawing.Size(63, 21);
            this.textBox_SoAo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(263, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số áo";
            // 
            // button_HuyBo
            // 
            this.button_HuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_HuyBo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_HuyBo.FlatAppearance.BorderSize = 0;
            this.button_HuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HuyBo.ForeColor = System.Drawing.Color.Black;
            this.button_HuyBo.Location = new System.Drawing.Point(321, 180);
            this.button_HuyBo.Name = "button_HuyBo";
            this.button_HuyBo.Size = new System.Drawing.Size(75, 25);
            this.button_HuyBo.TabIndex = 13;
            this.button_HuyBo.Text = "Huy";
            this.button_HuyBo.UseVisualStyleBackColor = false;
            this.button_HuyBo.Click += new System.EventHandler(this.button_HuyBo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách cầu thủ";
            // 
            // dataGridView_CauThu
            // 
            this.dataGridView_CauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_CauThu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView_CauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CauThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dataGridView_CauThu.Location = new System.Drawing.Point(441, 35);
            this.dataGridView_CauThu.Name = "dataGridView_CauThu";
            this.dataGridView_CauThu.ReadOnly = true;
            this.dataGridView_CauThu.Size = new System.Drawing.Size(402, 266);
            this.dataGridView_CauThu.TabIndex = 6;
            this.dataGridView_CauThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CauThu_CellClick);
            this.dataGridView_CauThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CauThu_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mùa Giải";
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.Color.White;
            this.button_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.Black;
            this.button_Xoa.Image = global::Football_Manager.Properties.Resources.Recycle_Bin_Empty;
            this.button_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Xoa.Location = new System.Drawing.Point(333, 253);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(85, 40);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.Color.White;
            this.button_Them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.Black;
            this.button_Them.Image = global::Football_Manager.Properties.Resources.ADD;
            this.button_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Them.Location = new System.Drawing.Point(94, 256);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(98, 37);
            this.button_Them.TabIndex = 9;
            this.button_Them.Text = "Thêm";
            this.button_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.Color.White;
            this.button_Sua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.ForeColor = System.Drawing.Color.Black;
            this.button_Sua.Image = global::Football_Manager.Properties.Resources.text;
            this.button_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Sua.Location = new System.Drawing.Point(222, 254);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(85, 39);
            this.button_Sua.TabIndex = 7;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Image = global::Football_Manager.Properties.Resources.exit;
            this.button_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Thoat.Location = new System.Drawing.Point(945, 245);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(92, 45);
            this.button_Thoat.TabIndex = 9;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // frmcauthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 302);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.comboBox_Madoi);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.dataGridView_CauThu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmcauthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN CẦU THỦ";
            this.Load += new System.EventHandler(this.frmcauthu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.ComboBox comboBox_Madoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_MaCT;
        private System.Windows.Forms.TextBox textBox_TenCT;
        private System.Windows.Forms.TextBox textBox_Ghichu;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.ComboBox comboBox_LoaiCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_CauThu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_HuyBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Vitri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SoAo;
        private System.Windows.Forms.Label label6;
    }
}