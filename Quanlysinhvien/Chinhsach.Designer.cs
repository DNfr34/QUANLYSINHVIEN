namespace Quanlysinhvien
{
    partial class Chinhsach
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
            this.btnin = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.txtmachinhsach = new System.Windows.Forms.TextBox();
            this.txttenchinhsach = new System.Windows.Forms.TextBox();
            this.txtchedo = new System.Windows.Forms.TextBox();
            this.dgv_chinhsach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chinhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chính Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chính sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên chính sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chế độ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thông tin chính sách";
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(556, 304);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 5;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(669, 304);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 6;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // txtmachinhsach
            // 
            this.txtmachinhsach.Location = new System.Drawing.Point(546, 166);
            this.txtmachinhsach.Name = "txtmachinhsach";
            this.txtmachinhsach.Size = new System.Drawing.Size(198, 22);
            this.txtmachinhsach.TabIndex = 7;
            // 
            // txttenchinhsach
            // 
            this.txttenchinhsach.Location = new System.Drawing.Point(546, 216);
            this.txttenchinhsach.Name = "txttenchinhsach";
            this.txttenchinhsach.Size = new System.Drawing.Size(198, 22);
            this.txttenchinhsach.TabIndex = 8;
            // 
            // txtchedo
            // 
            this.txtchedo.Location = new System.Drawing.Point(546, 258);
            this.txtchedo.Name = "txtchedo";
            this.txtchedo.Size = new System.Drawing.Size(198, 22);
            this.txtchedo.TabIndex = 9;
            // 
            // dgv_chinhsach
            // 
            this.dgv_chinhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chinhsach.Location = new System.Drawing.Point(34, 149);
            this.dgv_chinhsach.Name = "dgv_chinhsach";
            this.dgv_chinhsach.RowHeadersWidth = 51;
            this.dgv_chinhsach.RowTemplate.Height = 24;
            this.dgv_chinhsach.Size = new System.Drawing.Size(358, 178);
            this.dgv_chinhsach.TabIndex = 10;
            this.dgv_chinhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chinhsach_CellContentClick);
            // 
            // Chinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.dgv_chinhsach);
            this.Controls.Add(this.txtchedo);
            this.Controls.Add(this.txttenchinhsach);
            this.Controls.Add(this.txtmachinhsach);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chinhsach";
            this.Text = "Chinhsach";
            this.Load += new System.EventHandler(this.Chinhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chinhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.TextBox txtmachinhsach;
        private System.Windows.Forms.TextBox txttenchinhsach;
        private System.Windows.Forms.TextBox txtchedo;
        private System.Windows.Forms.DataGridView dgv_chinhsach;
    }
}