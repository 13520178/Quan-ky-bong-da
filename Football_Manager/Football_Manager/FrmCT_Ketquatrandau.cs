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
    public partial class FrmCT_Ketquatrandau : Form
    {
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        string madoi1, madoi2,muagiai,makq,vong;
        int i=0;
        public FrmCT_Ketquatrandau()
        {
            InitializeComponent();
        }
        public void get(string s1,string s2,string s3,string s4,string s5)
        {
            madoi1 = s1;
            madoi2 = s2;
            muagiai = s3;
            makq = s4;
            vong = s5;
        }
        int count()
        {
            int j = 0;
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select COUNT(*) AS SoLuong from CT_GHIBAN ";
            SqlCommand cmd = new SqlCommand(query, SQL);
            j = (int)cmd.ExecuteScalar();
            SQL.Close();
            return j;
        }
        int count(string s)
        {
            int j = 0;
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select COUNT(MaGhiBan) AS SoLuong from CT_GHIBAN Where MaDoi='"+s+"' AND MuaGiai='"+muagiai+"'";
            SqlCommand cmd = new SqlCommand(query, SQL);
            j = (int)cmd.ExecuteScalar();
            SQL.Close();
            return j;
        }
        public void loaddatabase()
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaGHIBAN,CAUTHU.HoTen,DOIBONG.TenDoi,ThoiDiem,LoaiBT from CAUTHU,DOIBONG,CT_GHIBAN Where CAUTHU.MaCT=CT_GHIBAN.MaCT AND DOIBONG.MaDoi=CT_GHIBAN.MaDoi AND CT_GHIBAN.MuaGiai='" + muagiai + "'AND (CT_GHIBAN.MaDoi='" + madoi1 + "' OR CT_GHIBAN.MaDoi='"+ madoi2 +"')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "GHIBAN");
            dataGridView1.DataSource = ds.Tables["GHIBAN"];
            SQL.Close();
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            if (button_Them.Text == "Thêm")
            {
                groupBox3.Enabled = true;
                button_Sua.Enabled = false;
                button_Xoa.Enabled = false;
                button_Luu.Enabled = false;
                button_Them.Text = "Lưu";
            }
            else
            {
                string s1, s3, s4, s5, s6, s7 = "", s8;
                s1 = muagiai;
                s3 = makq;
                s4 = comboBox_MaCT.Text;
                if (radioButton_Doi1.Checked == true)
                {
                    s5 = madoi1;
                }
                else
                {
                    s5 = madoi2;
                }
                s6 = comboBox_TD.Text;
                s7 = comboBox_LoaiBanThang.Text;
                i = count();
                s8 = "GB" + string.Format("{0:00}", i);
                try
                {
                    SqlConnection SQL = new SqlConnection(Sc);
                    SQL.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SQL;
                    cmd.CommandText = String.Format("Insert into CT_GHIBAN values ('" + s3 + "','" + s4 + "','" + s5 + "','" + s6 + "','" + s7 + "','" + s8 + "','" + s1 + "');");
                    int n = cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu thành công");
                    loaddatabase();
                    SQL.Close();
                    groupBox3.Enabled = false;
                    button_Sua.Enabled = true;
                    button_Xoa.Enabled = true;
                    button_Luu.Enabled = true;
                    button_Them.Text = "Thêm";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButton_Doi1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_MaCT.Text = "";
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaCT from CAUTHU Where MaDoi='" + madoi1 + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "MACT");
            comboBox_MaCT.DataSource = ds.Tables["MACT"];
            comboBox_MaCT.DisplayMember = "MaCT";
            SQL.Close();
        }

        private void radioButton_Doi2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_MaCT.Text = "";
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaCT from CAUTHU Where MaDoi='" + madoi2 + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "MACT");
            comboBox_MaCT.DataSource = ds.Tables["MACT"];
            comboBox_MaCT.DisplayMember = "MaCT";
            SQL.Close();
        }

        private void comboBox_MaCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string MaCT = comboBox_MaCT.Text;
            string query = "Select HoTen from CAUTHU Where MaCT='" + MaCT + "'";
            SqlCommand cmd = new SqlCommand(query, SQL);
            textBox9.Text = cmd.ExecuteScalar().ToString();
            SQL.Close();
        }

        private void FrmCT_Ketquatrandau_Load(object sender, EventArgs e)
        {
            loaddatabase();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (button_Sua.Text == "Sửa")
            {
                groupBox3.Enabled = true;
                button_Them.Enabled = false;
                button_Xoa.Enabled = false;
                button_Luu.Enabled = false;
                button_Sua.Text = "Lưu";
            }
            else if (button_Sua.Text == "Lưu")
            {
                try
                {
                    SqlConnection SQL = new SqlConnection(Sc);
                    SQL.Open();
                    int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
                    string MaGB = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[0].Value.ToString());
                    string s1, s2, s3, s4;
                    s1 = comboBox_MaCT.Text;
                    s2 = comboBox_LoaiBanThang.Text;
                    s3 = comboBox_TD.Text;
                    if (radioButton_Doi1.Checked == true)
                    {
                        s4 = madoi1;
                    }
                    else
                    {
                        s4 = madoi2;
                    }
                    string updateStr = "Update CT_GHIBAN set MaCT='" + s1 + "',MaDoi='" + s4 + "',ThoiDiem='" + s3 + "',LoaiBT='" + s2 + "' where MaGhiBan='" + MaGB + "'";
                    SqlCommand updateCmd = new SqlCommand(updateStr, SQL);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();
                    loaddatabase();
                    MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    SQL.Close();
                    button_Sua.Text = "Sửa";
                    groupBox3.Enabled = false;
                    button_Them.Enabled = true;
                    button_Xoa.Enabled = true;
                    button_Luu.Enabled = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                    string MaGB = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[0].Value.ToString());
                    string deletedStr = "Delete from CT_GHIBAN where MaGhiBan='" + MaGB + "'";
                    SqlCommand deletedCmd = new SqlCommand(deletedStr, SQL);
                    deletedCmd.CommandType = CommandType.Text;
                    deletedCmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    loaddatabase();
                    SQL.Close();
                }
                catch
                {

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
           DialogResult rs= MessageBox.Show("Bạn đã nhập xong kết quả cho trận này", "Thông Báo", MessageBoxButtons.YesNo);
            if(rs==DialogResult.Yes)
            {
                try
                {
                    SqlConnection SQL = new SqlConnection(Sc);
                    SQL.Open();
                    int BTdoi1 = count(madoi1);
                    int Btdoi2 = count(madoi2);
                    int hieuso;
                    string updateStr1="";
                    string updateStr2="";
                    if( BTdoi1>Btdoi2)
                    {
                        hieuso = BTdoi1 - Btdoi2;
                         updateStr1 = "Update XepHang set Thang=(Thang+" + 1 + "),Hieuso=(Hieuso+" + hieuso + "),Diem=(Diem+" + 3 + ") where MaDoi='" + madoi1 + "' AND vong="+vong+" AND MuaGiai='"+muagiai+"'";
                         updateStr2 = "Update XepHang set Thua=(Thua+" + 1 + "),Hieuso=(Hieuso-"+  hieuso + ") where MaDoi='" + madoi2 + "' AND vong=" + vong + " AND MuaGiai='" + muagiai + "'";
                  
                    }
                    else if (BTdoi1 < Btdoi2)
                    {
                        hieuso =   Btdoi2-BTdoi1;
                         updateStr2 = "Update XepHang set Thang=(Thang+" + 1 + "),Hieuso=(Hieuso+" + hieuso + "),Diem=(Diem+" + 3 + ") where MaDoi='" + madoi2 + "' AND vong=" + vong + " AND MuaGiai='" + muagiai + "'";
                         updateStr1 = "Update XepHang set Thua=(Thua+" + 1 + "),Hieuso=(Hieuso-" + hieuso + ") where MaDoi='" + madoi1 + "' AND vong=" + vong + " AND MuaGiai='" + muagiai + "'";

                    }
                    else if (BTdoi1 == Btdoi2)
                    {
                        hieuso = 0;
                        updateStr1 = "Update XepHang set Hoa=(Hoa+" + 1 + "),Hieuso=(Hieuso+" + hieuso + "),Diem=(Diem+" + 1 + ") where MaDoi='" + madoi1 + "' AND vong=" + vong + " AND MuaGiai='" + muagiai + "'";
                        updateStr2 = "Update XepHang set Hoa=(Hoa+" + 1 + "),Hieuso=(Hieuso-" + hieuso + "),Diem=(Diem+" + 1 + ") where MaDoi='" + madoi2 + "' AND vong=" + vong + " AND MuaGiai='" + muagiai + "'";

                    }
                    SqlCommand updateCmd = new SqlCommand(updateStr1, SQL);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();
                    updateCmd = new SqlCommand(updateStr2, SQL);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();
                    SQL.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }

        }
    }
}
