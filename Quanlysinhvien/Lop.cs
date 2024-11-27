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

    public partial class Lop : Form
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
                string strsql = "SELECT malop  AS [Ma lop], tenlop AS [Ten lop], makhoa AS[Ma khoa] FROM lop";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_lop.DataSource = dtset.Tables[0];
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
        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_malop.Text = dgv_lop.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tenlop.Text = dgv_lop.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_makhoa.Text = dgv_lop.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            In n = new In();
            n.ShowDialog();
        }
    }
}
