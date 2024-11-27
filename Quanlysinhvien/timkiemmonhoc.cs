using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien
{
    public partial class timkiemmonhoc : Form
    {
        private SqlConnection sqlcon;
        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        public timkiemmonhoc()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView(string strsql)
        {
            try
            {
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, sqlcon);
                DataTable dt = new DataTable();
                dtadapter.Fill(dt);
                dgv_tkmh.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void timkiemmonhoc_Load(object sender, EventArgs e)
        {
            this.cbb_timkiemtheo.Items.Add("Tên môn học");
            this.cbb_timkiemtheo.Items.Add("Số tiết");
            ketnoi();

            // Thêm các tiêu chí vào combobox
            this.cbb_timkiemtheo.Items.Add("Tên môn học");
            this.cbb_timkiemtheo.Items.Add("Số tiết");

            // Hiển thị dữ liệu mặc định
            string strsql = "SELECT mamh AS [Mã Môn Học], tenmh AS [Tên Môn Học], sotiet AS [Số Tiết], tengv AS [Tên Giáo Viên] " +
                            "FROM monhoc " +
                            "JOIN giaovien ON monhoc.magv = giaovien.magv";
            LoadDataToGridView(strsql);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tiêu chí tìm kiếm
                string criteria = cbb_timkiemtheo.SelectedItem.ToString();
                string value = txt_tukhoa.Text.Trim();

                // Xây dựng câu lệnh truy vấn SQL dựa vào tiêu chí tìm kiếm
                string strsql = "SELECT mamh AS [Mã Môn Học], tenmh AS [Tên Môn Học], sotiet AS [Số Tiết], tengv AS [Tên Giáo Viên] " +
                                "FROM monhoc " +
                                "JOIN giaovien ON monhoc.magv = giaovien.magv ";

                if (criteria == "Tên môn học")
                {
                    strsql += "WHERE tenmh LIKE @value";
                }
                else if (criteria == "Số tiết")
                {
                    strsql += "WHERE sotiet = @value";
                }

                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                if (criteria == "Tên môn học")
                {
                    cmd.Parameters.AddWithValue("@value", "%" + value + "%");
                }
                else if (criteria == "Số tiết")
                {
                    cmd.Parameters.AddWithValue("@value", int.TryParse(value, out int sotiet) ? sotiet : 0);
                }

                // Hiển thị kết quả tìm kiếm
                SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dtadapter.Fill(dt);
                dgv_tkmh.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_tukhoa.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
