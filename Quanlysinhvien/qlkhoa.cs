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
    public partial class qlkhoa : Form
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
                string strsql = "SELECT makhoa AS [Mã khoa], tenkhoa AS [Tên khoa] FROM khoa";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_qlkhoa.DataSource = dtset.Tables[0];
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
        public qlkhoa()
        {
            InitializeComponent();
        }

        private void qlkhoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_qlkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_makhoa.Text = dgv_qlkhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenkhoa.Text = dgv_qlkhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            { }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "INSERT INTO khoa (makhoa, tenkhoa) VALUES (@makhoa, @tenkhoa)";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@makhoa", txt_makhoa.Text.Trim());
                cmd.Parameters.AddWithValue("@tenkhoa", txt_tenkhoa.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "UPDATE khoa SET tenkhoa = @tenkhoa WHERE makhoa = @makhoa";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@makhoa", txt_makhoa.Text.Trim());
                cmd.Parameters.AddWithValue("@tenkhoa", txt_tenkhoa.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "DELETE FROM khoa WHERE makhoa = @makhoa";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@makhoa", txt_makhoa.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_makhoa.Clear();
            txt_tenkhoa.Clear();
        }
    }
}
