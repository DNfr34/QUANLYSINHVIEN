namespace Quanlysinhvien
{
    partial class Qltruongkhoa
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
            this.dga_trgk = new System.Windows.Forms.DataGridView();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.dong = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txt_mktk = new System.Windows.Forms.TextBox();
            this.txt_tentrgk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dga_trgk)).BeginInit();
            this.SuspendLayout();
            // 
            // dga_trgk
            // 
            this.dga_trgk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dga_trgk.Location = new System.Drawing.Point(443, 205);
            this.dga_trgk.Name = "dga_trgk";
            this.dga_trgk.RowHeadersWidth = 51;
            this.dga_trgk.RowTemplate.Height = 24;
            this.dga_trgk.Size = new System.Drawing.Size(482, 228);
            this.dga_trgk.TabIndex = 34;
            this.dga_trgk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dga_trgk_CellContentClick);
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.Location = new System.Drawing.Point(173, 410);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnnhaplai.TabIndex = 33;
            this.btnnhaplai.Text = "Nhập lại";
            this.btnnhaplai.UseVisualStyleBackColor = true;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // dong
            // 
            this.dong.Location = new System.Drawing.Point(272, 410);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(75, 23);
            this.dong.TabIndex = 32;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = true;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(229, 351);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 31;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(327, 351);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 30;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(139, 351);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 29;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txt_mktk
            // 
            this.txt_mktk.Location = new System.Drawing.Point(139, 308);
            this.txt_mktk.Name = "txt_mktk";
            this.txt_mktk.Size = new System.Drawing.Size(263, 22);
            this.txt_mktk.TabIndex = 28;
            // 
            // txt_tentrgk
            // 
            this.txt_tentrgk.Location = new System.Drawing.Point(139, 255);
            this.txt_tentrgk.Name = "txt_tentrgk";
            this.txt_tentrgk.Size = new System.Drawing.Size(263, 22);
            this.txt_tentrgk.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Thông tin tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quản lý tài khoản trưởng khoa";
            // 
            // Qltruongkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 536);
            this.Controls.Add(this.dga_trgk);
            this.Controls.Add(this.btnnhaplai);
            this.Controls.Add(this.dong);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txt_mktk);
            this.Controls.Add(this.txt_tentrgk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Qltruongkhoa";
            this.Text = "Qltruongkhoa";
            this.Load += new System.EventHandler(this.Qltruongkhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dga_trgk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dga_trgk;
        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txt_mktk;
        private System.Windows.Forms.TextBox txt_tentrgk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}