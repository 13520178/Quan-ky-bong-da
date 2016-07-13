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
    public partial class frmketquathidau : Form
    {
        string madoi1, madoi2;
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public frmketquathidau()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmketquathidau_Load(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MuaGiai from muagiai";
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "MuaGiai");
            comboBox_MuaGiai.DataSource = ds.Tables["MuaGiai"];
            comboBox_MuaGiai.DisplayMember = "MuaGiai";
            query = "Select vong from ThamSo";
            SqlCommand cmd = new SqlCommand(query, SQL);
            int vong = (int)cmd.ExecuteScalar();
            for (int i = 1; i <= vong; i++)
            {
                comboBox1.Items.Add(i);
            }
            SQL.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string s1, s2, s3;
                s1 = comboBox_MuaGiai.Text;
                s2 = comboBox_MaThiDau.Text;
                s3 = "KQ" + s2;
                try
                {
                    SqlConnection SQL = new SqlConnection(Sc);
                    SQL.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SQL;
                    cmd.CommandText = String.Format("Insert into KETQUATHIDAU values ('" + s2 + "','" + s1 + "','" + s3 + "');");
                    int n = cmd.ExecuteNonQuery();
                    FrmCT_Ketquatrandau Ct = new FrmCT_Ketquatrandau();
                    Ct.get(madoi1,madoi2,s1,s3,comboBox1.Text);
                    Ct.Show();
                    try
                    {
                        cmd.CommandText = String.Format("Insert into XepHang values ('" + s1 + "','" + comboBox1.Text + "','" + madoi1 + "',0,0,0,0,0);");
                        cmd.ExecuteNonQuery();
                    }
                    catch { }
                    try
                    {                
                        cmd.CommandText = String.Format("Insert into XepHang values ('" + s1 + "','" + comboBox1.Text + "','" + madoi2 + "',0,0,0,0,0);");
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    { }
                }
                catch 
                {
                    MessageBox.Show("Bạn đã nhập kết quả cho trận này rùi");
                }
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
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_MaThiDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection SQL = new SqlConnection(Sc);
                SQL.Open();
                string MaLTD = comboBox_MaThiDau.Text;
                string query = "Select MaDoi1 from LICHTHIDAU Where MaLTD='" + MaLTD + "'";
                SqlCommand cmd = new SqlCommand(query, SQL);
                madoi1 = cmd.ExecuteScalar().ToString();
                query = "Select TenDoi from DOIBONG Where MaDoi='" + madoi1 + "'";
                cmd = new SqlCommand(query, SQL);
                textBox_TenDoi1.Text = cmd.ExecuteScalar().ToString();
                query = "Select MaDoi2 from LICHTHIDAU Where MaLTD='" + MaLTD + "'";
                cmd = new SqlCommand(query, SQL);
                 madoi2 = cmd.ExecuteScalar().ToString();
                query = "Select TenDoi from DOIBONG Where MaDoi='" + madoi2 + "'";
                cmd = new SqlCommand(query, SQL);
                textBox_TenDoi2.Text = cmd.ExecuteScalar().ToString();
                query = "Select ThoiGian from LICHTHIDAU Where MaLTD='" + MaLTD + "'";
                cmd = new SqlCommand(query, SQL);
                dateTimePicker1.Text = cmd.ExecuteScalar().ToString();
                query = "Select San from LICHTHIDAU Where MaLTD='" + MaLTD + "'";
                cmd = new SqlCommand(query, SQL);
                textBox_San.Text=cmd.ExecuteScalar().ToString();
                SQL.Close();

            }
            catch 
            {
            }
        }

        private void comboBox_MuaGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_MaThiDau.Text = "";
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaLTD from LICHTHIDAU WHERE MuaGiai='" + comboBox_MuaGiai.Text + "'AND Vong='" + comboBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "MaLTD");
            comboBox_MaThiDau.DataSource = ds.Tables["MaLTD"];
            comboBox_MaThiDau.DisplayMember = "MaLTD";

            SQL.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_MaThiDau.Text = "";
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaLTD from LICHTHIDAU WHERE MuaGiai='" + comboBox_MuaGiai.Text + "'AND Vong='" + comboBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "MaLTD");
            comboBox_MaThiDau.DataSource = ds.Tables["MaLTD"];
            comboBox_MaThiDau.DisplayMember = "MaLTD";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
