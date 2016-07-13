namespace Football_Manager
{
    partial class frmlapichthidau
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
            this.textBox_San = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.comboBox_MaDoi1 = new System.Windows.Forms.ComboBox();
            this.comboBox_MaDoi2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Vòng = new System.Windows.Forms.ComboBox();
            this.comboBox_MuaGiai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vòng ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đội nhà";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã đội khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sân";
            // 
            // textBox_San
            // 
            this.textBox_San.Location = new System.Drawing.Point(146, 135);
            this.textBox_San.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_San.Name = "textBox_San";
            this.textBox_San.Size = new System.Drawing.Size(309, 21);
            this.textBox_San.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 174);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(389, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(479, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(471, 303);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_huy
            // 
            this.button_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huy.Location = new System.Drawing.Point(278, 75);
            this.button_huy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(100, 27);
            this.button_huy.TabIndex = 12;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Image = global::Football_Manager.Properties.Resources.exit;
            this.button_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Thoat.Location = new System.Drawing.Point(969, 289);
            this.button_Thoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(108, 48);
            this.button_Thoat.TabIndex = 16;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Image = global::Football_Manager.Properties.Resources.Recycle_Bin_Empty;
            this.button_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Xoa.Location = new System.Drawing.Point(356, 307);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(100, 40);
            this.button_Xoa.TabIndex = 15;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Image = global::Football_Manager.Properties.Resources.text;
            this.button_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Sua.Location = new System.Drawing.Point(202, 307);
            this.button_Sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(100, 39);
            this.button_Sua.TabIndex = 14;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Them
            // 
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Image = global::Football_Manager.Properties.Resources.ADD;
            this.button_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Them.Location = new System.Drawing.Point(44, 307);
            this.button_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(105, 39);
            this.button_Them.TabIndex = 13;
            this.button_Them.Text = "Thêm";
            this.button_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_MaDoi1
            // 
            this.comboBox_MaDoi1.FormattingEnabled = true;
            this.comboBox_MaDoi1.Location = new System.Drawing.Point(101, 39);
            this.comboBox_MaDoi1.Name = "comboBox_MaDoi1";
            this.comboBox_MaDoi1.Size = new System.Drawing.Size(132, 23);
            this.comboBox_MaDoi1.TabIndex = 18;
            this.comboBox_MaDoi1.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaDoi1_SelectedIndexChanged);
            // 
            // comboBox_MaDoi2
            // 
            this.comboBox_MaDoi2.FormattingEnabled = true;
            this.comboBox_MaDoi2.Location = new System.Drawing.Point(101, 79);
            this.comboBox_MaDoi2.Name = "comboBox_MaDoi2";
            this.comboBox_MaDoi2.Size = new System.Drawing.Size(132, 23);
            this.comboBox_MaDoi2.TabIndex = 19;
            // 
            // comboBox_Vòng
            // 
            this.comboBox_Vòng.FormattingEnabled = true;
            this.comboBox_Vòng.Location = new System.Drawing.Point(290, 5);
            this.comboBox_Vòng.Name = "comboBox_Vòng";
            this.comboBox_Vòng.Size = new System.Drawing.Size(132, 23);
            this.comboBox_Vòng.TabIndex = 20;
            // 
            // comboBox_MuaGiai
            // 
            this.comboBox_MuaGiai.FormattingEnabled = true;
            this.comboBox_MuaGiai.Location = new System.Drawing.Point(101, 5);
            this.comboBox_MuaGiai.Name = "comboBox_MuaGiai";
            this.comboBox_MuaGiai.Size = new System.Drawing.Size(132, 23);
            this.comboBox_MuaGiai.TabIndex = 21;
            this.comboBox_MuaGiai.SelectedIndexChanged += new System.EventHandler(this.comboBox_MuaGiai_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "MuaGiai";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox_MuaGiai);
            this.groupBox2.Controls.Add(this.comboBox_Vòng);
            this.groupBox2.Controls.Add(this.comboBox_MaDoi2);
            this.groupBox2.Controls.Add(this.comboBox_MaDoi1);
            this.groupBox2.Controls.Add(this.button_huy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(11, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 115);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // frmlapichthidau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_San);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmlapichthidau";
            this.Text = "LẬP LỊCH THI ĐẤU";
            this.Load += new System.EventHandler(this.frmlichthidau_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_San;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.ComboBox comboBox_MaDoi1;
        private System.Windows.Forms.ComboBox comboBox_MaDoi2;
        private System.Windows.Forms.ComboBox comboBox_Vòng;
        private System.Windows.Forms.ComboBox comboBox_MuaGiai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}