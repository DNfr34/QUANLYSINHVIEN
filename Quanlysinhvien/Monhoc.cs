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
    public partial class Monhoc : Form
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
                string strsql = "SELECT mamh  AS [Ma mon hoc], tenmh AS [Ten mon hoc], sotiet AS[So tiet], magv[Ma giao vien] FROM monhoc";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_monhoc.DataSource = dtset.Tables[0];
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
        public Monhoc()
        {
            InitializeComponent();
        }

        private void Monhoc_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void dgv_monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txt_mamh.Text = dgv_monhoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenmh.Text = dgv_monhoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_sotiet.Text = dgv_monhoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_magv.Text = dgv_monhoc.Rows[e.RowIndex].Cells[3].Value.ToString();


            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            In n = new In();
            n.Show();
        }

        private void txt_magv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_tenmh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sotiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mamh_TextChanged(object sender, EventArgs e)
        {

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
