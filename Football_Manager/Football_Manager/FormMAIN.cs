using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BM_4;
using BM_52;



namespace Football_Manager
{
    public partial class FormMAIN : Form
    {
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public FormMAIN()
        {
            InitializeComponent();
        }
        int i = 0;
        public void quyen2()
        {
            simpleButton1.Visible = false;
            simpleButton2.Show();
            simpleButton_cauthughiban.Show();
            simpleButton_Tracuu.Show();
        }
        public void quyen1()
        {
            simpleButton1.Visible = true;
            simpleButton2.Show();
            simpleButton_cauthughiban.Show();
            simpleButton_Tracuu.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                simpleButton_TAOMUAGIAI.Show();
              
                simpleButton_THEMDOIBONG.Show();
                simpleButton_LTD.Show();
                simpleButton_Ketquatrandau.Show();
                simpleButton2.Hide();
                simpleButton_cauthughiban.Hide();
                simpleButton_Tracuu.Hide();
                i = 1;
            }
            else
            {
                simpleButton_TAOMUAGIAI.Visible = false;
               
                simpleButton_THEMDOIBONG.Visible=false;
              
                simpleButton_LTD.Visible=false;
                simpleButton_Ketquatrandau.Visible=false;
                simpleButton2.Show();
                simpleButton_cauthughiban.Show();
                simpleButton_Tracuu.Show();
                i = 0;

            }
        }

        private void FormMAIN_Load(object sender, EventArgs e)
        {
            simpleButton1.Visible = false;
            simpleButton_TAOMUAGIAI.Visible=false;
            simpleButton_THEMDOIBONG.Visible = false;
            
            simpleButton_LTD.Visible = false;
            simpleButton_Ketquatrandau.Visible = false;
            simpleButton2.Hide();
            simpleButton_cauthughiban.Hide();
            simpleButton_Tracuu.Hide();
           
        }

        private void simpleButton_THEMDOIBONG_Click(object sender, EventArgs e)
        {
            frmchonmuagiai c = new frmchonmuagiai();
            c.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmXepHang xh = new FrmXepHang();
            xh.Show();
        }

        private void simpleButton_Themcauthu_Click(object sender, EventArgs e)
        {
            frmcauthu ct = new frmcauthu();
            ct.Show();
        }

        private void simpleButton_Ketquatrandau_Click(object sender, EventArgs e)
        {
            frmketquathidau kq = new frmketquathidau();
            kq.Show();
        }

        private void simpleButton_TAOMUAGIAI_Click(object sender, EventArgs e)
        {
            frmThemMuaGiai mua = new frmThemMuaGiai();
            mua.Show();
        }

        private void simpleButton_LTD_Click(object sender, EventArgs e)
        {
            frmlapichthidau d = new frmlapichthidau();
            d.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                string pass = textBox2.Text;
                SqlConnection SQL = new SqlConnection(Sc);
                SQL.Open();
                string query = "Select Loai from ID Where ID='" + id + "' AND PASS='" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, SQL);
                int loai = (int)cmd.ExecuteScalar();
                if (loai == 1)
                {
                    groupBox1.Visible = false;
                    quyen1();
                    MessageBox.Show("Đăng nhập thành công \n  ", "Thông Báo");
                }
                else
                {
                    groupBox1.Visible = false;
                    quyen2();
                    MessageBox.Show("Đăng nhập thành công \n  ", "Thông Báo");
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoảng hoặc mật khẩu không đúng");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dangky f = new Dangky();
            f.Show();
        }

        private void simpleButton_Tracuu_Click(object sender, EventArgs e)
        {
            BM_4.Form4 ffr = new Form4();
            ffr.Show();
        }

        private void simpleButton_cauthughiban_Click(object sender, EventArgs e)
        {
            BM_52.Form52 f = new Form52();
            f.Show();
        }
    }
}
