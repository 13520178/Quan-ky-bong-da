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
    public partial class frmcauthu : Form
    {
        string Sc = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QL_BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public frmcauthu()
        {
            InitializeComponent();
        }
        int i = 0;
        int tuoith, tuoitd;
        int toida,ngoaitoida;
        private void frmcauthu_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false ;
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
            Loadthamso();
            SQL.Close();
        }
        string muagiai = "";
        public void getmuagiai(string s)
        {
            muagiai = s;
        }
        int count()
        {
            int j=0;
            
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open(); 
            string madoi = comboBox_Madoi.Text;
            string query = "Select COUNT(MaCT) AS SoLuong from CAUTHU Where MaDoi='" + madoi + "'";
            SqlCommand cmd = new SqlCommand(query, SQL);
            j = (int)cmd.ExecuteScalar();
            SQL.Close();
            return j;
        }
        int countngoai()
        {

            int j = 0;

            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string madoi = comboBox_Madoi.Text;
            string query = "Select COUNT(MaCT) AS SoLuong from CAUTHU Where MaDoi='" + madoi + "'AND LoaiCT=N'Ngoại'";
            SqlCommand cmd = new SqlCommand(query, SQL);
            j = (int)cmd.ExecuteScalar();
            SQL.Close();
            return j;
        }
        public void Loadthamso ()
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select Scauthu_ToiDa from thamso";
            SqlCommand cmd = new SqlCommand(query,SQL);
            toida=(int)cmd.ExecuteScalar();
            query = "Select Tuoi_ToiDa from thamso";
            cmd = new SqlCommand(query, SQL);
            tuoitd = (int)cmd.ExecuteScalar();
            query = "Select Tuoi_ToiThieu from thamso";
            cmd = new SqlCommand(query, SQL);
            tuoith = (int)cmd.ExecuteScalar();
            query = "Select SoCTngoai from thamso";
            cmd = new SqlCommand(query, SQL);
            ngoaitoida = (int)cmd.ExecuteScalar();
            SQL.Close();
        }
        public void loaddatabase()
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaCT,HoTen,convert(varchar, NgaySinh, 103) AS NgaySinh,LoaiCT,SoAo,ViTri,MuaGiai from CAUTHU Where MuaGiai='"+comboBox1.Text+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "CAUTHU");
            dataGridView_CauThu.DataSource = ds.Tables["CAUTHU"];
            for (int j = 0; j < dataGridView_CauThu.Rows.Count - 1; j++)
            {
                dataGridView_CauThu.Rows[j].Cells[0].Value = j + 1;
            }
            SQL.Close();
        }
       
        private void comboBox_Madoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string madoi = comboBox_Madoi.Text;
            string query = "Select MaCT,HoTen,convert(varchar, NgaySinh, 103) AS NgaySinh,LoaiCT,SoAO,ViTri,MuaGiai from CAUTHU Where MaDoi='" + madoi + "'AND MuaGiai='"+comboBox1.Text+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "CAUTHU");
            dataGridView_CauThu.DataSource = ds.Tables["CAUTHU"];
            for (int j = 0; j < dataGridView_CauThu.Rows.Count - 1; j++)
            {
                dataGridView_CauThu.Rows[j].Cells[0].Value = j + 1;
            }
            i = count();
            SQL.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if(button_Them.Text=="Thêm")
            {
                textBox_MaCT .Text= "";
                string s1 ="";
                string s2,s3;
                s2 = comboBox_Madoi.Text;
                int j = 2;
                if (count() > toida)
                {
                    MessageBox.Show("Số cầu thủ đả đạt tối đa", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    comboBox_Madoi.Enabled = false;
                   
                    button_Sua.Enabled = false;
                    button_Xoa.Enabled = false;
                    groupBox1.Enabled = true;
                    button_Them.Text = "Lưu";
                    textBox_MaCT.Text = "";
                    textBox_TenCT.Text = "";
                    try
                    {
                        s2 = comboBox_Madoi.Text;
                        while (s2[j] != ' ')
                        {
                            s1 += s2[j];
                            j++;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Chưa chọn mã đội");
                        button_Them.Text = "Thêm";
                        button_Them.Enabled = true;
                       
                        button_Sua.Enabled = true;
                        button_Xoa.Enabled = true;
                        button_Sua.Text = "Sửa";
                        groupBox1.Enabled = false;
                        comboBox_Madoi.Enabled = true;
                        
                    }
                    s3 = s1 + string.Format("{0:00}", i);
                    for (int k = 0; k < dataGridView_CauThu.Rows.Count - 1; k++)
                    {

                        if (dataGridView_CauThu[1, k].Value.ToString().Contains(s3))
                            i = i + 1;
                    }
                    s3 = s1 + string.Format("{0:00}", i);
                    textBox_MaCT.Text = s3;
                }

            }
            else if (button_Them.Text == "Lưu")
            {

                if (textBox_TenCT.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên cầu thủ");
                }
                else
                {
                    string s1, s2, s3, s4, s5,s6,s7,s8;
                    s2 = comboBox_Madoi.Text;
                    s1 = textBox_MaCT.Text;
                    s3 = frmtiepnhanhosodoibong.Mahoa(textBox_TenCT);
                    s4 = dateTimePicker1.Value.ToString();
                    s5 = comboBox_LoaiCT.Text;
                    s6 = comboBox1.Text;
                    s7 = textBox_SoAo.Text;
                    s8 = comboBox_Vitri.Text;
                    int ns = int.Parse(dateTimePicker1.Value.Year.ToString());
                    DateTime d = DateTime.Now;
                    int nn = int.Parse(d.Year.ToString());
                    if (kiemtra(s3) == 0)
                    {
                        MessageBox.Show("Tên cầu thủ không có số", "Thông báo", MessageBoxButtons.OK);
                    }
                    else if ((nn - ns) < tuoith || (nn - ns) > tuoitd)
                    {
                        MessageBox.Show("Tuổi cầu thủ phải từ "+tuoith+" đến "+ tuoitd+" tuổi", "Thông báo", MessageBoxButtons.OK);
                    }
 
                     if (countngoai()==3 && comboBox_LoaiCT.Text == "Ngoại")
                        {
                            MessageBox.Show("Số cầu thủ ngoại đả đạt tối đa "+ngoaitoida+" cầu thủ");
                            comboBox_LoaiCT.Text = "";
                        }
                    else
                    {
                        try
                        {
                            SqlConnection SQL = new SqlConnection(Sc);
                            SQL.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = SQL;
                            cmd.CommandText = String.Format("Insert into CAUTHU values ('" + s1 + "','" + s2 + "',N'" + s3 + "','" + s4 + "',N'" + s5 + "','"+s6+"',"+s7+",'"+s8+"');");
                            int n = cmd.ExecuteNonQuery();
                            MessageBox.Show("Lưu thành công");
                            SQL.Close();
                            button_Them.Text = "Thêm";
                            
                            button_Sua.Enabled = true;
                            button_Xoa.Enabled = true;
                            groupBox1.Enabled = false;
                            comboBox_Madoi.Enabled = true;
                            loaddatabase();
                            i++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        }
                    }
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
                    int CurrentIndex = dataGridView_CauThu.CurrentCell.RowIndex;
                    string MaCT = Convert.ToString(dataGridView_CauThu.Rows[CurrentIndex].Cells[1].Value.ToString());
                    string deletedStr = "Delete from CAUTHU where MaCT='" + MaCT + "'";
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

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_HuyBo_Click(object sender, EventArgs e)
        {
            button_Them.Text = "Thêm";
            button_Them.Enabled = true;
           
            button_Sua.Enabled = true;
            button_Xoa.Enabled = true;
            button_Sua.Text = "Sửa";
            groupBox1.Enabled = false;
            comboBox_Madoi.Enabled = true;
        }
        public static int kiemtra(string s)
        {
            int i = 1;
                for (int j = 0; j < s.Length ; j++)
                {
                    if (char.IsNumber(s[j]))
                            i = 0;
                }
            return i;
        }

        private void dataGridView_CauThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaCT.Text = dataGridView_CauThu.CurrentRow.Cells[1].Value.ToString();
            textBox_TenCT.Text = dataGridView_CauThu.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView_CauThu.CurrentRow.Cells[3].Value.ToString();
            comboBox_LoaiCT.Text = dataGridView_CauThu.CurrentRow.Cells[4].Value.ToString();
            textBox_SoAo.Text = dataGridView_CauThu.CurrentRow.Cells[5].Value.ToString();
            comboBox_Vitri.Text = dataGridView_CauThu.CurrentRow.Cells[6].Value.ToString();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (button_Sua.Text == "Sửa")
            {
                button_Them.Enabled = false;
                
                button_Sua.Text = "Lưu";
                button_Xoa.Enabled = false;
                groupBox1.Enabled = true;
                comboBox_Madoi.Enabled = false;
            }
            else if (button_Sua.Text == "Lưu")
            {
                if (textBox_TenCT.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên cầu thủ");
                }
                else
                {
                    try
                    {
                        SqlConnection SQL = new SqlConnection(Sc);
                        SQL.Open();
                        int CurrentIndex = dataGridView_CauThu.CurrentCell.RowIndex;
                        string MaCT = Convert.ToString(dataGridView_CauThu.Rows[CurrentIndex].Cells[1].Value.ToString());
                        string TenCT = textBox_TenCT.Text;
                        string NS = dateTimePicker1.Value.ToString();
                        int ns = int.Parse(dateTimePicker1.Value.Year.ToString());
                        DateTime d = DateTime.Now;
                        int nn = int.Parse(d.Year.ToString());
                        if (kiemtra(TenCT) == 0)
                        {
                            MessageBox.Show("Tên cầu thủ không có số", "Thông báo", MessageBoxButtons.OK);
                        }
                        
                         else if ((nn - ns) < tuoith || (nn - ns) > tuoitd)
                         {
                             MessageBox.Show("Tuổi cầu thủ phải từ " + tuoith + " đến " + tuoitd + " tuổi", "Thông báo", MessageBoxButtons.OK);
                         }
                        else
                        {
                            string LoaiCT = comboBox_LoaiCT.Text;
                            string updateStr = "Update CAUTHU set MaCT='" + MaCT + "',HoTen=N'" + TenCT + "',NgaySinh='" + NS + "',LoaiCT='N" + LoaiCT + "',SoAO='"+textBox_SoAo.Text+"',ViTri='"+comboBox_Vitri.Text+"' where MaCT='" + MaCT + "'";
                            SqlCommand updateCmd = new SqlCommand(updateStr, SQL);
                            updateCmd.CommandType = CommandType.Text;
                            updateCmd.ExecuteNonQuery();
                            loaddatabase();
                            MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                            SQL.Close();
                           
                            button_Sua.Enabled = true;
                            button_Xoa.Enabled = true;
                            button_Sua.Text = "Sửa";
                            groupBox1.Enabled = false;
                            comboBox_Madoi.Enabled = true;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox_Madoi.Text = "";
            SqlConnection SQL = new SqlConnection(Sc);
            SQL.Open();
            string query = "Select MaDoi from DOIBONG Where MuaGiai='"+muagiai+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SQL;
            SqlDataAdapter da = new SqlDataAdapter(query, SQL);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "MADOI");
            comboBox_Madoi.DataSource = ds.Tables["MADOI"];
            comboBox_Madoi.DisplayMember = "MaDoi";
            i = count();
            SQL.Close();
        }

        private void dataGridView_CauThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_LoaiCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
    }
}
