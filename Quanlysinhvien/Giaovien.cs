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
    public partial class Giaovien : Form
    {
        private SqlConnection sqlcon;

        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        public Giaovien()
        {
            InitializeComponent();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            In f = new In();
            f.ShowDialog();
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            try
            {
                ketnoi();
                string strsql = "SELECT magv  AS [Ma giao vien], tengv AS [Ten giao vien], gioitinh AS[Gioi tinh], ngaysinh[Ngay sinh], sdt[So dien thoai], diachi[Dia chi] FROM giaovien";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_giaovien.DataSource = dtset.Tables[0];
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

        private void Giaovien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_giaovien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_magv.Text = dgv_giaovien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tengv.Text = dgv_giaovien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_gioitinh.Text = dgv_giaovien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_ngaysinh.Text = dgv_giaovien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_sdt.Text = dgv_giaovien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_diachi.Text = dgv_giaovien.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
            catch
            { }
        }
    }
}
