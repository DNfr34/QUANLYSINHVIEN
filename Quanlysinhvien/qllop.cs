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
    public partial class qllop : Form
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
                string strsql = "SELECT malop AS [Mã lớp], tenlop AS [Tên lớp], makhoa AS [Mã khoa] FROM lop";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_qllop.DataSource = dtset.Tables[0];
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
        public qllop()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void qllop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_qllop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_malop.Text = dgv_qllop.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenlop.Text = dgv_qllop.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_makhoa.Text = dgv_qllop.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch
            { }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "UPDATE lop SET tenlop = @tenlop, makhoa = @makhoa WHERE malop = @malop";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@malop", txt_malop.Text.Trim());
                cmd.Parameters.AddWithValue("@tenlop", txt_tenlop.Text.Trim());
                cmd.Parameters.AddWithValue("@makhoa", txt_makhoa.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Lỗi khóa ngoại
                {
                    MessageBox.Show("Mã khoa không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "INSERT INTO lop (malop, tenlop, makhoa) VALUES (@malop, @tenlop, @makhoa)";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@malop", txt_malop.Text.Trim());
                cmd.Parameters.AddWithValue("@tenlop", txt_tenlop.Text.Trim());
                cmd.Parameters.AddWithValue("@makhoa", txt_makhoa.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Lỗi khóa ngoại
                {
                    MessageBox.Show("Mã khoa không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                string query = "DELETE FROM lop WHERE malop = @malop";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@malop", txt_malop.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_malop.Clear();
            txt_tenlop.Clear();
            txt_makhoa.Clear();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
