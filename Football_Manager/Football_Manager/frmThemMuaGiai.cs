using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Football_Manager
{
    public partial class frmThemMuaGiai : Form
    {
        string temp1, temp2, temp;
        string sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public frmThemMuaGiai()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmThemMuaGiai_Load(object sender, EventArgs e)
        {
            button_Xoa.Enabled = false;
            LoadDatabase();
        }

        //Load database 
        public void LoadDatabase()
        {
            SqlConnection sql = new SqlConnection(sc);
            sql.Open();
            string query = "Select MuaGiai AS Mùa  from MuaGiai";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=sql;
            SqlDataAdapter sd = new SqlDataAdapter(query,sql);
            DataSet ds = new DataSet();
            sd.Fill(ds, "MUA");
            dataGridView_DSMuaGiai.DataSource = ds.Tables["MUA"];
            sql.Close();
            for (int i = 0; i < dataGridView_DSMuaGiai.Rows.Count; i++)
            {
                dataGridView_DSMuaGiai.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }


        //Lưu vào cơ sở dữ liệu
        private void button_Luu_Click(object sender, EventArgs e)
        {
            temp1 = textBox_Nam1.Text;
            temp2 = textBox_Nam2.Text;
            string s1, s2;
                try
                {
                    s1 = textBox_Nam1.Text;
                    s2 = textBox_Nam2.Text;
                    SqlConnection sql = new SqlConnection(sc);
                    sql.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sql;
                    cmd.CommandText = String.Format("Insert into MuaGiai  VALUES ('" + s1 + "-" + s2 + "','" + s1 + "','" + s2 + "' )");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu thành công");
                    LoadDatabase();
                    textBox_Nam1.Text = "";
                    textBox_Nam2.Text = "";
                    frmtiepnhanhosodoibong d = new frmtiepnhanhosodoibong();
                    string s = s1.ToString() + "-" + s2.ToString();
                    d.getmuagiai(s);
                    d.Show();
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Thất bại!");
                }
               
        }

        private void textBox_Nam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //Không cho nhập kí tự
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_DSMuaGiai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentIndex = dataGridView_DSMuaGiai.CurrentCell.RowIndex;
            temp = dataGridView_DSMuaGiai.Rows[CurrentIndex].Cells[1].Value.ToString();

        }

       


        //Xoa du lieu trong bang
        public void Xoa(string temp)
        {
                SqlConnection sql = new SqlConnection(sc);
                sql.Open();
                string Query = "Delete from MuaGiai WHERE MuaGiai ='" + temp+"'";
                SqlCommand cmd = new SqlCommand(Query, sql);
                cmd.Connection = sql;
                cmd.ExecuteNonQuery();
                sql.Close();
                LoadDatabase();
  
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa mùa giải "+ temp,"Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Xoa(temp);
                    MessageBox.Show("Đã xóa!");
                }
                catch
                {
                    MessageBox.Show("Bạn hãy chọn đối tượng cần xóa.");
                }
            }
            LoadDatabase();
            button_Xoa.Enabled = false;
            button_Luu.Text = "Lưu";
            textBox_Nam1.Text = "";
            textBox_Nam2.Text = "";
        }

        private void dataGridView_DSMuaGiai_MouseClick(object sender, MouseEventArgs e)
        {
            button_Xoa.Enabled = true;
        }

        public string Get_MaMua()
        {
            string s="";
            s = textBox_Nam1.Text + "-" + textBox_Nam2.Text;
            return s;
        }

        private void textBox_Nam1_TextChanged(object sender, EventArgs e)
        {
            //Tự cập nhật năm 2
            if (textBox_Nam1.Text == "")
            {
                textBox_Nam2.Text = "";
            }
            else
            {
                int i = int.Parse(textBox_Nam1.Text);
                textBox_Nam2.Text = (i + 1).ToString();
            }
        }

        private void dataGridView_DSMuaGiai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmthaydoiquydinh f = new frmthaydoiquydinh();
            f.Show();
        }
    }
}
