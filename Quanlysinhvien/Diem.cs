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
    public partial class Diem : Form
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
                string strsql = "SELECT id  AS [ID], masv AS [Ma sinh vien], mamh AS[Ma mon hoc], diem [Diem] FROM diem";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_diem.DataSource = dtset.Tables[0];
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
        public Diem()
        {
            InitializeComponent();
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_diem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txt_id.Text = dgv_diem.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_masv.Text = dgv_diem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_mamh.Text = dgv_diem.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_diem.Text = dgv_diem.Rows[e.RowIndex].Cells[3].Value.ToString();


            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            In n = new In();    
            n.ShowDialog();
        }

        private void txt_diem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_masv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mamh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
