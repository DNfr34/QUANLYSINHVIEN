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
    public partial class timkiemchinhsach : Form
    {
        private SqlConnection sqlcon;
        public timkiemchinhsach()
        {
            InitializeComponent();
        }
        public void KetNoi()
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
                dgv_tkchinhsach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tiêu chí tìm kiếm
                string criteria = cbb_timkiemtheo.SelectedItem?.ToString();
                string value = txt_tukhoa.Text.Trim();

                // Xây dựng câu lệnh truy vấn SQL
                string strsql = "SELECT macs AS [Mã Chính Sách], tencs AS [Tên Chính Sách], chedo AS [Chế Độ] FROM chinhsach ";

                if (criteria == "Mã chính sách")
                {
                    strsql += "WHERE macs LIKE @value";
                }
                else if (criteria == "Chế độ")
                {
                    strsql += "WHERE chedo LIKE @value";
                }

                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                cmd.Parameters.AddWithValue("@value", "%" + value + "%");

                // Hiển thị kết quả tìm kiếm
                SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dtadapter.Fill(dt);
                dgv_tkchinhsach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_loadlai_Click(object sender, EventArgs e)
        {
            string strsql = "SELECT macs AS [Mã Chính Sách], tencs AS [Tên Chính Sách], chedo AS [Chế Độ] FROM chinhsach";
            LoadDataToGridView(strsql);

            // Xóa textbox và combobox
            txt_tukhoa.Clear();
            cbb_timkiemtheo.SelectedIndex = -1;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timkiemchinhsach_Load(object sender, EventArgs e)
        {
            // Kết nối cơ sở dữ liệu
            KetNoi();

            // Thêm các tiêu chí vào ComboBox
            cbb_timkiemtheo.Items.Add("Mã chính sách");
            cbb_timkiemtheo.Items.Add("Chế độ");

            // Hiển thị dữ liệu mặc định
            string strsql = "SELECT macs AS [Mã Chính Sách], tencs AS [Tên Chính Sách], chedo AS [Chế Độ] FROM chinhsach";
            LoadDataToGridView(strsql);
        }
    }
}
