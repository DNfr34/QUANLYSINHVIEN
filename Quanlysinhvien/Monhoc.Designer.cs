namespace Quanlysinhvien
{
    partial class Monhoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_monhoc = new System.Windows.Forms.DataGridView();
            this.txt_mamh = new System.Windows.Forms.TextBox();
            this.txt_sotiet = new System.Windows.Forms.TextBox();
            this.txt_tenmh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin môn học";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã môn học";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên môn học";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiết";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgv_monhoc
            // 
            this.dgv_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monhoc.Location = new System.Drawing.Point(12, 129);
            this.dgv_monhoc.Name = "dgv_monhoc";
            this.dgv_monhoc.RowHeadersWidth = 51;
            this.dgv_monhoc.RowTemplate.Height = 24;
            this.dgv_monhoc.Size = new System.Drawing.Size(506, 259);
            this.dgv_monhoc.TabIndex = 5;
            this.dgv_monhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_monhoc_CellContentClick);
            // 
            // txt_mamh
            // 
            this.txt_mamh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mamh.Location = new System.Drawing.Point(628, 162);
            this.txt_mamh.Name = "txt_mamh";
            this.txt_mamh.Size = new System.Drawing.Size(162, 27);
            this.txt_mamh.TabIndex = 6;
            this.txt_mamh.TextChanged += new System.EventHandler(this.txt_mamh_TextChanged);
            // 
            // txt_sotiet
            // 
            this.txt_sotiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotiet.Location = new System.Drawing.Point(628, 250);
            this.txt_sotiet.Name = "txt_sotiet";
            this.txt_sotiet.Size = new System.Drawing.Size(162, 27);
            this.txt_sotiet.TabIndex = 7;
            this.txt_sotiet.TextChanged += new System.EventHandler(this.txt_sotiet_TextChanged);
            // 
            // txt_tenmh
            // 
            this.txt_tenmh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmh.Location = new System.Drawing.Point(628, 205);
            this.txt_tenmh.Name = "txt_tenmh";
            this.txt_tenmh.Size = new System.Drawing.Size(162, 27);
            this.txt_tenmh.TabIndex = 8;
            this.txt_tenmh.TextChanged += new System.EventHandler(this.txt_tenmh_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(524, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã giáo viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_magv
            // 
            this.txt_magv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_magv.Location = new System.Drawing.Point(628, 288);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(162, 27);
            this.txt_magv.TabIndex = 10;
            this.txt_magv.TextChanged += new System.EventHandler(this.txt_magv_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(628, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(715, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 512);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_magv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tenmh);
            this.Controls.Add(this.txt_sotiet);
            this.Controls.Add(this.txt_mamh);
            this.Controls.Add(this.dgv_monhoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Monhoc";
            this.Text = "Monhoc";
            this.Load += new System.EventHandler(this.Monhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_monhoc;
        private System.Windows.Forms.TextBox txt_mamh;
        private System.Windows.Forms.TextBox txt_sotiet;
        private System.Windows.Forms.TextBox txt_tenmh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}