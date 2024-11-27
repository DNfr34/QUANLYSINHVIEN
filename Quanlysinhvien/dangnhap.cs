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
   
    public partial class dangnhap : Form
    {
        int sai = 5;
        private SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        DataSet ds;
        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);

            sqlcon.Open();
        }
        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoi();

            // Kiểm tra trong bảng tkadmin
            string sqlAdmin = "SELECT COUNT(*) FROM admin WHERE tk = @tk AND mk = @mk";
            SqlCommand sqlcomAdmin = new SqlCommand(sqlAdmin, sqlcon);
            sqlcomAdmin.Parameters.AddWithValue("tk", txttk.Text);
            sqlcomAdmin.Parameters.AddWithValue("mk", txtmk.Text);

            int isAdmin = (int)sqlcomAdmin.ExecuteScalar();

            if (isAdmin > 0)
            {
                // Nếu là tài khoản Admin
                MessageBox.Show("Bạn đang đăng nhập bằng tài khoản Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Admin mf = new Admin();
                mf.ShowDialog();
                this.Show();
            }
            else
            {
                // Kiểm tra trong bảng tkuser nếu không phải Admin
                string sqlUser = "SELECT COUNT(*) FROM nguoidung WHERE tk = @tk AND mk = @mk";
                SqlCommand sqlcomUser = new SqlCommand(sqlUser, sqlcon);
                sqlcomUser.Parameters.AddWithValue("tk", txttk.Text);
                sqlcomUser.Parameters.AddWithValue("mk", txtmk.Text);

                int isUser = (int)sqlcomUser.ExecuteScalar();

                if (isUser > 0)
                {
                    // Nếu là tài khoản người dùng
                    MessageBox.Show("Đăng nhập thành công bằng tài khoản người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    user thongTinForm = new user();
                    thongTinForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            sqlcon.Close(); // Đóng kết nối sau khi kiểm tra
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    
