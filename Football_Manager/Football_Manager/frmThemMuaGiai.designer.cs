namespace Football_Manager
{
    partial class frmThemMuaGiai
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nam1 = new System.Windows.Forms.TextBox();
            this.textBox_Nam2 = new System.Windows.Forms.TextBox();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_Luu = new System.Windows.Forms.Button();
            this.dataGridView_DSMuaGiai = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSMuaGiai)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "---";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Nam1
            // 
            this.textBox_Nam1.Location = new System.Drawing.Point(84, 52);
            this.textBox_Nam1.Name = "textBox_Nam1";
            this.textBox_Nam1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nam1.TabIndex = 2;
            this.textBox_Nam1.TextChanged += new System.EventHandler(this.textBox_Nam1_TextChanged);
            this.textBox_Nam1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nam2_KeyPress);
            // 
            // textBox_Nam2
            // 
            this.textBox_Nam2.Location = new System.Drawing.Point(230, 53);
            this.textBox_Nam2.Name = "textBox_Nam2";
            this.textBox_Nam2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nam2.TabIndex = 3;
            this.textBox_Nam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nam2_KeyPress);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Image = global::Football_Manager.Properties.Resources.exit;
            this.button_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Thoat.Location = new System.Drawing.Point(343, 273);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(73, 36);
            this.button_Thoat.TabIndex = 5;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_Luu
            // 
            this.button_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Luu.Image = global::Football_Manager.Properties.Resources.button_ok;
            this.button_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Luu.Location = new System.Drawing.Point(101, 273);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(107, 36);
            this.button_Luu.TabIndex = 4;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Luu.UseVisualStyleBackColor = true;
            this.button_Luu.Click += new System.EventHandler(this.button_Luu_Click);
            // 
            // dataGridView_DSMuaGiai
            // 
            this.dataGridView_DSMuaGiai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSMuaGiai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dataGridView_DSMuaGiai.Location = new System.Drawing.Point(84, 100);
            this.dataGridView_DSMuaGiai.Name = "dataGridView_DSMuaGiai";
            this.dataGridView_DSMuaGiai.ReadOnly = true;
            this.dataGridView_DSMuaGiai.Size = new System.Drawing.Size(246, 150);
            this.dataGridView_DSMuaGiai.TabIndex = 6;
            this.dataGridView_DSMuaGiai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DSMuaGiai_CellContentClick);
            this.dataGridView_DSMuaGiai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_DSMuaGiai_KeyPress);
            this.dataGridView_DSMuaGiai.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_DSMuaGiai_MouseClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "Stt";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách mùa giải";
            // 
            // button_Xoa
            // 
            this.button_Xoa.Image = global::Football_Manager.Properties.Resources.Recycle_Bin_Empty;
            this.button_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Xoa.Location = new System.Drawing.Point(248, 273);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(82, 36);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập Mùa Giải Mới";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "Thây đổi quy định mùa giải";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmThemMuaGiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 339);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_DSMuaGiai);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Luu);
            this.Controls.Add(this.textBox_Nam2);
            this.Controls.Add(this.textBox_Nam1);
            this.Controls.Add(this.label2);
            this.Name = "frmThemMuaGiai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Mủa Giải Mới";
            this.Load += new System.EventHandler(this.frmThemMuaGiai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSMuaGiai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nam1;
        private System.Windows.Forms.TextBox textBox_Nam2;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.DataGridView dataGridView_DSMuaGiai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}