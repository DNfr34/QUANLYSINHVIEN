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
    public partial class Khoa : Form
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
                string strsql = "SELECT makhoa  AS [Ma khoa], tenkhoa AS [Ten khoa] FROM khoa";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_khoa.DataSource = dtset.Tables[0];
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
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txt_makhoa.Text = dgv_khoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenkhoa.Text = dgv_khoa.Rows[e.RowIndex].Cells[1].Value.ToString();
             


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
    }
}
