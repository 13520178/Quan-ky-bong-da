using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace BM_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_Table_For_Filter();
            Chon_ComboBox();
            Load_Data();
        }

        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable cauthu = new DataTable();
        DataTable cauthughiban = new DataTable();
        DataTable doibong = new DataTable();
        DataTable thongtin = new DataTable();
        DataTable dt4 = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand sqlcom = new SqlCommand();

        SqlConnection con = new SqlConnection(@"Data Source=TRUONG\SQLEXPRESS;Initial Catalog=QL_BD;Integrated Security=True");
        private void Load_Data()
        {
            con.Open();
            string truyvan3 = @"select MaCT, MaDoi, HoTen, NgaySinh, LoaiCT, SoAo, ViTri from CAUTHU"; // Chọn hết bảng CAUTHU
            sqlcom = new SqlCommand(truyvan3, con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);
            da.Fill(cauthu);
            cauthu.Columns.Add("BanThang", typeof(int)); // Gán bàn thắng = 0
            for (int i = 0; i < cauthu.Rows.Count; i++)
                cauthu.Rows[i][7] = 0;

            string truyvan4 = @"select * from CT_GHIBAN"; // Chọn hết bảng CT_GHIBAN
            sqlcom = new SqlCommand(truyvan4, con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);
            da.Fill(cauthughiban);

            string truyvan5 = @"select * from DOIBONG"; // Chọn hết bảng DOIBONG
            sqlcom = new SqlCommand(truyvan5, con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);
            da.Fill(doibong);




            string truyvan1 = @"select CT.MaCT, HoTen as Tên, TenDoi as Đội, LoaiCT as 'Loại Cầu Thủ', count(CT.MaCT) as 'Bàn Thắng' 
                                from CAUTHU as CT, CT_GHIBAN as CTGB, DOIBONG as DB 
                                where CT.MaCT = CTGB.MaCT and CT.MaDoi = DB.MaDoi 
                                group by CT.MaCT, HoTen, TenDoi, LoaiCT";
            sqlcom = new SqlCommand(truyvan1, con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);

            DataColumn Stt = new DataColumn();
            Stt.ColumnName = "STT";
            Stt.AutoIncrement = true;
            Stt.AutoIncrementSeed = 1;
            Stt.AutoIncrementStep = 1;
            dt1.Columns.Add(Stt);
            da.Fill(dt1);
           // dataGridView1.DataSource = doibong;
            
            for (int i = 0; i < cauthu.Rows.Count; i++) // Cập nhật số bàn thắng
                for (int j = 0; j < dt1.Rows.Count; j++)
                    if (cauthu.Rows[i][0].ToString() == dt1.Rows[j][1].ToString())
                        cauthu.Rows[i][7] = dt1.Rows[j][5];


            DataTable temp = new DataTable(); // Kết bảng doibong với bảng cauthu
            temp.Columns.Add("MaCT", typeof(string));
            temp.Columns.Add("HoTen", typeof(string));
            temp.Columns.Add("LoaiCT", typeof(string));
            temp.Columns.Add("TenDoi", typeof(string));
            var products = from ct in cauthu.AsEnumerable()
                           join db in doibong.AsEnumerable()
                           on ct.Field<string>("MaDoi") equals db.Field<string>("MaDoi")
                           where ct.Field<string>("MaDoi") != null
                           select new
                           {
                               MaCauThu = ct.Field<string>("MaCT"),
                               TenCauThu = ct.Field<string>("HoTen"),
                               LoaiCauThu =ct.Field<string>("LoaiCT"),
                               Doi = db.Field<string>("TenDoi")
                           };
            foreach(var item in products)
            {
                DataRow dr = temp.NewRow();
                dr["MaCT"] = item.MaCauThu;
                dr["HoTen"] = item.TenCauThu;
                dr["LoaiCT"] = item.LoaiCauThu;
                dr["TenDoi"] = item.Doi;
                temp.Rows.Add(dr);
            }

             // Kết bảng temp với bảng cauthu
            DataColumn stt = new DataColumn();
            stt.ColumnName = "STT";
            stt.AutoIncrement = true;
            stt.AutoIncrementSeed = 1;
            stt.AutoIncrementStep = 1;
            end.Columns.Add(stt);

            end.Columns.Add("Mã Cầu Thủ", typeof(string));
            end.Columns.Add("Họ Tên", typeof(string));
            end.Columns.Add("Đội", typeof(string));
            end.Columns.Add("Loại Cầu Thủ", typeof(string));
            end.Columns.Add("Số Bàn Thắng", typeof(int));

            var prod = from c in cauthu.AsEnumerable()
                            join t in temp.AsEnumerable()
                            on c.Field<string>("MaCT") equals t.Field<string>("MaCT")
                            where c.Field<string>("MaDoi") != null
                            select new
                            {
                                MaCauThu = t.Field<string>("MaCT"),
                               TenCauThu = t.Field<string>("HoTen"),
                               LoaiCauThu = t.Field<string>("LoaiCT"),
                               Doi = t.Field<string>("TenDoi"),
                               SoBanThang = c.Field<int>("BanThang")
                            };
            foreach(var item in prod)
            {
               DataRow dr = end.NewRow();
               dr["Mã Cầu Thủ"] = item.MaCauThu;
               dr["Họ Tên"] = item.TenCauThu;
               dr["Loại Cầu Thủ"] = item.LoaiCauThu;
               dr["Đội"] = item.Doi;
               dr["Số Bàn Thắng"] = item.SoBanThang;
               end.Rows.Add(dr);
            }

            //dataGridView1.DataSource = end;

            // Lấy các thuộc tính để hiển thị lên các textBox:
            string truyvan_thongtin = @"select MaCT, NgaySinh, SoAo, LoaiCT, ViTri, Nam1, Nam2, HoTen
                                    from CAUTHU, MUAGIAI
                                    where CAUTHU.MuaGiai = MUAGIAI.MuaGiai";
            sqlcom = new SqlCommand(truyvan_thongtin, con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);
            da.Fill(thongtin);
           // dataGridView1.DataSource = thongtin;
            string truyvan2 = @"select CT.MaCT as 'Mã Cầu Thủ', HoTen as Tên, TenDoi as Đội, LoaiCT as 'Loại Cầu Thủ',
                                NgaySinh as 'Ngày Sinh', SoAo as 'Số Áo', ViTri as 'Vị Trí', LoaiBT, MG.MuaGiai
                                from CAUTHU as CT, CT_GHIBAN as CTGB, DOIBONG as DB, MUAGIAI as MG
                                where CT.MaCT = CTGB.MaCT and CT.MaDoi = DB.MaDoi and CT.MuaGiai = MG.MuaGiai";
            sqlcom = new SqlCommand(truyvan2, con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);
            da.Fill(dt2);

            //dataGridView1.DataSource = dt2;
            con.Close();

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void richTextBox_HoVaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DateTime ngaysinh = new DateTime();
            richTextBox_HoVaTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox_DoiBong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            richTextBox_LoaiCauThu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //richTextBox_MaCauThu.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            for (int i = 0; i < thongtin.Rows.Count; i++)
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString().Replace(" ", "") == thongtin.Rows[i][7].ToString().Replace(" ", ""))
                {
                    ngaysinh = Convert.ToDateTime(thongtin.Rows[i][1].ToString());
                    richTextBox_NgaySinh.Text = ngaysinh.ToString("d"); //dt2.Rows[i][4].ToString();
                    richTextBox_MaCauThu.Text = thongtin.Rows[i][0].ToString();
                    //richTextBox_LoaiCauThu.Text = thongtin.Rows[i][3].ToString();
                    richTextBox_SoAo.Text = thongtin.Rows[i][2].ToString();
                    richTextBox_ViTriSoTruong.Text = thongtin.Rows[i][4].ToString();
                    richTextBox_MuaGiai.Text = thongtin.Rows[i][5].ToString() + "-" + thongtin.Rows[i][6].ToString();
                    break;
                }


            richTextBox_HoVaTen.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_DoiBong.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_LoaiCauThu.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_NgaySinh.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_SoAo.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_ViTriSoTruong.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_MaCauThu.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_MuaGiai.SelectionAlignment = HorizontalAlignment.Right;
        }
        DataTable end = new DataTable();
        void Chon_ComboBox()
        {
            DataTable ten_soao = new DataTable();
            con.Open();
            sqlcom = new SqlCommand("Select MaCT, SoAo from CAUTHU", con);
            sqlcom.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(sqlcom);
            da.Fill(ten_soao);
            comboBox_MaCauThu.Items.Add("Tất cả...");
            comboBox_SoAo.Items.Add("Tất cả...");
            for(int i = 0; i < ten_soao.Rows.Count; i++)
            {
                comboBox_MaCauThu.Items.Add(ten_soao.Rows[i][0]);
                comboBox_SoAo.Items.Add(ten_soao.Rows[i][1]);
            }
            comboBox_MaCauThu.Text = "Tất cả...";
            comboBox_SoAo.Text = "Tất cả...";

            DataTable doibong = new DataTable();
            sqlcom = new SqlCommand("Select TenDoi from DOIBONG", con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);
            da.Fill(doibong);
            comboBox_Doi.Items.Add("Tất cả...");
            for (int i = 0; i < doibong.Rows.Count; i++)
            {
                comboBox_Doi.Items.Add(doibong.Rows[i][0]);
            }
            comboBox_Doi.Text = "Tất cả...";

            DataTable muagiai = new DataTable();
            sqlcom = new SqlCommand("Select Nam1, Nam2 from MUAGIAI", con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);
            da.Fill(muagiai);
            comboBox_MuaGiai.Items.Add("Tất cả...");
            for (int i = 0; i < muagiai.Rows.Count; i++)
            {
                comboBox_MuaGiai.Items.Add(muagiai.Rows[i][0] + " - " + muagiai.Rows[i][1]);
            }
            comboBox_MuaGiai.Text = "Tất cả...";
            con.Close();

            comboBox_SapXepTheo.Items.Add("Số Bàn Thắng");
            comboBox_SapXepTheo.Items.Add("Họ Tên");
            comboBox_SapXepTheo.Items.Add("Mã Cầu Thủ");
            comboBox_SapXepTheo.Items.Add("Đội");
            comboBox_SapXepTheo.Items.Add("Loại Cầu Thủ");
            comboBox_SapXepTheo.Text = "Số Bàn Thắng";
        }
        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
                dataGridView1.Rows.Remove(dgvr);

            DataTable Timkiem = new DataTable();
            DataColumn stt = new DataColumn();
            stt.ColumnName = "STT";                                                      // bảng Tìm kiếm
            stt.AutoIncrement = true;
            stt.AutoIncrementSeed = 1;
            stt.AutoIncrementStep = 1;
            //Timkiem.Columns.Add(stt);

            Timkiem.Columns.Add("Mã Cầu Thủ", typeof(string));
            Timkiem.Columns.Add("Họ Tên", typeof(string));
            Timkiem.Columns.Add("Đội", typeof(string));
            Timkiem.Columns.Add("Loại Cầu Thủ", typeof(string));
            Timkiem.Columns.Add("Số Bàn Thắng", typeof(int));

            string tk = richTextBox_TenCauThu.Text;
            for (int i = 0; i < end.Rows.Count; i++)
                if (end.Rows[i][2].ToString().ToLower().Contains(tk.ToLower()) == true)
                    Timkiem.ImportRow(end.Rows[i]);

            dataGridView1.DataSource = Timkiem;         // Tìm kiếm xong

            LocTheoMa.Clear();
            if (comboBox_MaCauThu.Text != "Tất cả...")                                              // Lọc theo Mã CT
            {
                var product = from p in Timkiem.AsEnumerable()
                              where p.Field<string>("Mã Cầu Thủ") == comboBox_MaCauThu.Text
                              select new
                              {
                                  MaCauThu = p.Field<string>("Mã Cầu Thủ"),
                                  HoTen = p.Field<string>("Họ Tên"),
                                  Doi = p.Field<string>("Đội"),
                                  LoaiCauThu = p.Field<string>("Loại Cầu Thủ"),
                                  SoBanThang = p.Field<int>("Số Bàn Thắng")
                              };
                foreach (var item in product)
                {
                    DataRow dr = LocTheoMa.NewRow();
                    dr["Mã Cầu Thủ"] = item.MaCauThu;
                    dr["Họ Tên"] = item.HoTen;
                    dr["Đội"] = item.Doi;
                    dr["Loại Cầu Thủ"] = item.LoaiCauThu;
                    dr["Số Bàn Thắng"] = item.SoBanThang;
                    LocTheoMa.Rows.Add(dr);
                }
            }
            else
            {
                //Timkiem.Columns.RemoveAt(0);
                LocTheoMa = Timkiem.Copy();
            }
            //dataGridView1.DataSource = LocTheoMa;

            LocTheoDoi.Clear();
            if (comboBox_Doi.Text != "Tất cả...")                                                    // Lọc Theo đội
            {

                var product = from p in LocTheoMa.AsEnumerable()
                              where p.Field<string>("Đội") == comboBox_Doi.Text
                              select new
                              {
                                  MaCauThu = p.Field<string>("Mã Cầu Thủ"),
                                  HoTen = p.Field<string>("Họ Tên"),
                                  Doi = p.Field<string>("Đội"),
                                  LoaiCauThu = p.Field<string>("Loại Cầu Thủ"),
                                  SoBanThang = p.Field<int>("Số Bàn Thắng")
                              };
                foreach (var item in product)
                {
                    DataRow dr = LocTheoDoi.NewRow();
                    dr["Mã Cầu Thủ"] = item.MaCauThu;
                    dr["Họ Tên"] = item.HoTen;
                    dr["Đội"] = item.Doi;
                    dr["Loại Cầu Thủ"] = item.LoaiCauThu;
                    dr["Số Bàn Thắng"] = item.SoBanThang;
                    LocTheoDoi.Rows.Add(dr);
                }
            }
            else
            {
                //LocTheoMa.Columns.RemoveAt(0);
                LocTheoDoi = LocTheoMa.Copy();
            }
            //dataGridView1.DataSource = LocTheoDoi;

            LocTheoMua.Clear();
            if (comboBox_MuaGiai.Text != "Tất cả...")                                                    // Lọc Theo mùa
            {

                var product = from p in LocTheoDoi.AsEnumerable()
                              join q in MaCT_NamD_NamS.AsEnumerable()
                              on p.Field<string>("Mã Cầu Thủ") equals q.Field<string>("MaCT")
                              where (q.Field<int>("Nam1").ToString() + " - " + q.Field<int>("Nam2").ToString()) == comboBox_MuaGiai.Text
                              select new
                              {
                                  MaCauThu = p.Field<string>("Mã Cầu Thủ"),
                                  HoTen = p.Field<string>("Họ Tên"),
                                  Doi = p.Field<string>("Đội"),
                                  LoaiCauThu = p.Field<string>("Loại Cầu Thủ"),
                                  SoBanThang = p.Field<int>("Số Bàn Thắng")
                              };
                foreach (var item in product)
                {
                    DataRow dr = LocTheoMua.NewRow();
                    dr["Mã Cầu Thủ"] = item.MaCauThu;
                    dr["Họ Tên"] = item.HoTen;
                    dr["Đội"] = item.Doi;
                    dr["Loại Cầu Thủ"] = item.LoaiCauThu;
                    dr["Số Bàn Thắng"] = item.SoBanThang;
                    LocTheoMua.Rows.Add(dr);
                }
            }
            else
            {
                //LocTheoDoi.Columns.RemoveAt(0);
                LocTheoMua = LocTheoDoi.Copy();
            }
           //dataGridView1.DataSource = LocTheoMua;
            LocTheoSoAo.Clear();
            if (comboBox_SoAo.Text != "Tất cả...")                                                    // Lọc Theo Số áo
            {
                var product = from p in LocTheoMua.AsEnumerable()
                              join q in MaCT_NamD_NamS.AsEnumerable()
                              on p.Field<string>("Mã Cầu Thủ") equals q.Field<string>("MaCT")
                              where (q.Field<int>("SoAo").ToString()) == comboBox_SoAo.Text
                              select new
                              {
                                  MaCauThu = p.Field<string>("Mã Cầu Thủ"),
                                  HoTen = p.Field<string>("Họ Tên"),
                                  Doi = p.Field<string>("Đội"),
                                  LoaiCauThu = p.Field<string>("Loại Cầu Thủ"),
                                  SoBanThang = p.Field<int>("Số Bàn Thắng")
                              };
                foreach (var item in product)
                {
                    DataRow dr = LocTheoSoAo.NewRow();
                    dr["Mã Cầu Thủ"] = item.MaCauThu;
                    dr["Họ Tên"] = item.HoTen;
                    dr["Đội"] = item.Doi;
                    dr["Loại Cầu Thủ"] = item.LoaiCauThu;
                    dr["Số Bàn Thắng"] = item.SoBanThang;
                    LocTheoSoAo.Rows.Add(dr);
                }
            }
            else
            {
               // LocTheoMua.Columns.RemoveAt(0);
                LocTheoSoAo = LocTheoMua.Copy();
            }
            //dataGridView1.DataSource = LocTheoSoAo;
                                                                                                // Sắp xếp số bàn thắng:
            SapXep.Clear();
            if (comboBox_SapXepTheo.Text == "Số Bàn Thắng")
            {
                var prod = from p in LocTheoSoAo.AsEnumerable()
                           where p.Field<string>("Mã Cầu Thủ") != null
                           orderby p.Field<int>(comboBox_SapXepTheo.Text) descending
                           select new
                           {
                               MaCauThu = p.Field<string>("Mã Cầu Thủ"),
                               HoTen = p.Field<string>("Họ Tên"),
                               Doi = p.Field<string>("Đội"),
                               LoaiCauThu = p.Field<string>("Loại Cầu Thủ"),
                               SoBanThang = p.Field<int>("Số Bàn Thắng")
                           };
                int i = 1;
                foreach (var item in prod)
                {
                    DataRow dr = SapXep.NewRow();
                    dr["Mã Cầu Thủ"] = item.MaCauThu;
                    dr["Họ Tên"] = item.HoTen;
                    dr["Đội"] = item.Doi;
                    dr["Loại Cầu Thủ"] = item.LoaiCauThu;
                    dr["Số Bàn Thắng"] = item.SoBanThang;
                    dr["STT"] = i;
                    SapXep.Rows.Add(dr);
                    i++;
                }
            }
            else                                                                                      // Sắp xếp:
            {
                var prod = from p in LocTheoSoAo.AsEnumerable()
                           where p.Field<string>("Mã Cầu Thủ") != null
                           orderby p.Field<string>(comboBox_SapXepTheo.Text) ascending
                           select new
                           {
                               MaCauThu = p.Field<string>("Mã Cầu Thủ"),
                               HoTen = p.Field<string>("Họ Tên"),
                               Doi = p.Field<string>("Đội"),
                               LoaiCauThu = p.Field<string>("Loại Cầu Thủ"),
                               SoBanThang = p.Field<int>("Số Bàn Thắng")
                           };
                int i = 1;
                foreach (var item in prod)
                {
                    DataRow dr = SapXep.NewRow();
                    dr["Mã Cầu Thủ"] = item.MaCauThu;
                    dr["Họ Tên"] = item.HoTen;
                    dr["Đội"] = item.Doi;
                    dr["Loại Cầu Thủ"] = item.LoaiCauThu;
                    dr["Số Bàn Thắng"] = item.SoBanThang;
                    dr["STT"] = i;
                    SapXep.Rows.Add(dr);
                    i++;
                }
            }

            dataGridView1.DataSource = SapXep;
            label18.Text = "Tổng cộng: " + SapXep.Rows.Count + " cầu thủ";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            richTextBox_HoVaTen.Text = null;
            richTextBox_DoiBong.Text = null;
            richTextBox_LoaiCauThu.Text = null;
            richTextBox_MaCauThu.Text = null;
            richTextBox_SoAo.Text = null;
            richTextBox_ViTriSoTruong.Text = null;
            richTextBox_MuaGiai.Text = null;
            richTextBox_NgaySinh.Text = null;
        }
        //------------------------------------------------.

        DataTable LocTheoMa = new DataTable();
        DataTable LocTheoDoi = new DataTable();
        DataTable LocTheoMua = new DataTable();
        DataTable LocTheoSoAo = new DataTable();
        DataTable SapXep = new DataTable();
        DataTable MaCT_NamD_NamS = new DataTable();

        DataColumn stt1 = new DataColumn("STT", typeof(int));
        DataColumn stt2 = new DataColumn("STT", typeof(int));
        DataColumn stt3 = new DataColumn("STT", typeof(int));
        DataColumn stt4 = new DataColumn("STT", typeof(int));
        DataColumn stt5 = new DataColumn("STT", typeof(int));

        void Create_Table_For_Filter()
        {
            LocTheoMa.Columns.Add("Mã Cầu Thủ", typeof(string));
            LocTheoMa.Columns.Add("Họ Tên", typeof(string));
            LocTheoMa.Columns.Add("Đội", typeof(string));
            LocTheoMa.Columns.Add("Loại Cầu Thủ", typeof(string));
            LocTheoMa.Columns.Add("Số Bàn Thắng", typeof(int));

            LocTheoDoi.Columns.Add("Mã Cầu Thủ", typeof(string));
            LocTheoDoi.Columns.Add("Họ Tên", typeof(string));
            LocTheoDoi.Columns.Add("Đội", typeof(string));
            LocTheoDoi.Columns.Add("Loại Cầu Thủ", typeof(string));
            LocTheoDoi.Columns.Add("Số Bàn Thắng", typeof(int));

            LocTheoMua.Columns.Add("Mã Cầu Thủ", typeof(string));
            LocTheoMua.Columns.Add("Họ Tên", typeof(string));
            LocTheoMua.Columns.Add("Đội", typeof(string));
            LocTheoMua.Columns.Add("Loại Cầu Thủ", typeof(string));
            LocTheoMua.Columns.Add("Số Bàn Thắng", typeof(int));

            LocTheoSoAo.Columns.Add("Mã Cầu Thủ", typeof(string));
            LocTheoSoAo.Columns.Add("Họ Tên", typeof(string));
            LocTheoSoAo.Columns.Add("Đội", typeof(string));
            LocTheoSoAo.Columns.Add("Loại Cầu Thủ", typeof(string));
            LocTheoSoAo.Columns.Add("Số Bàn Thắng", typeof(int));

            stt5.AutoIncrement = true;
            stt5.AutoIncrementStep = 1;
            stt5.AutoIncrementSeed = 1;
            //SapXep.Columns.Add(stt5);
            SapXep.Columns.Add("STT", typeof(int));
            SapXep.Columns.Add("Loại Cầu Thủ", typeof(string));
            SapXep.Columns.Add("Họ Tên", typeof(string));
            SapXep.Columns.Add("Số Bàn Thắng", typeof(int));
            SapXep.Columns.Add("Mã Cầu Thủ", typeof(string));
            SapXep.Columns.Add("Đội", typeof(string));

            dataGridView1.AutoGenerateColumns = false;
            sqlcom = new SqlCommand(@"select MaCT, SoAo, Nam1, Nam2 
                                        from CAUTHU, MUAGIAI where CAUTHU.MuaGiai = MUAGIAI.MuaGiai", con);
            sqlcom.CommandType = CommandType.Text;
            da = new SqlDataAdapter(sqlcom);
            da.Fill(MaCT_NamD_NamS);
        }
        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }

}
