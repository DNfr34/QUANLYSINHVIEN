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
    public partial class qladmin : Form
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
                string strsql = "SELECT tk AS [Ten tai khoan], mk AS [Mat Khau] FROM nguoidung";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgadmin.DataSource = dtset.Tables[0];
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
        public qladmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgadmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgadmin.Rows[e.RowIndex];
                txttendnad.Text = row.Cells["Ten tai khoan"].Value.ToString();
                txtmkad.Text = row.Cells["Mat Khau"].Value.ToString();
            }
        }

        private void qladmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string s = "INSERT INTO admin (tk, mk) VALUES (@tk, @mk)";
                SqlCommand com = new SqlCommand(s, sqlcon);
                com.Parameters.AddWithValue("@tk", txttendnad.Text);
                com.Parameters.AddWithValue("@mk", txtmkad.Text);
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
                string query = "UPDATE admin SET mk = @mk WHERE tk = @tk";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@tk", txttendnad.Text);
                cmd.Parameters.AddWithValue("@mk", txtmkad.Text);
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
                string query = "DELETE FROM admin WHERE tk = @tk";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@tk", txttendnad.Text);
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

        private void btnnhaplai_Click(object sender, EventArgs e)
        {

        }
    }
}
