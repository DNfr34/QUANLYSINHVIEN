namespace Quanlysinhvien
{
    partial class qladmin
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
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.dong = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmkad = new System.Windows.Forms.TextBox();
            this.txttendnad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgadmin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.Location = new System.Drawing.Point(207, 342);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnnhaplai.TabIndex = 21;
            this.btnnhaplai.Text = "Nhập lại";
            this.btnnhaplai.UseVisualStyleBackColor = true;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // dong
            // 
            this.dong.Location = new System.Drawing.Point(306, 342);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(75, 23);
            this.dong.TabIndex = 20;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = true;
            this.dong.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(263, 283);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 19;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(361, 283);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 18;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(173, 283);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 17;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmkad
            // 
            this.txtmkad.Location = new System.Drawing.Point(173, 240);
            this.txtmkad.Name = "txtmkad";
            this.txtmkad.Size = new System.Drawing.Size(263, 22);
            this.txtmkad.TabIndex = 16;
            // 
            // txttendnad
            // 
            this.txttendnad.Location = new System.Drawing.Point(173, 187);
            this.txttendnad.Name = "txttendnad";
            this.txttendnad.Size = new System.Drawing.Size(263, 22);
            this.txttendnad.TabIndex = 15;
            this.txttendnad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thông tin tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý tài khoản Admin";
            // 
            // dgadmin
            // 
            this.dgadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadmin.Location = new System.Drawing.Point(477, 137);
            this.dgadmin.Name = "dgadmin";
            this.dgadmin.RowHeadersWidth = 51;
            this.dgadmin.RowTemplate.Height = 24;
            this.dgadmin.Size = new System.Drawing.Size(482, 228);
            this.dgadmin.TabIndex = 22;
            this.dgadmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadmin_CellClick);
            // 
            // qladmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 489);
            this.Controls.Add(this.dgadmin);
            this.Controls.Add(this.btnnhaplai);
            this.Controls.Add(this.dong);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmkad);
            this.Controls.Add(this.txttendnad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "qladmin";
            this.Text = "qladmin";
            this.Load += new System.EventHandler(this.qladmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmkad;
        private System.Windows.Forms.TextBox txttendnad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgadmin;
    }
}