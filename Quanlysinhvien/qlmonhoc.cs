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
    public partial class qlmonhoc : Form
    {
        private SqlConnection sqlcon;
        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        private void LoadData()
        {
            try
            {
                ketnoi();
                string strsql = "SELECT mamh AS [Ma mon hoc], tenmh AS [Ten mon hoc], sotiet AS [So tiet], magv AS [Ma giao vien] FROM monhoc"; // Sửa bảng giaovien thành monhoc
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_qlmonhoc.DataSource = dtset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public qlmonhoc()
        {
            InitializeComponent();
        }

        private void dgv_monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)  // Kiểm tra chỉ xử lý khi click vào dữ liệu, tránh lỗi
                {
                    txt_mamh.Text = dgv_qlmonhoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_tenmh.Text = dgv_qlmonhoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_sotiet.Text = dgv_qlmonhoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_magv.Text = dgv_qlmonhoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void qlmonhoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();  // Mở kết nối trước khi thực hiện truy vấn

                // Kiểm tra nhập liệu
                if (string.IsNullOrWhiteSpace(txt_mamh.Text) || string.IsNullOrWhiteSpace(txt_tenmh.Text) || string.IsNullOrWhiteSpace(txt_sotiet.Text) || string.IsNullOrWhiteSpace(txt_magv.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO monhoc (mamh, tenmh, sotiet, magv) VALUES (@mamh, @tenmh, @sotiet, @magv)";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@mamh", txt_mamh.Text.Trim());
                cmd.Parameters.AddWithValue("@tenmh", txt_tenmh.Text.Trim());
                cmd.Parameters.AddWithValue("@sotiet", Convert.ToInt32(txt_sotiet.Text.Trim()));
                cmd.Parameters.AddWithValue("@magv", txt_magv.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm môn học thành công!");
                LoadData();  // Tải lại dữ liệu sau khi thêm
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Lỗi khóa ngoại
                {
                    MessageBox.Show("Mã giáo viên không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();  // Đảm bảo kết nối được đóng sau khi hoàn thành
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();  // Mở kết nối trước khi thực hiện truy vấn

                // Kiểm tra nhập liệu
                if (string.IsNullOrWhiteSpace(txt_mamh.Text) || string.IsNullOrWhiteSpace(txt_tenmh.Text) || string.IsNullOrWhiteSpace(txt_sotiet.Text) || string.IsNullOrWhiteSpace(txt_magv.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "UPDATE monhoc SET tenmh = @tenmh, sotiet = @sotiet, magv = @magv WHERE mamh = @mamh";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@mamh", txt_mamh.Text.Trim());
                cmd.Parameters.AddWithValue("@tenmh", txt_tenmh.Text.Trim());
                cmd.Parameters.AddWithValue("@sotiet", Convert.ToInt32(txt_sotiet.Text.Trim()));
                cmd.Parameters.AddWithValue("@magv", txt_magv.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật môn học thành công!");
                LoadData();  // Tải lại dữ liệu sau khi cập nhật
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Lỗi khóa ngoại
                {
                    MessageBox.Show("Mã giáo viên không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();  // Đảm bảo kết nối được đóng sau khi hoàn thành
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            try
            {
                ketnoi();  // Mở kết nối trước khi thực hiện truy vấn

                // Kiểm tra mã môn học trước khi xóa
                if (string.IsNullOrWhiteSpace(txt_mamh.Text))
                {
                    MessageBox.Show("Vui lòng chọn môn học để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "DELETE FROM monhoc WHERE mamh = @mamh";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@mamh", txt_mamh.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa môn học thành công!");
                LoadData();  // Tải lại dữ liệu sau khi xóa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();  // Đảm bảo kết nối được đóng sau khi hoàn thành
            }
        }
    }
}
