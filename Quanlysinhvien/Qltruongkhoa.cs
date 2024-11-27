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
    public partial class Qltruongkhoa : Form
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
                string query = "SELECT tk AS [Tài khoản], mk AS [Mật khẩu] FROM truongkhoa";
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlcon);
                dataAdapter.Fill(dataSet);
                this.dga_trgk.DataSource = dataSet.Tables[0];
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
        public Qltruongkhoa()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                string query = "INSERT INTO truongkhoa (tk, mk) VALUES (@tk, @mk)";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@tk", txt_tentrgk.Text);
                cmd.Parameters.AddWithValue("@mk", txt_mktk.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm trưởng khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm trưởng khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "UPDATE truongkhoa SET mk = @mk WHERE tk = @tk";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@tk", txt_tentrgk.Text);
                cmd.Parameters.AddWithValue("@mk", txt_mktk.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thông tin trưởng khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin trưởng khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "DELETE FROM truongkhoa WHERE tk = @tk";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@tk", txt_tentrgk.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa trưởng khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa trưởng khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txt_tentrgk.Clear();
            txt_mktk.Clear();
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Qltruongkhoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dga_trgk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tentrgk.Text = dga_trgk.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_mktk.Text = dga_trgk.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
