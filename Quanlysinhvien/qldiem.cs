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
    public partial class qldiem : Form
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
                string strsql = "SELECT id AS [id], masv AS [Ma sinh vien], mamh AS [Ma mon hoc], diem AS [Diem] FROM diem"; // Sửa dấu phẩy ở đây
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_qldiem.DataSource = dtset.Tables[0];
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

        public qldiem()
        {
            InitializeComponent();
        }

        private void dgv_qldiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)  // Kiểm tra chắc chắn là người dùng đã click vào một dòng dữ liệu
                {
                    txt_id.Text = dgv_qldiem.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_masv.Text = dgv_qldiem.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_mamh.Text = dgv_qldiem.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_diem.Text = dgv_qldiem.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void qldiem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
