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
    public partial class frmlapichthidau : Form
    {
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        string muagiai;
        public frmlapichthidau()
        {
            InitializeComponent();
        }
        public void getmuagiai(string s)
        {
            muagiai = s;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmlichthidau_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection SQL = new SqlConnection(Sc);
                SQL.Open();
                string query = "Select MuaGiai from muagiai";
                SqlDataAdapter da = new SqlDataAdapter(query, SQL);
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "MuaGiai");
                comboBox_MuaGiai.DataSource = ds.Tables["MuaGiai"];
                comboBox_MuaGiai.DisplayMember = "MuaGiai";
                comboBox_MuaGiai.Text = muagiai;
                loaddatabase();
                query = "Select vong from ThamSo";
                SqlCommand cmd = new SqlCommand(query, SQL);
                int vong = (int)cmd.ExecuteScalar();
                for (int i = 1; i <= vong; i++)
                {
                    comboBox_Vòng.Items.Add(i);
                }
                SQL.Close();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loaddatabase()
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MuaGiai,Vong,MaLTD ,ThoiGian,San from LICHTHIDAU ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "LichThiDau");
            dataGridView1.DataSource = ds.Tables["LichThiDau"];
            SQL.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_MaDoi1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection SQL = new SqlConnection(Sc);
                SQL.Open();
                string madoi = comboBox_MaDoi1.Text;
                string query = "Select San from DOIBONG Where MaDoi='" + madoi + "'";
                SqlCommand cmd = new SqlCommand(query, SQL);
                textBox_San.Text = cmd.ExecuteScalar().ToString();
                SQL.Close();
            }
            catch
            { 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button_Them.Text == "Thêm")
            {
                groupBox2.Enabled = true;
                button_Sua.Enabled = false;
                button_Xoa.Enabled = false;
                
                button_Them.Text = "Lưu";
            }
            else
            {
                string s1, s2, s3, s4, s5, s6, s7 = "";
                s1 = comboBox_MuaGiai.Text;
                s2 = comboBox_Vòng.Text;
                s3 = comboBox_MaDoi1.Text;
                s4 = comboBox_MaDoi2.Text;
                s5 = dateTimePicker1.Value.ToString();
                s6 = textBox_San.Text;
             
                if (kiemtra1(s1, s2, s3) == 1 )
                {
                    MessageBox.Show("Đội nhà đã có lịch đấu");
                }
                else if (kiemtra1(s1, s2, s4) == 1)
                {
                    MessageBox.Show("Đội khách đã có lịch đấu");
                }
                else
                {
                    int j = 2;
                    while (s3[j] != ' ')
                        {
                            s7 += s3[j];
                            j++;
                        }
                        s7 += "_";
                        j = 2;
                        while (s4[j] != ' ')
                        {
                            s7 += s4[j];
                            j++;
                        }

                        try
                        {
                            SqlConnection SQL = new SqlConnection(Sc);
                            SQL.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = SQL;
                            cmd.CommandText = String.Format("Insert into LICHTHIDAU values (" + s2 + ",'" + s3 + "','" + s4 + "',N'" + s6 + "','" + s5 + "','" + s7 + "','" + s1 + "');");
                            int n = cmd.ExecuteNonQuery();
                            MessageBox.Show("Lưu thành công");
                            loaddatabase();
                            SQL.Close();

                            groupBox2.Enabled = false;
                            button_Sua.Enabled = true;
                            button_Xoa.Enabled = true;
                           
                            button_Them.Text = "Thêm";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
            }
        }
        public int kiemtra1(string muagiai,string vong,string madoi)
        {
                int i = 0;
                SqlConnection SQL = new SqlConnection(Sc);
                SQL.Open();
                string query = "Select * from LICHTHIDAU Where (MaDoi1='" + madoi + "' OR Madoi2='"+madoi+"') AND Vong='"+vong+"' AND MuaGiai='"+muagiai+"'";
                SqlDataAdapter da = new SqlDataAdapter(query, SQL);
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "LichThiDau");
                if(ds.Tables["LichThiDau"].Rows.Count > 0)
                {
                    i = 1;
                }
                SQL.Close();
                return i;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_MuaGiai.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); ;
            comboBox_Vòng.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_San.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (button_Sua.Text == "Sửa")
            {
                button_Them.Enabled = false;
                button_Xoa.Enabled = false;
                button_Sua.Text = "Lưu";
            }
            else if (button_Sua.Text == "Lưu")
            {
                try
                {
                    SqlConnection SQL = new SqlConnection(Sc);
                    SQL.Open();
                    int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
                    string MaLTD = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[2].Value.ToString());
                    string s1, s2, s3, s4, s5, s6, s7 = "";
                    s1 = comboBox_MuaGiai.Text;
                    s2 = comboBox_Vòng.Text;
                    s3 = comboBox_MaDoi1.Text;
                    s4 = comboBox_MaDoi2.Text;
                    s5 = dateTimePicker1.Value.ToString();
                    s6 = textBox_San.Text;
                    int j = 2;
                    while (s3[j] != ' ')
                    {
                        s7 += s3[j];
                        j++;
                    }
                    s7 += "_";
                    j = 2;
                    while (s4[j] != ' ')
                    {
                        s7 += s4[j];
                        j++;
                    }
                    string updateStr = "Update LICHTHIDAU set MuaGiai='" + s1 + "',San=N'" + s6 + "',Vong=" + s2 + ",ThoiGian='" + s5 + "' where MaLTD='" + MaLTD + "'";
                    SqlCommand updateCmd = new SqlCommand(updateStr, SQL);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();
                    loaddatabase();
                    MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    SQL.Close();
                    button_Sua.Text = "Sửa";
                    button_Them.Enabled = true;
                    button_Xoa.Enabled = true;
                   
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
                    string MaLTD = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[2].Value.ToString());
                    string deletedStr = "Delete from LICHTHIDAU where MaLTD='" + MaLTD + "'";
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

        private void button_huy_Click(object sender, EventArgs e)
        {
            button_Them.Text = "Thêm";
            button_Them.Enabled = true;
            button_Sua.Enabled = true;
            button_Xoa.Enabled = true;
            button_Sua.Text = "Sửa";
            groupBox2.Enabled = false;
        }

        private void comboBox_MuaGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_MaDoi1.Text = "";
            comboBox_MaDoi2.Text = "";
            string Sc = @"Data Source=TRUONG\SQLEXPRESS;Initial Catalog=QL_BD;Integrated Security=True";
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaDoi from DOIBONG Where MuaGiai='" + comboBox_MuaGiai.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da = new SqlDataAdapter(query, SQL);
            ds = new System.Data.DataSet();
            da.Fill(ds, "MADOI1");
            da.Fill(ds, "MADOI2");
            comboBox_MaDoi1.DataSource = ds.Tables["MADOI1"];
            comboBox_MaDoi1.DisplayMember = "MaDoi";
            comboBox_MaDoi2.DataSource = ds.Tables["MADOi2"];
            comboBox_MaDoi2.DisplayMember = "MaDoi";
        }
    }
}
