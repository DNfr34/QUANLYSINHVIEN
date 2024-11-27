namespace Quanlysinhvien
{
    partial class timkiemmonhoc
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
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.cbb_timkiemtheo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_tkmh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkmh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thông tin tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tìm kiếm theo";
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Location = new System.Drawing.Point(130, 201);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(198, 22);
            this.txt_tukhoa.TabIndex = 5;
            // 
            // cbb_timkiemtheo
            // 
            this.cbb_timkiemtheo.FormattingEnabled = true;
            this.cbb_timkiemtheo.Location = new System.Drawing.Point(130, 254);
            this.cbb_timkiemtheo.Name = "cbb_timkiemtheo";
            this.cbb_timkiemtheo.Size = new System.Drawing.Size(198, 24);
            this.cbb_timkiemtheo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Load lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_tkmh
            // 
            this.dgv_tkmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tkmh.Location = new System.Drawing.Point(366, 112);
            this.dgv_tkmh.Name = "dgv_tkmh";
            this.dgv_tkmh.RowHeadersWidth = 51;
            this.dgv_tkmh.RowTemplate.Height = 24;
            this.dgv_tkmh.Size = new System.Drawing.Size(518, 255);
            this.dgv_tkmh.TabIndex = 10;
            // 
            // timkiemmonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 433);
            this.Controls.Add(this.dgv_tkmh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbb_timkiemtheo);
            this.Controls.Add(this.txt_tukhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "timkiemmonhoc";
            this.Text = "timkiemmonhoc";
            this.Load += new System.EventHandler(this.timkiemmonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkmh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.ComboBox cbb_timkiemtheo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_tkmh;
    }
}