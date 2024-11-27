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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qluser  u = new qluser();
            u.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dangnhap = new dangnhap();
            dangnhap.ShowDialog();
        }

        private void quảnLýTàiKhoảnAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qladmin u = new qladmin();  
            u.ShowDialog();
        }

        private void chínhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemchinhsach tk = new timkiemchinhsach();
            tk.ShowDialog();
        }

        private void chínhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chinhsach NEW = new Chinhsach();
            NEW.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaovien giaovien = new Giaovien();
            giaovien.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sinhvien sv  = new Sinhvien();  
            sv.ShowDialog();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monhoc mh = new Monhoc();
            mh.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem();
            diem.ShowDialog();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khoa k = new Khoa();    
            k.ShowDialog();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop l   = new Lop();
            l.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemkhoa tkk = new timkiemkhoa();
            tkk.ShowDialog();
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemgiaovien tkgv = new timkiemgiaovien();   
            tkgv.ShowDialog();
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemlop timkiemlop = new timkiemlop();
            timkiemlop.ShowDialog();
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemsv timkiemsv = new timkiemsv();
            timkiemsv.ShowDialog();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemmonhoc tkcs = new timkiemmonhoc();
            tkcs.ShowDialog();
        }

        private void khoaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qlkhoa tkk = new qlkhoa();
            tkk.ShowDialog();
        }

        private void giáoViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qlgv gi = new qlgv();
            gi.ShowDialog();
        }

        private void lớpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qllop qllop = new qllop();
            qllop.ShowDialog();
        }

        private void sinhViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qlsv sinh = new qlsv();
            sinh.ShowDialog();
        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qlmonhoc tkmon = new qlmonhoc();    
            tkmon.ShowDialog();
        }

        private void chínhSáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qlchinhsach tk = new qlchinhsach();
            tk.ShowDialog();
        }

        private void điểmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qldiem qldiem = new qldiem();
            qldiem.ShowDialog();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Updatediem diem = new Updatediem();
            diem.ShowDialog();
        }

        private void quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qltruongkhoa qltruongkhoa = new Qltruongkhoa();
            qltruongkhoa.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doimatkhau dmk = new Doimatkhau();
            dmk.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form Admin hiện tại
            dangnhap loginForm = new dangnhap();
            loginForm.Show();
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thôngtinsv thôngtinsv  = new Thôngtinsv();
            thôngtinsv.ShowDialog();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact ct = new Contact();
            ct.ShowDialog();
        }
    }
}
