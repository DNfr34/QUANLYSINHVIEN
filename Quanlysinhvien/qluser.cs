using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlysinhvien
{
    public partial class qluser : Form
    {
        private SqlConnection sqlcon;

        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }

        public qluser()
        {
            InitializeComponent();
        }

        private void qluser_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu khi form được load
        }

        private void LoadData()
        {
            try
            {
                ketnoi();
                string strsql = "SELECT tk AS [Ten tai khoan], mk AS [Mat Khau] FROM nguoidung";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_user.DataSource = dtset.Tables[0];
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string s = "INSERT INTO nguoidung (tk, mk) VALUES (@tk, @mk)";
                SqlCommand com = new SqlCommand(s, sqlcon);
                com.Parameters.AddWithValue("@tk", txttendn.Text);
                com.Parameters.AddWithValue("@mk", txtmk.Text);
                com.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công!");
                LoadData(); // Tải lại dữ liệu sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đã tồn tại, vui lòng nhập lại", "Báo lỗi", MessageBoxButtons.OKCancel);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "UPDATE nguoidung SET mk = @mk WHERE tk = @tk";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@tk", txttendn.Text);
                cmd.Parameters.AddWithValue("@mk", txtmk.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData(); // Tải lại dữ liệu sau khi cập nhật
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "DELETE FROM nguoidung WHERE tk = @tk";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@tk", txttendn.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData(); // Tải lại dữ liệu sau khi xóa
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_user.Rows[e.RowIndex];
                txttendn.Text = row.Cells["Ten tai khoan"].Value.ToString();
                txtmk.Text = row.Cells["Mat Khau"].Value.ToString();
            }
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {

        }
    }
}
