using System;

namespace Quanlysinhvien
{
    partial class qlmonhoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenmh = new System.Windows.Forms.TextBox();
            this.txt_sotiet = new System.Windows.Forms.TextBox();
            this.txt_mamh = new System.Windows.Forms.TextBox();
            this.dgv_qlmonhoc = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlmonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_magv
            // 
            this.txt_magv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_magv.Location = new System.Drawing.Point(137, 253);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(162, 27);
            this.txt_magv.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã giáo viên";
            // 
            // txt_tenmh
            // 
            this.txt_tenmh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmh.Location = new System.Drawing.Point(137, 170);
            this.txt_tenmh.Name = "txt_tenmh";
            this.txt_tenmh.Size = new System.Drawing.Size(162, 27);
            this.txt_tenmh.TabIndex = 18;
            // 
            // txt_sotiet
            // 
            this.txt_sotiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotiet.Location = new System.Drawing.Point(137, 215);
            this.txt_sotiet.Name = "txt_sotiet";
            this.txt_sotiet.Size = new System.Drawing.Size(162, 27);
            this.txt_sotiet.TabIndex = 17;
            // 
            // txt_mamh
            // 
            this.txt_mamh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mamh.Location = new System.Drawing.Point(137, 127);
            this.txt_mamh.Name = "txt_mamh";
            this.txt_mamh.Size = new System.Drawing.Size(162, 27);
            this.txt_mamh.TabIndex = 16;
            // 
            // dgv_qlmonhoc
            // 
            this.dgv_qlmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlmonhoc.Location = new System.Drawing.Point(318, 127);
            this.dgv_qlmonhoc.Name = "dgv_qlmonhoc";
            this.dgv_qlmonhoc.RowHeadersWidth = 51;
            this.dgv_qlmonhoc.RowTemplate.Height = 24;
            this.dgv_qlmonhoc.Size = new System.Drawing.Size(506, 259);
            this.dgv_qlmonhoc.TabIndex = 15;
            this.dgv_qlmonhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_monhoc_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã môn học";
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai.Location = new System.Drawing.Point(56, 341);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(118, 31);
            this.btn_nhaplai.TabIndex = 25;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.Location = new System.Drawing.Point(180, 341);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(113, 31);
            this.btn_dong.TabIndex = 24;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(137, 299);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 36);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(218, 299);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 36);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(56, 299);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 36);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quản Lý Môn Học";
            // 
            // qlmonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nhaplai);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_magv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tenmh);
            this.Controls.Add(this.txt_sotiet);
            this.Controls.Add(this.txt_mamh);
            this.Controls.Add(this.dgv_qlmonhoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "qlmonhoc";
            this.Text = "qlmonhoc";
            this.Load += new System.EventHandler(this.qlmonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlmonhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenmh;
        private System.Windows.Forms.TextBox txt_sotiet;
        private System.Windows.Forms.TextBox txt_mamh;
        private System.Windows.Forms.DataGridView dgv_qlmonhoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
    }
}