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
    public partial class FrmXepHang : Form
    {
        public FrmXepHang()
        {
            InitializeComponent();
        }
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void loaddatabase()
        {
            try
            {
                SqlConnection SQL = new SqlConnection(Sc);
                SQL.Open();
                string query = "Select TenDoi,Thang,Hoa,Thua ,HieuSo,Diem from XepHang,DOIBONG Where XepHang.MuaGiai='" + comboBox_MuaGiai.Text + "' AND vong='" + comboBox_Vong.Text + "' AND XepHang.MaDoi=DOIBONG.MaDoi ORDER BY Diem DESC";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQL;
                SqlDataAdapter da = new SqlDataAdapter(query, SQL);
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "XepHang");
                dataGridView1.DataSource = ds.Tables["XepHang"];
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    dataGridView1.Rows[j].Cells[0].Value = j + 1;
                }
                SQL.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmXepHang_Load(object sender, EventArgs e)
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
            comboBox_Vong.Text = "1";
            for (int i = 1; i <= vong; i++)
            {
                comboBox_Vong.Items.Add(i);
            }
            SQL.Close();
            loaddatabase();
        }

        private void comboBox_Vong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddatabase();
        }

        private void comboBox_MuaGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddatabase();
        }
    }
}
