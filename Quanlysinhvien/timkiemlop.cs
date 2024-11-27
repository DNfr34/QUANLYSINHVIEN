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
    public partial class timkiemlop : Form
    {
        private SqlConnection sqlcon;
        public timkiemlop()
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
                dgv_tkl.DataSource = dt;
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

                // Xây dựng câu lệnh SQL dựa vào tiêu chí tìm kiếm
                string strsql = "SELECT malop AS [Mã Lớp], tenlop AS [Tên Lớp], makhoa AS [Mã Khoa] FROM lop ";

                if (criteria == "Mã lớp")
                {
                    strsql += "WHERE malop LIKE @value";
                }
                else if (criteria == "Mã khoa")
                {
                    strsql += "WHERE makhoa LIKE @value";
                }

                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                cmd.Parameters.AddWithValue("@value", "%" + value + "%");

                // Hiển thị kết quả tìm kiếm
                SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dtadapter.Fill(dt);
                dgv_tkl.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_loadlai_Click(object sender, EventArgs e)
        {
            string strsql = "SELECT malop AS [Mã Lớp], tenlop AS [Tên Lớp], makhoa AS [Mã Khoa] FROM lop";
            LoadDataToGridView(strsql);

            // Xóa TextBox tìm kiếm và ComboBox
            txt_tukhoa.Clear();
            cbb_timkiemtheo.SelectedIndex = -1;
        }

        private void timkiemlop_Load(object sender, EventArgs e)
        {
            KetNoi();

            this.cbb_timkiemtheo.Items.Add("Mã lớp");
            this.cbb_timkiemtheo.Items.Add("Mã khoa");

            // Hiển thị dữ liệu mặc định
            string strsql = "SELECT malop AS [Mã Lớp], tenlop AS [Tên Lớp], makhoa AS [Mã Khoa] FROM lop";
            LoadDataToGridView(strsql);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
