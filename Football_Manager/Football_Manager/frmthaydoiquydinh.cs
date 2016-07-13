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
    public partial class frmthaydoiquydinh : Form
    {
        public frmthaydoiquydinh()
        {
            InitializeComponent();
        }
        int tuoith=0, tuoitd=0;
        int toida=0,toith=0, ngoaitoida=0;
        int vong=0;
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public void Loadthamso()
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select Scauthu_ToiDa from thamso";
            SqlCommand cmd = new SqlCommand(query, SQL);
            toida = (int)cmd.ExecuteScalar();
            query = "Select Tuoi_ToiDa from thamso";
            cmd = new SqlCommand(query, SQL);
            tuoitd = (int)cmd.ExecuteScalar();
            query = "Select Tuoi_ToiThieu from thamso";
            cmd = new SqlCommand(query, SQL);
            tuoith = (int)cmd.ExecuteScalar();
            query = "Select SoCTngoai from thamso";
            cmd = new SqlCommand(query, SQL);
            ngoaitoida = (int)cmd.ExecuteScalar();
            query = "Select Vong from thamso";
            cmd = new SqlCommand(query, SQL);
            vong = (int)cmd.ExecuteScalar();
            query = "Select Scauthu_ToiThieu from thamso";
            cmd = new SqlCommand(query, SQL);
            toith = (int)cmd.ExecuteScalar();
            SQL.Close();
        }
        private void frmthaydoiquydinh_Load(object sender, EventArgs e)
        {
            Loadthamso();
            textBox_tuoi1.Text = tuoith.ToString();
            textBox_tuoi2.Text = tuoitd.ToString();
            textBox_sct2.Text = toida.ToString();
            textBox_sct1.Text = toith.ToString();
            textBox_v.Text = vong.ToString();
            textBox_n.Text = ngoaitoida.ToString() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="Thây đổi")
            {
                groupBox1.Enabled = true;
                button1.Text = "Lưu";
            }
            else
            {
               SqlConnection SQL = new SqlConnection(Sc);
               SQL.Open();
               tuoith= Convert.ToInt32(textBox_tuoi1.Text);
               tuoitd = Convert.ToInt32( textBox_tuoi2.Text);
               toida= Convert.ToInt32( textBox_sct2.Text );
               toith= Convert.ToInt32( textBox_sct1.Text );
               vong= Convert.ToInt32( textBox_v.Text) ;
               ngoaitoida = Convert.ToInt32(textBox_n.Text);
               string updateStr = "Update ThamSo set Tuoi_ToiThieu=" + tuoith + ",Tuoi_ToiDa=" + tuoitd + ",Scauthu_ToiDa=" + toida + ",Scauthu_ToiThieu=" + toith + ",vong=" + vong + ",SoCTngoai=" + ngoaitoida + "";
               SqlCommand updateCmd = new SqlCommand(updateStr, SQL);
               updateCmd.CommandType = CommandType.Text;
               updateCmd.ExecuteNonQuery();
               button1.Text = "Thây đổi";
               MessageBox.Show("Thây đổi thành công");
               groupBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
