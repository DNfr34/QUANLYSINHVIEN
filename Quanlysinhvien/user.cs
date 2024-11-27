using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void tiệnIchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.ShowDialog();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaovien gv = new Giaovien();   
            gv.ShowDialog();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sinhvien sinhvien = new Sinhvien();
            sinhvien.ShowDialog();   
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monhoc monhoc = new Monhoc();
            monhoc.ShowDialog();
        }

        private void chínhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chinhsach chinhsach = new Chinhsach();
            chinhsach.ShowDialog();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem();
            diem.ShowDialog();
        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemkhoa timkiemkhoa = new timkiemkhoa();
            timkiemkhoa.ShowDialog();
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemlop timkiemlop = new timkiemlop();
            timkiemlop.ShowDialog();
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemgiaovien timkiemgiaovien = new timkiemgiaovien();
            timkiemgiaovien.ShowDialog();
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemsv timkiemsv = new timkiemsv();
            timkiemsv.ShowDialog();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemmonhoc tim = new timkiemmonhoc();    
            tim.ShowDialog();
        }

        private void chínhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemchinhsach tk = new timkiemchinhsach();
            tk.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form Admin hiện tại
            dangnhap loginForm = new dangnhap();
            loginForm.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doimatkhau doimatkhau = new Doimatkhau();
            doimatkhau.ShowDialog();
        }
    }
}
