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
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dangnhap dangnhap = new dangnhap();
            dangnhap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Left <= this.Width)
            {
                label2.Left = label2.Left + 50;
            }
            else
            {
                label2.Left = -label2.Left;
            }
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            dangki dangki = new dangki();
            dangki.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnthongtin_Click(object sender, EventArgs e)
        {
            Thôngtinsv thongtin = new Thôngtinsv();
            thongtin.Show();
        }
    }
}
