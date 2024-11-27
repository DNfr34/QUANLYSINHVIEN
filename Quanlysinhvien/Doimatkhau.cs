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
    public partial class Doimatkhau : Form
    {
        private SqlConnection sqlcon;

        public void ketnoi()
        {
            string connectionString = "Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void Doimatkhau_Load(object sender, EventArgs e)
        {

        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_taikhoan.Text) ||
        string.IsNullOrWhiteSpace(txt_matkhaucu.Text) ||
        string.IsNullOrWhiteSpace(txt_matkhaumoi.Text) ||
        string.IsNullOrWhiteSpace(txt_nhaplaimk.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_matkhaumoi.Text != txt_nhaplaimk.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi();

                // Kiểm tra trong bảng admin
                string sqlCheckAdmin = "SELECT COUNT(*) FROM admin WHERE tk = @tk AND mk = @mk";
                SqlCommand cmdCheckAdmin = new SqlCommand(sqlCheckAdmin, sqlcon);
                cmdCheckAdmin.Parameters.AddWithValue("@tk", txt_taikhoan.Text);
                cmdCheckAdmin.Parameters.AddWithValue("@mk", txt_matkhaucu.Text);

                int isAdmin = (int)cmdCheckAdmin.ExecuteScalar();

                if (isAdmin > 0)
                {
                    // Cập nhật mật khẩu trong bảng admin
                    string sqlUpdateAdmin = "UPDATE admin SET mk = @matkhaumoi WHERE tk = @tk";
                    SqlCommand cmdUpdateAdmin = new SqlCommand(sqlUpdateAdmin, sqlcon);
                    cmdUpdateAdmin.Parameters.AddWithValue("@tk", txt_taikhoan.Text);
                    cmdUpdateAdmin.Parameters.AddWithValue("@matkhaumoi", txt_matkhaumoi.Text);
                    cmdUpdateAdmin.ExecuteNonQuery();

                    MessageBox.Show("Đổi mật khẩu thành công cho Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Kiểm tra trong bảng nguoidung
                    string sqlCheckUser = "SELECT COUNT(*) FROM nguoidung WHERE tk = @tk AND mk = @mk";
                    SqlCommand cmdCheckUser = new SqlCommand(sqlCheckUser, sqlcon);
                    cmdCheckUser.Parameters.AddWithValue("@tk", txt_taikhoan.Text);
                    cmdCheckUser.Parameters.AddWithValue("@mk", txt_matkhaucu.Text);

                    int isUser = (int)cmdCheckUser.ExecuteScalar();

                    if (isUser > 0)
                    {
                        // Cập nhật mật khẩu trong bảng nguoidung
                        string sqlUpdateUser = "UPDATE nguoidung SET mk = @matkhaumoi WHERE tk = @tk";
                        SqlCommand cmdUpdateUser = new SqlCommand(sqlUpdateUser, sqlcon);
                        cmdUpdateUser.Parameters.AddWithValue("@tk", txt_taikhoan.Text);
                        cmdUpdateUser.Parameters.AddWithValue("@matkhaumoi", txt_matkhaumoi.Text);
                        cmdUpdateUser.ExecuteNonQuery();

                        MessageBox.Show("Đổi mật khẩu thành công cho Người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
