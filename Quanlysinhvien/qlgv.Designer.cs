namespace Quanlysinhvien
{
    partial class qlgv
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
            this.dgv_qlgv = new System.Windows.Forms.DataGridView();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tengv = new System.Windows.Forms.TextBox();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_qlgv
            // 
            this.dgv_qlgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlgv.Location = new System.Drawing.Point(372, 104);
            this.dgv_qlgv.Name = "dgv_qlgv";
            this.dgv_qlgv.RowHeadersWidth = 51;
            this.dgv_qlgv.RowTemplate.Height = 24;
            this.dgv_qlgv.Size = new System.Drawing.Size(516, 288);
            this.dgv_qlgv.TabIndex = 20;
            this.dgv_qlgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlgv_CellContentClick);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai.Location = new System.Drawing.Point(98, 381);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(118, 31);
            this.btn_nhaplai.TabIndex = 19;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.Location = new System.Drawing.Point(222, 381);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(113, 31);
            this.btn_dong.TabIndex = 18;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(179, 339);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 36);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(260, 339);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 36);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(98, 339);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 36);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tengv
            // 
            this.txt_tengv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tengv.Location = new System.Drawing.Point(143, 156);
            this.txt_tengv.Name = "txt_tengv";
            this.txt_tengv.Size = new System.Drawing.Size(198, 30);
            this.txt_tengv.TabIndex = 14;
            // 
            // txt_magv
            // 
            this.txt_magv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_magv.Location = new System.Drawing.Point(143, 120);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(198, 30);
            this.txt_magv.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản Lý Giáo Viên";
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaysinh.Location = new System.Drawing.Point(143, 198);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(198, 30);
            this.txt_ngaysinh.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Địa chỉ";
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sodienthoai.Location = new System.Drawing.Point(143, 234);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(198, 30);
            this.txt_sodienthoai.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày sinh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(143, 270);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(198, 30);
            this.txt_diachi.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Số điện thoại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // qlgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 462);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sodienthoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ngaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_qlgv);
            this.Controls.Add(this.btn_nhaplai);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tengv);
            this.Controls.Add(this.txt_magv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "qlgv";
            this.Text = "qlgv";
            this.Load += new System.EventHandler(this.qlgv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qlgv;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_tengv;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label6;
    }
}