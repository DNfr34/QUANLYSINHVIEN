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
    public partial class qlsv : Form
    {
        private SqlConnection sqlcon;
        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        public qlsv()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                ketnoi();
                string strsql = "SELECT masv  AS [Ma sinh vien], tensv AS [Ten sinh vien], gioitinh AS[Gioi tinh], ngaysinh[Ngay sinh], sdt[So dien thoai], diachi[Dia chi], macs [Ma CS], malop [Ma lop] FROM sinhvien";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_qlsinhvien.DataSource = dtset.Tables[0];
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

        private void qlsv_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_qlsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txt_masv.Text = dgv_qlsinhvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tensv.Text = dgv_qlsinhvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_gt.Text = dgv_qlsinhvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_ngaysinh.Text = dgv_qlsinhvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_sdt.Text = dgv_qlsinhvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_diachi.Text = dgv_qlsinhvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_macs.Text = dgv_qlsinhvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_malop.Text = dgv_qlsinhvien.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch
            { }
        }
        private bool KiemTraTrungMaSV(string masv)
        {
            string query = "SELECT COUNT(*) FROM sinhvien WHERE masv = @masv";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@masv", masv);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                if (KiemTraTrungMaSV(txt_masv.Text))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.");
                    return;
                }

                string s = "INSERT INTO sinhvien (masv, tensv, gioitinh, ngaysinh, sdt, diachi, macs, malop) VALUES (@masv, @tensv, @gioitinh, @ngaysinh, @sdt, @diachi, @macs, @malop)";
                SqlCommand com = new SqlCommand(s, sqlcon);
                com.Parameters.AddWithValue("@masv", txt_masv.Text);
                com.Parameters.AddWithValue("@tensv", txt_tensv.Text);
                com.Parameters.AddWithValue("@gioitinh", txt_gt.Text);
                com.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txt_ngaysinh.Text));
                com.Parameters.AddWithValue("@sdt", txt_sdt.Text);
                com.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                com.Parameters.AddWithValue("@macs", txt_macs.Text);
                com.Parameters.AddWithValue("@malop", txt_malop.Text);
                com.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_masv.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.");
                return;
            }

            try
            {
                ketnoi();
                string query = "UPDATE sinhvien SET tensv = @tensv, gioitinh = @gioitinh, ngaysinh = @ngaysinh, sdt = @sdt, diachi = @diachi, macs = @macs, malop = @malop WHERE masv = @masv";
                SqlCommand cmd = new SqlCommand(query, sqlcon);

                cmd.Parameters.AddWithValue("@masv", txt_masv.Text);
                cmd.Parameters.AddWithValue("@tensv", txt_tensv.Text);
                cmd.Parameters.AddWithValue("@gioitinh", txt_gt.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txt_ngaysinh.Text));
                cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text);
                cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@macs", txt_macs.Text);
                cmd.Parameters.AddWithValue("@malop", txt_malop.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData(); // Tải lại dữ liệu sau khi cập nhật
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message);
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_masv.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ketnoi();

                    // Xóa tất cả bản ghi liên quan trong bảng "diem" trước khi xóa sinh viên
                    string deleteDiemQuery = "DELETE FROM diem WHERE masv = @masv";
                    SqlCommand deleteDiemCmd = new SqlCommand(deleteDiemQuery, sqlcon);
                    deleteDiemCmd.Parameters.AddWithValue("@masv", txt_masv.Text);
                    deleteDiemCmd.ExecuteNonQuery();

                    // Xóa sinh viên trong bảng "sinhvien"
                    string deleteSinhVienQuery = "DELETE FROM sinhvien WHERE masv = @masv";
                    SqlCommand deleteSinhVienCmd = new SqlCommand(deleteSinhVienQuery, sqlcon);
                    deleteSinhVienCmd.Parameters.AddWithValue("@masv", txt_masv.Text);
                    int rowsAffected = deleteSinhVienCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData(); // Tải lại dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên cần xóa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
                }
                finally
                {
                    sqlcon.Close();
                }
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_masv.Clear();
            txt_tensv.Clear();
            txt_gt.Clear();
            txt_ngaysinh.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            txt_macs.Clear();
            txt_malop.Clear();
        }
    }
}
