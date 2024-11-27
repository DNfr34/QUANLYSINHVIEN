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
    public partial class timkiemsv : Form
    {
        private SqlConnection sqlcon;

        public timkiemsv()
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
                dgv_tksv.DataSource = dt;
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
                string strsql = "SELECT masv AS [Mã Sinh Viên], tensv AS [Tên Sinh Viên], gioitinh AS [Giới Tính], " +
                                "ngaysinh AS [Ngày Sinh], sdt AS [Số Điện Thoại], diachi AS [Địa Chỉ], macs AS [Mã Chính Sách], " +
                                "malop AS [Mã Lớp] FROM sinhvien ";

                if (criteria == "Địa chỉ")
                {
                    strsql += "WHERE diachi LIKE @value";
                }
                else if (criteria == "Tên")
                {
                    strsql += "WHERE tensv LIKE @value";
                }
                else if (criteria == "Mã sinh viên")
                {
                    strsql += "WHERE masv LIKE @value";
                }
                else if (criteria == "Ngày sinh")
                {
                    strsql += "WHERE CONVERT(VARCHAR, ngaysinh, 103) = @value";
                }
                else if (criteria == "Mã chính sách")
                {
                    strsql += "WHERE macs LIKE @value";
                }

                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                if (criteria == "Ngày sinh")
                {
                    cmd.Parameters.AddWithValue("@value", value); // Định dạng dd/MM/yyyy cho ngày sinh
                }
                else
                {
                    cmd.Parameters.AddWithValue("@value", "%" + value + "%");
                }

                // Hiển thị kết quả tìm kiếm
                SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dtadapter.Fill(dt);
                dgv_tksv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_loadlai_Click(object sender, EventArgs e)
        {
            string strsql = "SELECT masv AS [Mã Sinh Viên], tensv AS [Tên Sinh Viên], gioitinh AS [Giới Tính], " +
                            "ngaysinh AS [Ngày Sinh], sdt AS [Số Điện Thoại], diachi AS [Địa Chỉ], macs AS [Mã Chính Sách], " +
                            "malop AS [Mã Lớp] FROM sinhvien";
            LoadDataToGridView(strsql);

            // Xóa TextBox tìm kiếm và ComboBox
            txt_tukhoa.Clear();
            cbb_timkiemtheo.SelectedIndex = -1;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timkiemsv_Load(object sender, EventArgs e)
        {
            KetNoi();

            // Thêm các tiêu chí vào ComboBox
            cbb_timkiemtheo.Items.Add("Địa chỉ");
            cbb_timkiemtheo.Items.Add("Tên");
            cbb_timkiemtheo.Items.Add("Mã sinh viên");
            cbb_timkiemtheo.Items.Add("Ngày sinh");
            cbb_timkiemtheo.Items.Add("Mã chính sách");

            // Hiển thị dữ liệu mặc định
            string strsql = "SELECT masv AS [Mã Sinh Viên], tensv AS [Tên Sinh Viên], gioitinh AS [Giới Tính], " +
                            "ngaysinh AS [Ngày Sinh], sdt AS [Số Điện Thoại], diachi AS [Địa Chỉ], macs AS [Mã Chính Sách], " +
                            "malop AS [Mã Lớp] FROM sinhvien";
            LoadDataToGridView(strsql);
        }
    }
}
