namespace Football_Manager
{
    partial class FrmXepHang
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
            this.Hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_MuaGiai = new System.Windows.Forms.ComboBox();
            this.comboBox_Vong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hang});
            this.dataGridView1.Location = new System.Drawing.Point(4, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // Hang
            // 
            this.Hang.HeaderText = "Hạng";
            this.Hang.Name = "Hang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Xếp Hạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mùa Giải";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_MuaGiai
            // 
            this.comboBox_MuaGiai.FormattingEnabled = true;
            this.comboBox_MuaGiai.Location = new System.Drawing.Point(126, 23);
            this.comboBox_MuaGiai.Name = "comboBox_MuaGiai";
            this.comboBox_MuaGiai.Size = new System.Drawing.Size(121, 21);
            this.comboBox_MuaGiai.TabIndex = 4;
            this.comboBox_MuaGiai.SelectedIndexChanged += new System.EventHandler(this.comboBox_MuaGiai_SelectedIndexChanged);
            // 
            // comboBox_Vong
            // 
            this.comboBox_Vong.FormattingEnabled = true;
            this.comboBox_Vong.Location = new System.Drawing.Point(434, 23);
            this.comboBox_Vong.Name = "comboBox_Vong";
            this.comboBox_Vong.Size = new System.Drawing.Size(142, 21);
            this.comboBox_Vong.TabIndex = 5;
            this.comboBox_Vong.SelectedIndexChanged += new System.EventHandler(this.comboBox_Vong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vòng";
            // 
            // FrmXepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Football_Manager.Properties.Resources._1346469796393550_574_574;
            this.ClientSize = new System.Drawing.Size(762, 369);
            this.Controls.Add(this.comboBox_Vong);
            this.Controls.Add(this.comboBox_MuaGiai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmXepHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXepHang";
            this.Load += new System.EventHandler(this.FrmXepHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_MuaGiai;
        private System.Windows.Forms.ComboBox comboBox_Vong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hang;
    }
}