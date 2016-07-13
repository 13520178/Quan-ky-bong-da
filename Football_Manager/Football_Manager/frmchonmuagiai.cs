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
    public partial class frmchonmuagiai : Form
    {
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public frmchonmuagiai()
        {
            InitializeComponent();
        }

        private void frmchonmuagiai_Load(object sender, EventArgs e)
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
            SQL.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmtiepnhanhosodoibong doibong = new frmtiepnhanhosodoibong();
            doibong.getmuagiai(comboBox1.Text);
            doibong.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
