﻿namespace Quanlysinhvien
{
    partial class timkiemlop
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
            this.dgv_tkl = new System.Windows.Forms.DataGridView();
            this.btn_loadlai = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.cbb_timkiemtheo = new System.Windows.Forms.ComboBox();
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tkl
            // 
            this.dgv_tkl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tkl.Location = new System.Drawing.Point(400, 190);
            this.dgv_tkl.Name = "dgv_tkl";
            this.dgv_tkl.RowHeadersWidth = 51;
            this.dgv_tkl.RowTemplate.Height = 24;
            this.dgv_tkl.Size = new System.Drawing.Size(518, 255);
            this.dgv_tkl.TabIndex = 30;
            // 
            // btn_loadlai
            // 
            this.btn_loadlai.Location = new System.Drawing.Point(183, 387);
            this.btn_loadlai.Name = "btn_loadlai";
            this.btn_loadlai.Size = new System.Drawing.Size(87, 30);
            this.btn_loadlai.TabIndex = 29;
            this.btn_loadlai.Text = "Load lại";
            this.btn_loadlai.UseVisualStyleBackColor = true;
            this.btn_loadlai.Click += new System.EventHandler(this.btn_loadlai_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(276, 387);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(87, 30);
            this.btn_dong.TabIndex = 28;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(90, 387);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(87, 30);
            this.btn_timkiem.TabIndex = 27;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // cbb_timkiemtheo
            // 
            this.cbb_timkiemtheo.FormattingEnabled = true;
            this.cbb_timkiemtheo.Location = new System.Drawing.Point(164, 332);
            this.cbb_timkiemtheo.Name = "cbb_timkiemtheo";
            this.cbb_timkiemtheo.Size = new System.Drawing.Size(198, 24);
            this.cbb_timkiemtheo.TabIndex = 26;
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Location = new System.Drawing.Point(164, 279);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(198, 22);
            this.txt_tukhoa.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tìm kiếm theo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thông tin tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Từ khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tìm kiếm lớp";
            // 
            // timkiemlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 555);
            this.Controls.Add(this.dgv_tkl);
            this.Controls.Add(this.btn_loadlai);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.cbb_timkiemtheo);
            this.Controls.Add(this.txt_tukhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "timkiemlop";
            this.Text = "timkiemlop";
            this.Load += new System.EventHandler(this.timkiemlop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tkl;
        private System.Windows.Forms.Button btn_loadlai;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.ComboBox cbb_timkiemtheo;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}