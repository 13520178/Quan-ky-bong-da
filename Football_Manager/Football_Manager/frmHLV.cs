using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Football_Manager
{
    public partial class frmHLV : Form
    {
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public frmHLV()
        {
            InitializeComponent();
        }
        string muagiai = "";
        public void getmuagiai(string s)
        {
            muagiai = s;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmHLV_Load(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MuaGiai from muagiai";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "MuaGiai");
            comboBox1.DataSource = ds.Tables["MuaGiai"];
            comboBox1.DisplayMember = "MuaGiai";
            comboBox1.Text = muagiai;
            SQL.Close();
            groupBox1.Enabled = false;
            loaddatabase();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaHLV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_TenHLV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_QuocTich.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        int count()
        {
            int j = 0;
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string madoi = comboBox_MaDoi.Text;
            string query = "Select COUNT(MaHLV) AS SoLuong from HLV Where MaDoi='" + madoi + "'";
            SqlCommand cmd = new SqlCommand(query, SQL);
            j = (int)cmd.ExecuteScalar();
            SQL.Close();
            return j;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Thêm")
            {
                textBox_MaHLV.Text = "";
                string s1 = "";
                string s2, s3;
                s2 = comboBox_MaDoi.Text;
                int j = 2;
                if (count() ==1)
                {
                    MessageBox.Show("Đội bóng đã có HLV", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    comboBox_MaDoi.Enabled = false;
                    button_Luu.Enabled = false;
                    button_Sua.Enabled = false;
                    button_Xoa.Enabled = false;
                    groupBox1.Enabled = true;
                    button3.Text = "Lưu";
                    textBox_MaHLV.Text = "";
                    textBox_TenHLV.Text = "";
                    s2 = comboBox_MaDoi.Text;
                    while (s2[j] != ' ')
                    {
                        s1 += s2[j];
                        j++;
                    }    
                    s3=s1+"HLV";
                   textBox_MaHLV.Text=s3;
                }

            }
            else if (button3.Text == "Lưu")
            {

                if (textBox_TenHLV.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên HLV");
                }
                else
                {
                    string s1, s2, s3, s4, s5,s6;
                    s2 = comboBox_MaDoi.Text;
                    s1 = textBox_MaHLV.Text;
                    s3 = frmtiepnhanhosodoibong.Mahoa(textBox_TenHLV);
                    s4 = dateTimePicker1.Value.ToString();
                    s5 = textBox_QuocTich.Text;
                    s6 = comboBox1.Text;
                    //int ns = int.Parse(dateTimePicker1.Value.Year.ToString());
                    //DateTime d = DateTime.Now;
                    //int nn = int.Parse(d.Year.ToString());
                    if (kiemtra(s3) == 0)
                    {
                        MessageBox.Show("Tên HLV không có số", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            string Sc = @"Data Source=TRUONG\SQLEXPRESS;Initial Catalog=QL_BD;Integrated Security=True";
                            SqlConnection SQL = new SqlConnection(Sc);
                            SQL.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = SQL;
                            cmd.CommandText = String.Format("Insert into HLV values (N'" + s2 + "',N'" + s1 + "',N'" + s4 + "',N'" + s3 + "',N'" + s5 + "','"+s6+"');");
                            int n = cmd.ExecuteNonQuery();
                            MessageBox.Show("Lưu thành công");
                            loaddatabase();
                            SQL.Close();
                            button3.Text = "Thêm";
                            button_Luu.Enabled = true;
                            button_Sua.Enabled = true;
                            button_Xoa.Enabled = true;
                            groupBox1.Enabled = false;
                            comboBox_MaDoi.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            
        }
        public static int kiemtra(string s)
        {
            int i = 1;
            for (int j = 0; j < s.Length; j++)
            {
                if (char.IsNumber(s[j]))
                    i = 0;
            }
            return i;
        }
        public void loaddatabase()
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaHLV,HoTen,convert(varchar, NgaySinh, 103) AS NgaySinh,QuocTich,TenDoi,HLV.MuaGiai from HLV,DOIBONG Where HLV.MaDoi=DOIBONG.MaDoi AND HLV.MuaGiai='"+comboBox1.Text+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "HLV");
            dataGridView1.DataSource = ds.Tables["HLV"];
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            SQL.Close();
        }

        private void comboBox_MaDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection SQL = new SqlConnection(Sc);
                SQL.Open();
                string madoi = comboBox_MaDoi.Text;
                string query = "Select MaHLV,HoTen,convert(varchar, NgaySinh, 103) AS NgaySinh,QuocTich,TenDoi,HLV.MuaGiai from HLV,DOIBONG Where HLV.MaDoi=DOIBONG.MaDoi AND HLV.MaDoi='" + madoi + "'AND HLV.MuaGiai='"+comboBox1.Text+"'";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQL;
                SqlDataAdapter da = new SqlDataAdapter(query, SQL);
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "HLV");
                dataGridView1.DataSource = ds.Tables["HLV"];
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
                SQL.Close();
            }
            catch
            { }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection SQL = new SqlConnection(Sc);
                    SQL.Open();
                    int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
                    string MaHLV = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[1].Value.ToString());
                    string MuaGiai = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[6].Value.ToString());
                    string deletedStr = "Delete from HLV where MaHLV='" + MaHLV + "' AND MuaGiai='" + MuaGiai + "'";
                    SqlCommand deletedCmd = new SqlCommand(deletedStr, SQL);
                    deletedCmd.CommandType = CommandType.Text;
                    deletedCmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    loaddatabase();
                    SQL.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (button_Sua.Text == "Sửa")
            {
                button3.Enabled = false;
                button_Luu.Enabled = true;
                button_Sua.Text = "Lưu";
                button_Xoa.Enabled = false;
                groupBox1.Enabled = true;
                comboBox_MaDoi.Enabled = false;
            }
            else if (button_Sua.Text == "Lưu")
            {
                if (textBox_TenHLV.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên HLV");
                }
                else
                {
                    try
                    {
                        SqlConnection SQL = new SqlConnection(Sc);
                        SQL.Open();
                        int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
                        string MaHLV = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[1].Value.ToString());
                        string TenHLV = textBox_TenHLV.Text;
                        string NS = dateTimePicker1.Value.ToString();
                        string MuaGiai = comboBox1.Text;
                        int ns = int.Parse(dateTimePicker1.Value.Year.ToString());
                        DateTime d = DateTime.Now;
                        int nn = int.Parse(d.Year.ToString());
                        if (kiemtra(TenHLV) == 0)
                        {
                            MessageBox.Show("Tên cầu thủ không có số", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string QuocTich = textBox_QuocTich.Text;
                            string updateStr = "Update HLV set MaHLV='" + MaHLV + "',HoTen=N'" + TenHLV + "',NgaySinh='" + NS + "',QuocTich='" + QuocTich + "',MuaGiai='"+MuaGiai+"' where MaHLV='" + MaHLV + "'";
                            SqlCommand updateCmd = new SqlCommand(updateStr, SQL);
                            updateCmd.CommandType = CommandType.Text;
                            updateCmd.ExecuteNonQuery();
                            loaddatabase();
                            MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                            SQL.Close();
                            button_Luu.Enabled = true;
                            button_Sua.Enabled = true;
                            button_Xoa.Enabled = true;
                            button_Sua.Text = "Sửa";
                            groupBox1.Enabled = false;
                            comboBox_MaDoi.Enabled = true;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Text = "Thêm";
            button3.Enabled = true;
            button_Luu.Enabled = true;
            button_Sua.Enabled = true;
            button_Xoa.Enabled = true;
            button_Sua.Text = "Sửa";
            groupBox1.Enabled = false;
            comboBox_MaDoi.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaDoi from DOIBONG";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "MADOI");
            comboBox_MaDoi.DataSource = ds.Tables["MADOI"];
            comboBox_MaDoi.DisplayMember = "MaDoi";
            SQL.Close();
            groupBox1.Enabled = false;
            loaddatabase();
        }
    }
}
