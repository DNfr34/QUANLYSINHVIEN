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
    public partial class Sinhvien : Form
    {
        private SqlConnection sqlcon;

        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        public Sinhvien()
        {
            InitializeComponent();
        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {
            LoadData();
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
                this.dgv_sinhvien.DataSource = dtset.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            In f = new In();    
            f.ShowDialog();
        }

        private void dgv_sinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txt_masv.Text = dgv_sinhvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tensv.Text = dgv_sinhvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_gt.Text = dgv_sinhvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_ngaysinh.Text = dgv_sinhvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_sdt.Text = dgv_sinhvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_diachi.Text = dgv_sinhvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_macs.Text = dgv_sinhvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_malop.Text = dgv_sinhvien.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
