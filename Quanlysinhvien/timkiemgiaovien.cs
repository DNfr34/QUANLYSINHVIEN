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
    public partial class timkiemgiaovien : Form
    {
        private SqlConnection sqlcon;
        public void ketnoi()
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
                dgv_tkgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public timkiemgiaovien()
        {
            InitializeComponent();
        }

        private void timkiemgiaovien_Load(object sender, EventArgs e)
        {
            ketnoi();

            // Thêm các tiêu chí vào combobox
            this.cbb_timkiemtheo.Items.Add("Tên giáo viên");
            this.cbb_timkiemtheo.Items.Add("Địa chỉ");

            // Hiển thị dữ liệu mặc định
            string strsql = "SELECT magv AS [Mã Giáo Viên], tengv AS [Tên Giáo Viên], gioitinh AS [Giới Tính], " +
                            "ngaysinh AS [Ngày Sinh], sdt AS [Số Điện Thoại], diachi AS [Địa Chỉ] FROM giaovien";
            LoadDataToGridView(strsql);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tiêu chí tìm kiếm
                string criteria = cbb_timkiemtheo.SelectedItem?.ToString();
                string value = txt_tukhoa.Text.Trim();

                // Xây dựng câu lệnh truy vấn SQL dựa vào tiêu chí tìm kiếm
                string strsql = "SELECT magv AS [Mã Giáo Viên], tengv AS [Tên Giáo Viên], gioitinh AS [Giới Tính], " +
                                "ngaysinh AS [Ngày Sinh], sdt AS [Số Điện Thoại], diachi AS [Địa Chỉ] FROM giaovien ";

                if (criteria == "Tên giáo viên")
                {
                    strsql += "WHERE tengv LIKE @value";
                }
                else if (criteria == "Địa chỉ")
                {
                    strsql += "WHERE diachi LIKE @value";
                }

                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                cmd.Parameters.AddWithValue("@value", "%" + value + "%");

                // Hiển thị kết quả tìm kiếm
                SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dtadapter.Fill(dt);
                dgv_tkgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_loadlai_Click(object sender, EventArgs e)
        {
            // Hiển thị lại toàn bộ dữ liệu
            string strsql = "SELECT magv AS [Mã Giáo Viên], tengv AS [Tên Giáo Viên], gioitinh AS [Giới Tính], " +
                            "ngaysinh AS [Ngày Sinh], sdt AS [Số Điện Thoại], diachi AS [Địa Chỉ] FROM giaovien";
            LoadDataToGridView(strsql);

            // Xóa textbox tìm kiếm và combobox
            txt_tukhoa.Clear();
            cbb_timkiemtheo.SelectedIndex = -1;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
