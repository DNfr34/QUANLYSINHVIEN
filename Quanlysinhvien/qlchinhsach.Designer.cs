namespace Quanlysinhvien
{
    partial class qlchinhsach
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
            this.txtchedo = new System.Windows.Forms.TextBox();
            this.txttenchinhsach = new System.Windows.Forms.TextBox();
            this.txtmachinhsach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_qlchinhsach = new System.Windows.Forms.DataGridView();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlchinhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtchedo
            // 
            this.txtchedo.Location = new System.Drawing.Point(136, 200);
            this.txtchedo.Name = "txtchedo";
            this.txtchedo.Size = new System.Drawing.Size(198, 22);
            this.txtchedo.TabIndex = 15;
            // 
            // txttenchinhsach
            // 
            this.txttenchinhsach.Location = new System.Drawing.Point(136, 172);
            this.txttenchinhsach.Name = "txttenchinhsach";
            this.txttenchinhsach.Size = new System.Drawing.Size(198, 22);
            this.txttenchinhsach.TabIndex = 14;
            // 
            // txtmachinhsach
            // 
            this.txtmachinhsach.Location = new System.Drawing.Point(136, 144);
            this.txtmachinhsach.Name = "txtmachinhsach";
            this.txtmachinhsach.Size = new System.Drawing.Size(198, 22);
            this.txtmachinhsach.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chế độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên chính sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã chính sách";
            // 
            // dgv_qlchinhsach
            // 
            this.dgv_qlchinhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlchinhsach.Location = new System.Drawing.Point(352, 144);
            this.dgv_qlchinhsach.Name = "dgv_qlchinhsach";
            this.dgv_qlchinhsach.RowHeadersWidth = 51;
            this.dgv_qlchinhsach.RowTemplate.Height = 24;
            this.dgv_qlchinhsach.Size = new System.Drawing.Size(502, 195);
            this.dgv_qlchinhsach.TabIndex = 16;
            this.dgv_qlchinhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlchinhsach_CellContentClick);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai.Location = new System.Drawing.Point(85, 286);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(118, 31);
            this.btn_nhaplai.TabIndex = 24;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.Location = new System.Drawing.Point(209, 286);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(113, 31);
            this.btn_dong.TabIndex = 23;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(166, 244);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 36);
            this.btn_sua.TabIndex = 21;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(247, 244);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 36);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(85, 244);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 36);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Quản Lý Chính Sách";
            // 
            // qlchinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nhaplai);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_qlchinhsach);
            this.Controls.Add(this.txtchedo);
            this.Controls.Add(this.txttenchinhsach);
            this.Controls.Add(this.txtmachinhsach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "qlchinhsach";
            this.Text = "qlchinhsach";
            this.Load += new System.EventHandler(this.qlchinhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlchinhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtchedo;
        private System.Windows.Forms.TextBox txttenchinhsach;
        private System.Windows.Forms.TextBox txtmachinhsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_qlchinhsach;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label1;
    }
}