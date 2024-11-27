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
    public partial class Updatediem : Form
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
                string strsql = "SELECT id AS [ID], masv AS [Mã SV], mamh AS [Mã MH], diem AS [Điểm] FROM diem";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_uddiem.DataSource = dtset.Tables[0];
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
        public Updatediem()
        {
            InitializeComponent();
        }

        private void Updatediem_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void dgv_uddiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id.Text = dgv_uddiem.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_masv.Text = dgv_uddiem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_mamh.Text = dgv_uddiem.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_diem.Text = dgv_uddiem.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
            
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO diem (id, masv, mamh, diem) VALUES (@id, @masv, @mamh, @diem)";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@masv", txt_masv.Text);
            cmd.Parameters.AddWithValue("@mamh", txt_mamh.Text);
            cmd.Parameters.AddWithValue("@diem", txt_diem.Text);

            try
            {
                ketnoi();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm điểm thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm điểm: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE diem SET masv = @masv, mamh = @mamh, diem = @diem WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@masv", txt_masv.Text);
            cmd.Parameters.AddWithValue("@mamh", txt_mamh.Text);
            cmd.Parameters.AddWithValue("@diem", txt_diem.Text);

            try
            {
                ketnoi();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật điểm thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật điểm: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM diem WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);

            try
            {
                ketnoi();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa điểm thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa điểm: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_masv.Clear();
            txt_mamh.Clear();
            txt_diem.Clear();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
