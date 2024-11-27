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
    public partial class timkiemkhoa : Form
    {
        private SqlConnection sqlcon;
        public timkiemkhoa()
        {
            InitializeComponent();
        }
        private void KetNoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        private void LoadDataToGridView(string strsql)
        {
            try
            {
                SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, sqlcon);
                DataTable dt = new DataTable();
                dtadapter.Fill(dt);
                dgv_tkk.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void timkiemkhoa_Load(object sender, EventArgs e)
        {
            KetNoi();

            // Hiển thị dữ liệu mặc định
            string strsql = "SELECT makhoa AS [Mã Khoa], tenkhoa AS [Tên Khoa] FROM khoa";
            LoadDataToGridView(strsql);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy từ khóa từ TextBox
                string keyword = txt_tukhoa.Text.Trim();

                // Xây dựng câu lệnh SQL
                string strsql = "SELECT makhoa AS [Mã Khoa], tenkhoa AS [Tên Khoa] " +
                                "FROM khoa " +
                                "WHERE tenkhoa LIKE @keyword";

                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                // Hiển thị kết quả tìm kiếm
                SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dtadapter.Fill(dt);
                dgv_tkk.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_loadlai_Click(object sender, EventArgs e)
        {
            txt_tukhoa.Clear();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
