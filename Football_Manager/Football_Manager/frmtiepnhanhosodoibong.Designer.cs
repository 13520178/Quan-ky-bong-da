namespace Football_Manager
{
    partial class frmtiepnhanhosodoibong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_TenDoi = new System.Windows.Forms.TextBox();
            this.textBox_NhaTaiTro = new System.Windows.Forms.TextBox();
            this.textBox_SanNha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_DanhSachDoiBong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_CT = new System.Windows.Forms.Button();
            this.button_HLV = new System.Windows.Forms.Button();
            this.button_Luu = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_ThemMoi = new System.Windows.Forms.Button();
            this.Button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachDoiBong)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_TenDoi);
            this.groupBox1.Controls.Add(this.textBox_NhaTaiTro);
            this.groupBox1.Controls.Add(this.textBox_SanNha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đội bóng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_TenDoi
            // 
            this.textBox_TenDoi.Location = new System.Drawing.Point(132, 27);
            this.textBox_TenDoi.Name = "textBox_TenDoi";
            this.textBox_TenDoi.Size = new System.Drawing.Size(385, 23);
            this.textBox_TenDoi.TabIndex = 8;
            this.textBox_TenDoi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox_NhaTaiTro
            // 
            this.textBox_NhaTaiTro.Location = new System.Drawing.Point(132, 117);
            this.textBox_NhaTaiTro.Name = "textBox_NhaTaiTro";
            this.textBox_NhaTaiTro.Size = new System.Drawing.Size(385, 23);
            this.textBox_NhaTaiTro.TabIndex = 7;
            // 
            // textBox_SanNha
            // 
            this.textBox_SanNha.Location = new System.Drawing.Point(132, 74);
            this.textBox_SanNha.Name = "textBox_SanNha";
            this.textBox_SanNha.Size = new System.Drawing.Size(385, 23);
            this.textBox_SanNha.TabIndex = 5;
            this.textBox_SanNha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà tài trợ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sân nhà: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đội: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Danh sách các đội bóng tham dự giải đấu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView_DanhSachDoiBong
            // 
            this.dataGridView_DanhSachDoiBong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DanhSachDoiBong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_DanhSachDoiBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachDoiBong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dataGridView_DanhSachDoiBong.Location = new System.Drawing.Point(12, 232);
            this.dataGridView_DanhSachDoiBong.Name = "dataGridView_DanhSachDoiBong";
            this.dataGridView_DanhSachDoiBong.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DanhSachDoiBong.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_DanhSachDoiBong.Size = new System.Drawing.Size(545, 150);
            this.dataGridView_DanhSachDoiBong.TabIndex = 11;
            this.dataGridView_DanhSachDoiBong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DanhSachDoiBong_CellClick);
            this.dataGridView_DanhSachDoiBong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // button_CT
            // 
            this.button_CT.BackColor = System.Drawing.Color.Silver;
            this.button_CT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_CT.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_CT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CT.Image = global::Football_Manager.Properties.Resources.Soccerball30x29GIF;
            this.button_CT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CT.Location = new System.Drawing.Point(583, 70);
            this.button_CT.Name = "button_CT";
            this.button_CT.Size = new System.Drawing.Size(151, 49);
            this.button_CT.TabIndex = 20;
            this.button_CT.Text = "Thêm DS cầu thủ";
            this.button_CT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CT.UseVisualStyleBackColor = false;
            this.button_CT.Click += new System.EventHandler(this.button_CT_Click);
            // 
            // button_HLV
            // 
            this.button_HLV.BackColor = System.Drawing.Color.Silver;
            this.button_HLV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_HLV.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_HLV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HLV.Image = global::Football_Manager.Properties.Resources._1;
            this.button_HLV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_HLV.Location = new System.Drawing.Point(583, 12);
            this.button_HLV.Name = "button_HLV";
            this.button_HLV.Size = new System.Drawing.Size(151, 45);
            this.button_HLV.TabIndex = 19;
            this.button_HLV.Text = "Thêm HLV";
            this.button_HLV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_HLV.UseVisualStyleBackColor = false;
            this.button_HLV.Click += new System.EventHandler(this.button_HLV_Click);
            // 
            // button_Luu
            // 
            this.button_Luu.BackColor = System.Drawing.Color.Silver;
            this.button_Luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Luu.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Luu.Image = global::Football_Manager.Properties.Resources.button_ok;
            this.button_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Luu.Location = new System.Drawing.Point(629, 276);
            this.button_Luu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(99, 49);
            this.button_Luu.TabIndex = 18;
            this.button_Luu.Text = "OK";
            this.button_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Luu.UseVisualStyleBackColor = false;
            this.button_Luu.Click += new System.EventHandler(this.button_Luu_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.Color.Silver;
            this.button_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Image = global::Football_Manager.Properties.Resources.exit;
            this.button_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Thoat.Location = new System.Drawing.Point(629, 339);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(90, 43);
            this.button_Thoat.TabIndex = 15;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Thoat.UseVisualStyleBackColor = false;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_ThemMoi
            // 
            this.button_ThemMoi.BackColor = System.Drawing.Color.Silver;
            this.button_ThemMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_ThemMoi.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_ThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemMoi.Image = global::Football_Manager.Properties.Resources.ADD;
            this.button_ThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ThemMoi.Location = new System.Drawing.Point(629, 129);
            this.button_ThemMoi.Name = "button_ThemMoi";
            this.button_ThemMoi.Size = new System.Drawing.Size(90, 35);
            this.button_ThemMoi.TabIndex = 14;
            this.button_ThemMoi.Text = "Thêm";
            this.button_ThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThemMoi.UseVisualStyleBackColor = false;
            this.button_ThemMoi.Click += new System.EventHandler(this.button_ThemMoi_Click);
            // 
            // Button_Xoa
            // 
            this.Button_Xoa.BackColor = System.Drawing.Color.Silver;
            this.Button_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Xoa.Image = global::Football_Manager.Properties.Resources.Recycle_Bin_Empty;
            this.Button_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Xoa.Location = new System.Drawing.Point(629, 232);
            this.Button_Xoa.Name = "Button_Xoa";
            this.Button_Xoa.Size = new System.Drawing.Size(90, 38);
            this.Button_Xoa.TabIndex = 13;
            this.Button_Xoa.Text = "Xóa";
            this.Button_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Xoa.UseVisualStyleBackColor = false;
            this.Button_Xoa.Click += new System.EventHandler(this.Button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.Color.Silver;
            this.button_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Sua.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Image = global::Football_Manager.Properties.Resources.text;
            this.button_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Sua.Location = new System.Drawing.Point(629, 179);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(90, 38);
            this.button_Sua.TabIndex = 12;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // frmtiepnhanhosodoibong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 419);
            this.Controls.Add(this.button_CT);
            this.Controls.Add(this.button_HLV);
            this.Controls.Add(this.button_Luu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_ThemMoi);
            this.Controls.Add(this.Button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.dataGridView_DanhSachDoiBong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmtiepnhanhosodoibong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận hồ sơ đội bóng";
            this.Load += new System.EventHandler(this.frmtiepnhanhosodoibong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachDoiBong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenDoi;
        private System.Windows.Forms.TextBox textBox_NhaTaiTro;
        private System.Windows.Forms.TextBox textBox_SanNha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Xoa;
        public System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_ThemMoi;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.DataGridView dataGridView_DanhSachDoiBong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_HLV;
        private System.Windows.Forms.Button button_CT;
    }
}