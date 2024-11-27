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
    public partial class Chinhsach : Form
    {
        private SqlConnection sqlcon;

        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        public Chinhsach()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chinhsach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                ketnoi();
                string strsql = "SELECT macs AS [Ma chinh sach], tencs AS [Ten chinh sach], chedo AS[Che do] FROM chinhsach";
                DataSet dtset = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strsql, sqlcon);
                dataAdapter.Fill(dtset);
                this.dgv_chinhsach.DataSource = dtset.Tables[0];
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

        private void dgv_chinhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmachinhsach.Text = dgv_chinhsach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenchinhsach.Text = dgv_chinhsach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtchedo.Text = dgv_chinhsach.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch 
            { }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            In f = new In();
            f.ShowDialog();
        }
    }
}
