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
    public partial class qlchinhsach : Form
    {
        private SqlConnection sqlcon;
        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();  // Mở kết nối
        }

        private void LoadData()
        {
            try
            {
                ketnoi();
                string strsql = "SELECT macs AS [Ma chinh sach], tencs AS [Ten chinh sach], chedo AS [Che do] FROM chinhsach";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_qlchinhsach.DataSource = dtset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public qlchinhsach()
        {
            InitializeComponent();
        }

        private void qlchinhsach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_qlchinhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmachinhsach.Text = dgv_qlchinhsach.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenchinhsach.Text = dgv_qlchinhsach.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtchedo.Text = dgv_qlchinhsach.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO chinhsach (macs, tencs, chedo) VALUES (@macs, @tencs, @chedo)";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@macs", txtmachinhsach.Text);
            cmd.Parameters.AddWithValue("@tencs", txttenchinhsach.Text);
            cmd.Parameters.AddWithValue("@chedo", txtchedo.Text);

            try
            {
                ketnoi();  // Mở kết nối trước khi thực hiện truy vấn
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm chính sách thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chính sách: " + ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();  // Đảm bảo kết nối được đóng
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            string query = "UPDATE chinhsach SET tencs = @tencs, chedo = @chedo WHERE macs = @macs";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@macs", txtmachinhsach.Text);
            cmd.Parameters.AddWithValue("@tencs", txttenchinhsach.Text);
            cmd.Parameters.AddWithValue("@chedo", txtchedo.Text);

            try
            {
                ketnoi();  // Mở kết nối trước khi thực hiện truy vấn
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật chính sách thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật chính sách: " + ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();  // Đảm bảo kết nối được đóng
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM chinhsach WHERE macs = @macs";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@macs", txtmachinhsach.Text);

            try
            {
                ketnoi();  // Mở kết nối trước khi thực hiện truy vấn
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa chính sách thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chính sách: " + ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();  // Đảm bảo kết nối được đóng
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txtmachinhsach.Clear();
            txttenchinhsach.Clear();
            txtchedo.Clear();
        }
    }
}
