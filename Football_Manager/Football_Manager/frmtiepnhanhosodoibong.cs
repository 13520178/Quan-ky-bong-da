using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Football_Manager
{
    public partial class frmtiepnhanhosodoibong : Form
    {
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
       
        public frmtiepnhanhosodoibong()
        {
            InitializeComponent();
        }
        string muagiai = "";
        public void getmuagiai(string s)
        {
            muagiai = s;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button_ThemMoi_Click(object sender, EventArgs e)
        {
            if (button_ThemMoi.Text == "Thêm")
            {
                groupBox1.Enabled = true;
                button_Sua.Enabled = false;
                Button_Xoa.Enabled = false;
                button_Luu.Enabled = false;
                button_ThemMoi.Text = "Lưu";
            }
            else 
            {
                string TD = textBox_TenDoi.Text;
                string madoi = "MD";
                for (int i = 0; i < TD.Length; i++)
                {
                    if (i == 0)
                    {
                        madoi += char.ToUpper(TD[i]);
                    }
                    else if (TD[i - 1] == ' ')
                    {
                        madoi += char.ToUpper(TD[i]);
                    }
                }
                string s1, s2, s3, s4,s5;
                s1 = madoi;
                s2 = Mahoa(textBox_SanNha);
                s3 = Mahoa(textBox_TenDoi);
                s4 = Mahoa(textBox_NhaTaiTro);
                s5 = muagiai;
                if (kiemtra(s3) == 0)
                {
                    MessageBox.Show("Tên đôi phải có chữ ,Ký tự đầu tiên phải là chữ ,chữ và số phải cách nhau 1 khoảng trắng");
                }
                else
                {
                    try
                    {
                        SqlConnection SQL = new SqlConnection(Sc);
                        SQL.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = SQL;
                        cmd.CommandText = String.Format("Insert into DOIBONG values (N'" + s1 + "',N'" + s2 + "',N'" + s3 + "',N'" + s4 + "','"+s5+"');");
                        int n = cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thành công");
                        loaddatabase();
                        SQL.Close();
                        textBox_TenDoi.Text = "";
                        textBox_SanNha.Text = "";
                        textBox_NhaTaiTro.Text = "";
                        groupBox1.Enabled = false;
                        button_Sua.Enabled = true;
                        Button_Xoa.Enabled = true;
                        button_Luu.Enabled = true;
                        button_ThemMoi.Text = "Thêm";
                    }
                    catch 
                    {
                        MessageBox.Show("Lưu không thành công,Tên đội đã tồn tại ");
                    }
                }
            }
        }

        private void dataGridView_DanhSachDoiBong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_TenDoi.Text = dataGridView_DanhSachDoiBong.CurrentRow.Cells[3].Value.ToString();

            textBox_SanNha.Text = dataGridView_DanhSachDoiBong.CurrentRow.Cells[2].Value.ToString();


            textBox_NhaTaiTro.Text = dataGridView_DanhSachDoiBong.CurrentRow.Cells[4].Value.ToString();
        }

        private void frmtiepnhanhosodoibong_Load(object sender, EventArgs e)
        {
            loaddatabase();
            groupBox1.Enabled = false;
     
        }
        public void loaddatabase()
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select * from DOIBONG Where MuaGiai='"+muagiai+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "DOIBONG");
            dataGridView_DanhSachDoiBong.DataSource = ds.Tables["DOIBONG"];
            for (int j = 0; j < dataGridView_DanhSachDoiBong.Rows.Count - 1; j++)
            {
                dataGridView_DanhSachDoiBong.Rows[j].Cells[0].Value = j + 1;
            }
            SQL.Close();
        }
        public static string  Mahoa(TextBox b)
        {
            string s = b.Text;
            string mh="";
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (i == 0)
                {
                    mh += char.ToUpper(s[i]);
                }
                else if (mh[i - 1] == ' ')
                {
                     mh += char.ToUpper(s[i]);
                }
                else
                {
                    mh += s[i];
                }
            }
            return mh;
        }
        public static int kiemtra(string s)
        {
            int i=1,c=0;
            if (char.IsNumber(s[0]))
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (char.IsLetter(s[j]))
                        c = 1;
                }
                if (c != 1)
                    i = 0;
            }
            else
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (char.IsNumber(s[j]))
                        if ((j != 0 && char.IsLetter(s[j - 1])) || char.IsLetter(s[j + 1]))
                            i = 0;
                }
            return i; 
        }
        private void button_Luu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn nhập luôn lich thi đấu","Thông Báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                frmlapichthidau ll = new frmlapichthidau();
                ll.getmuagiai(muagiai);
                ll.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
                
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection SQL = new SqlConnection(Sc);
                SQL.Open();
                int CurrentIndex = dataGridView_DanhSachDoiBong.CurrentCell.RowIndex;
                string MaDoi = Convert.ToString(dataGridView_DanhSachDoiBong.Rows[CurrentIndex].Cells[1].Value.ToString());
                string deletedStr = "Delete from DOIBONG where MaDoi='" + MaDoi + "'";
                SqlCommand deletedCmd = new SqlCommand(deletedStr, SQL);
                deletedCmd.CommandType = CommandType.Text;
                deletedCmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                loaddatabase();
                SQL.Close();
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (button_Sua.Text == "Sửa")
            {
                groupBox1.Enabled = true;
                button_ThemMoi.Enabled = false;
                Button_Xoa.Enabled = false;
                button_Luu.Enabled = false;
                button_Sua.Text = "Lưu";
            }
            else if (button_Sua.Text == "Lưu")
            {
                try
                {
                    SqlConnection SQL = new SqlConnection(Sc);
                    SQL.Open();
                    int CurrentIndex = dataGridView_DanhSachDoiBong.CurrentCell.RowIndex;
                    string MaDoi = Convert.ToString(dataGridView_DanhSachDoiBong.Rows[CurrentIndex].Cells[1].Value.ToString());
                    string San = textBox_SanNha.Text;
                    string TenDoi = textBox_TenDoi.Text;
                    if (kiemtra(TenDoi) == 0)
                    {
                        MessageBox.Show("Tên đôi phải có chữ ,Ký tự đầu tiên phải là chữ ,chữ và số phải cách nhau 1 khoảng trắng");
                    }
                    else
                    {
                        string NhaTaiTro = textBox_NhaTaiTro.Text;
                        string updateStr = "Update DOIBONG set Madoi='" + MaDoi + "',San='" + San + "',TenDoi=N'" + TenDoi + "',NhaTaiTro=N'" + NhaTaiTro + "' where MaDoi='" + MaDoi + "'";
                        SqlCommand updateCmd = new SqlCommand(updateStr, SQL);
                        updateCmd.CommandType = CommandType.Text;
                        updateCmd.ExecuteNonQuery();
                        loaddatabase();
                        MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        SQL.Close();
                        button_Sua.Text = "Sửa";
                        groupBox1.Enabled = false;
                        button_ThemMoi.Enabled = true;
                        Button_Xoa.Enabled = true;
                        button_Luu.Enabled = true;
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button_ThemMoi.Text = "Thêm";
            button_ThemMoi.Enabled = true;
            button_Luu.Enabled = true;
            button_Sua.Enabled = true;
            Button_Xoa.Enabled = true;
            button_Sua.Text = "Sửa";
            groupBox1.Enabled = false;
        }

        private void button_HLV_Click(object sender, EventArgs e)
        {
            frmHLV HLV = new frmHLV();
            HLV.getmuagiai(muagiai);
            HLV.Show();
        }

        private void button_CT_Click(object sender, EventArgs e)
        {
            frmcauthu CauThu = new frmcauthu();
            CauThu.getmuagiai(muagiai);
            CauThu.Show();
        }
    }
}
