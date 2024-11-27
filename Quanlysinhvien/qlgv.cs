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
    public partial class qlgv : Form
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
                string strsql = "SELECT magv AS [Ma giao vien], tengv AS [Ten giao vien], ngaysinh AS [Ngay sinh], sdt AS [So dien thoai], diachi AS [Dia chi] FROM giaovien";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_qlgv.DataSource = dtset.Tables[0];
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

        public qlgv()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_magv.Clear();
            txt_tengv.Clear();
            txt_ngaysinh.Clear();
            txt_sodienthoai.Clear();
            txt_diachi.Clear();
        }

        private void dgv_qlgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_qlgv.Rows[e.RowIndex];

                // Hiển thị dữ liệu từ các ô của hàng đã chọn vào các TextBox
                txt_magv.Text = row.Cells["Ma giao vien"].Value.ToString();
                txt_tengv.Text = row.Cells["Ten giao vien"].Value.ToString();
                txt_ngaysinh.Text = row.Cells["Ngay sinh"].Value.ToString();
                txt_sodienthoai.Text = row.Cells["So dien thoai"].Value.ToString();
                txt_diachi.Text = row.Cells["Dia chi"].Value.ToString();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_magv.Text))
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần sửa.");
                return;
            }

            try
            {
                ketnoi();
                string query = "UPDATE giaovien SET tengv = @tengv, ngaysinh = @ngaysinh, sdt = @sdt, diachi = @diachi WHERE magv = @magv";
                SqlCommand cmd = new SqlCommand(query, sqlcon);

                cmd.Parameters.AddWithValue("@magv", txt_magv.Text);
                cmd.Parameters.AddWithValue("@tengv", txt_tengv.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txt_ngaysinh.Text));
                cmd.Parameters.AddWithValue("@sdt", txt_sodienthoai.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật giáo viên thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giáo viên cần sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật giáo viên: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_magv.Text))
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xóa.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa giáo viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ketnoi();

                    // Xóa tất cả bản ghi liên quan trong bảng "diem" trước khi xóa môn học
                    string deleteDiemQuery = "DELETE FROM diem WHERE mamh IN (SELECT mamh FROM monhoc WHERE magv = @magv)";
                    SqlCommand deleteDiemCmd = new SqlCommand(deleteDiemQuery, sqlcon);
                    deleteDiemCmd.Parameters.AddWithValue("@magv", txt_magv.Text);
                    deleteDiemCmd.ExecuteNonQuery();

                    // Xóa tất cả môn học liên quan trong bảng "monhoc"
                    string deleteMonHocQuery = "DELETE FROM monhoc WHERE magv = @magv";
                    SqlCommand deleteMonHocCmd = new SqlCommand(deleteMonHocQuery, sqlcon);
                    deleteMonHocCmd.Parameters.AddWithValue("@magv", txt_magv.Text);
                    deleteMonHocCmd.ExecuteNonQuery();

                    // Xóa giáo viên trong bảng "giaovien"
                    string deleteGiaoVienQuery = "DELETE FROM giaovien WHERE magv = @magv";
                    SqlCommand deleteGiaoVienCmd = new SqlCommand(deleteGiaoVienQuery, sqlcon);
                    deleteGiaoVienCmd.Parameters.AddWithValue("@magv", txt_magv.Text);
                    deleteGiaoVienCmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa giáo viên thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa giáo viên: " + ex.Message);
                }
                finally
                {
                    sqlcon.Close();
                }

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "INSERT INTO giaovien (magv, tengv, ngaysinh, sdt, diachi) VALUES (@magv, @tengv, @ngaysinh, @sdt, @diachi)";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@magv", txt_magv.Text);
                cmd.Parameters.AddWithValue("@tengv", txt_tengv.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txt_ngaysinh.Text));
                cmd.Parameters.AddWithValue("@sdt", txt_sodienthoai.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm giáo viên thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm giáo viên: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qlgv_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
