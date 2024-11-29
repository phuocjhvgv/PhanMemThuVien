namespace DOAN.GUI
{
    partial class frm_ThongTinSinhVien
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.txt_Lop = new System.Windows.Forms.TextBox();
			this.txt_SDT = new System.Windows.Forms.TextBox();
			this.txt_EMAIL = new System.Windows.Forms.TextBox();
			this.txt_KHOA = new System.Windows.Forms.TextBox();
			this.txt_TenSV = new System.Windows.Forms.TextBox();
			this.txt_MaSV = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_TimKiem = new System.Windows.Forms.TextBox();
			this.btn_TimKiem = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Exit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1165, 94);
			this.panel1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(436, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "THÔNG TIN SINH VIÊN";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(1, 236);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1165, 280);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.btn_Delete);
			this.panel2.Controls.Add(this.btn_Update);
			this.panel2.Controls.Add(this.txt_Lop);
			this.panel2.Controls.Add(this.txt_SDT);
			this.panel2.Controls.Add(this.txt_EMAIL);
			this.panel2.Controls.Add(this.txt_KHOA);
			this.panel2.Controls.Add(this.txt_TenSV);
			this.panel2.Controls.Add(this.txt_MaSV);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(2, 515);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1165, 236);
			this.panel2.TabIndex = 11;
			// 
			// btn_Delete
			// 
			this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Delete.Location = new System.Drawing.Point(670, 162);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(106, 33);
			this.btn_Delete.TabIndex = 13;
			this.btn_Delete.Text = "XÓA";
			this.btn_Delete.UseVisualStyleBackColor = false;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
			// 
			// btn_Update
			// 
			this.btn_Update.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Update.Location = new System.Drawing.Point(322, 162);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(164, 33);
			this.btn_Update.TabIndex = 12;
			this.btn_Update.Text = "CẬP NHẬT";
			this.btn_Update.UseVisualStyleBackColor = false;
			this.btn_Update.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
			// 
			// txt_Lop
			// 
			this.txt_Lop.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_Lop.Location = new System.Drawing.Point(479, 24);
			this.txt_Lop.Name = "txt_Lop";
			this.txt_Lop.Size = new System.Drawing.Size(165, 28);
			this.txt_Lop.TabIndex = 11;
			// 
			// txt_SDT
			// 
			this.txt_SDT.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_SDT.Location = new System.Drawing.Point(841, 24);
			this.txt_SDT.Name = "txt_SDT";
			this.txt_SDT.Size = new System.Drawing.Size(185, 28);
			this.txt_SDT.TabIndex = 10;
			// 
			// txt_EMAIL
			// 
			this.txt_EMAIL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_EMAIL.Location = new System.Drawing.Point(841, 88);
			this.txt_EMAIL.Name = "txt_EMAIL";
			this.txt_EMAIL.Size = new System.Drawing.Size(185, 28);
			this.txt_EMAIL.TabIndex = 9;
			// 
			// txt_KHOA
			// 
			this.txt_KHOA.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_KHOA.Location = new System.Drawing.Point(479, 92);
			this.txt_KHOA.Name = "txt_KHOA";
			this.txt_KHOA.Size = new System.Drawing.Size(165, 28);
			this.txt_KHOA.TabIndex = 8;
			// 
			// txt_TenSV
			// 
			this.txt_TenSV.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_TenSV.Location = new System.Drawing.Point(156, 92);
			this.txt_TenSV.Name = "txt_TenSV";
			this.txt_TenSV.Size = new System.Drawing.Size(177, 28);
			this.txt_TenSV.TabIndex = 7;
			// 
			// txt_MaSV
			// 
			this.txt_MaSV.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_MaSV.Location = new System.Drawing.Point(156, 24);
			this.txt_MaSV.Name = "txt_MaSV";
			this.txt_MaSV.Size = new System.Drawing.Size(177, 28);
			this.txt_MaSV.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(687, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 24);
			this.label8.TabIndex = 5;
			this.label8.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(11, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 24);
			this.label7.TabIndex = 4;
			this.label7.Text = "Tên Sinh Viên";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(408, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 24);
			this.label6.TabIndex = 3;
			this.label6.Text = "Khoa";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(408, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 24);
			this.label5.TabIndex = 2;
			this.label5.Text = "Lớp";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(687, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 24);
			this.label4.TabIndex = 1;
			this.label4.Text = "Số Điện Thoại";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(11, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã Sinh Viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(241, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 29);
			this.label2.TabIndex = 12;
			this.label2.Text = "Mã Sinh Viên";
			// 
			// txt_TimKiem
			// 
			this.txt_TimKiem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_TimKiem.Location = new System.Drawing.Point(429, 162);
			this.txt_TimKiem.Name = "txt_TimKiem";
			this.txt_TimKiem.Size = new System.Drawing.Size(232, 28);
			this.txt_TimKiem.TabIndex = 13;
			this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
			// 
			// btn_TimKiem
			// 
			this.btn_TimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_TimKiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_TimKiem.Location = new System.Drawing.Point(721, 158);
			this.btn_TimKiem.Name = "btn_TimKiem";
			this.btn_TimKiem.Size = new System.Drawing.Size(107, 38);
			this.btn_TimKiem.TabIndex = 14;
			this.btn_TimKiem.Text = "LÀM MỚI";
			this.btn_TimKiem.UseVisualStyleBackColor = false;
			this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.Red;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Exit.Location = new System.Drawing.Point(1013, 27);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(107, 38);
			this.btn_Exit.TabIndex = 15;
			this.btn_Exit.Text = "THOÁT";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
			// 
			// frm_ThongTinSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 730);
			this.Controls.Add(this.btn_TimKiem);
			this.Controls.Add(this.txt_TimKiem);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "frm_ThongTinSinhVien";
			this.Text = "ThongTinSinhVien";
			this.Load += new System.EventHandler(this.frm_ThongTinSinhVien_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_EMAIL;
        private System.Windows.Forms.TextBox txt_KHOA;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Exit;
    }
}