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
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string Pass = textBox2.Text;
            int loai = 0;
            if (comboBox2.Text == "Nhà Quản lý")
            {
                loai = 1;
            }
            else
            {
                loai = 2;
            }
            if(Pass.Length<8 ||Pass.Length>20)
            {
                MessageBox.Show("Độ dài mật khẩu từ 8 đến 20 ký tự");
            }
            else if(Pass!=textBox3.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
                textBox2.Text="";
                textBox3.Text = "";
            }
            else 
            {
                try 
                {
                    string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                    SqlConnection SQL = new SqlConnection(Sc);
                    SQL.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = SQL;
                    cmd.CommandText = String.Format("Insert into ID values ('" + ID  + "','" + Pass + "',"+loai+");");
                    int n = cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                    SQL.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
