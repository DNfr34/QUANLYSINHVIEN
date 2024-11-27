using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlysinhvien
{
    public partial class dangki : Form
    {
        private SqlConnection Sqlcon;
        public dangki()
        {
            InitializeComponent();
            Sqlcon = new SqlConnection("Data Source=DESKTOP-FMONPGF\\LOCAL;Initial Catalog=QLSV;Integrated Security=True");
        
         }
        private bool KetNoi()
        {
            try
            {
                if (Sqlcon.State == System.Data.ConnectionState.Closed)
                {
                    Sqlcon.Open();
                    MessageBox.Show("Kết nối thành công");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa kết nối được đến cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }


        private void dangki_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!KetNoi()) return;

            string tk = txttk.Text;
            string mk = txtmk.Text;
            string nlmk = txtnlmk.Text;

            if (txttk.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txttk.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (mk != nlmk)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

          
            try
            {
                
                string checkUserQuery = "SELECT COUNT(*) FROM nguoidung WHERE tk = @tk";
                using (SqlCommand cmd = new SqlCommand(checkUserQuery, Sqlcon))
                {
                    cmd.Parameters.AddWithValue("@tk", tk);
                    int userExists = (int)cmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Tài khoản đã đăng ký", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtmk.Clear();
                        txttk.Clear();
                        txtnlmk.Clear();
                        txttk.Focus();
                        return;
                    }
                }

               
                string insertUserQuery = "INSERT INTO nguoidung (tk, mk) VALUES (@tk, @mk)";
                using (SqlCommand cmd = new SqlCommand(insertUserQuery, Sqlcon))
                {
                    cmd.Parameters.AddWithValue("@tk", tk);
                    cmd.Parameters.AddWithValue("@mk", mk); 
                    cmd.ExecuteNonQuery();
                }

                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?", "Đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dangnhap loginForm = new dangnhap();
                    loginForm.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }
            // ...

            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Sqlcon.Close(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
