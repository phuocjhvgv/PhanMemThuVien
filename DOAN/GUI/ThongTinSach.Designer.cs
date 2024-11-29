namespace DOAN.GUI
{
    partial class frm_ThongTinSach
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
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Tim = new System.Windows.Forms.TextBox();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cb_TenSach = new System.Windows.Forms.ComboBox();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.dateTime = new System.Windows.Forms.DateTimePicker();
			this.txt_Gia = new System.Windows.Forms.TextBox();
			this.txt_NXB = new System.Windows.Forms.TextBox();
			this.txt_TenTG = new System.Windows.Forms.TextBox();
			this.txt_SL = new System.Windows.Forms.TextBox();
			this.txt_Ma = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_Exit);
			this.panel1.Location = new System.Drawing.Point(1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1187, 104);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(475, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "THÔNG TIN SÁCH";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 204);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1187, 310);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(265, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 29);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mã Sách";
			// 
			// txt_Tim
			// 
			this.txt_Tim.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_Tim.Location = new System.Drawing.Point(382, 140);
			this.txt_Tim.Name = "txt_Tim";
			this.txt_Tim.Size = new System.Drawing.Size(232, 28);
			this.txt_Tim.TabIndex = 7;
			this.txt_Tim.TextChanged += new System.EventHandler(this.txt_MaSach_TextChanged);
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.BackColor = System.Drawing.Color.SkyBlue;
			this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Refresh.Location = new System.Drawing.Point(672, 141);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(107, 29);
			this.btn_Refresh.TabIndex = 8;
			this.btn_Refresh.Text = "LÀM MỚI";
			this.btn_Refresh.UseVisualStyleBackColor = false;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.Red;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Exit.Location = new System.Drawing.Point(996, 39);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(96, 29);
			this.btn_Exit.TabIndex = 9;
			this.btn_Exit.Text = "THOÁT";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.cb_TenSach);
			this.panel2.Controls.Add(this.btn_Delete);
			this.panel2.Controls.Add(this.btn_Update);
			this.panel2.Controls.Add(this.dateTime);
			this.panel2.Controls.Add(this.txt_Gia);
			this.panel2.Controls.Add(this.txt_NXB);
			this.panel2.Controls.Add(this.txt_TenTG);
			this.panel2.Controls.Add(this.txt_SL);
			this.panel2.Controls.Add(this.txt_Ma);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(1, 504);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1187, 276);
			this.panel2.TabIndex = 10;
			// 
			// cb_TenSach
			// 
			this.cb_TenSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cb_TenSach.FormattingEnabled = true;
			this.cb_TenSach.Location = new System.Drawing.Point(195, 97);
			this.cb_TenSach.Name = "cb_TenSach";
			this.cb_TenSach.Size = new System.Drawing.Size(196, 24);
			this.cb_TenSach.TabIndex = 17;
			// 
			// btn_Delete
			// 
			this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Delete.Location = new System.Drawing.Point(585, 212);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(84, 38);
			this.btn_Delete.TabIndex = 15;
			this.btn_Delete.Text = "XÓA";
			this.btn_Delete.UseVisualStyleBackColor = false;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
			// 
			// btn_Update
			// 
			this.btn_Update.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Update.Location = new System.Drawing.Point(349, 212);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(140, 38);
			this.btn_Update.TabIndex = 14;
			this.btn_Update.Text = "CẬP NHẬT";
			this.btn_Update.UseVisualStyleBackColor = false;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
			// 
			// dateTime
			// 
			this.dateTime.CustomFormat = "MM/dd/yyyy";
			this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTime.Location = new System.Drawing.Point(585, 101);
			this.dateTime.Name = "dateTime";
			this.dateTime.Size = new System.Drawing.Size(157, 22);
			this.dateTime.TabIndex = 13;
			// 
			// txt_Gia
			// 
			this.txt_Gia.Location = new System.Drawing.Point(585, 170);
			this.txt_Gia.Name = "txt_Gia";
			this.txt_Gia.Size = new System.Drawing.Size(157, 22);
			this.txt_Gia.TabIndex = 12;
			// 
			// txt_NXB
			// 
			this.txt_NXB.Location = new System.Drawing.Point(585, 37);
			this.txt_NXB.Name = "txt_NXB";
			this.txt_NXB.Size = new System.Drawing.Size(157, 22);
			this.txt_NXB.TabIndex = 11;
			// 
			// txt_TenTG
			// 
			this.txt_TenTG.Location = new System.Drawing.Point(195, 170);
			this.txt_TenTG.Name = "txt_TenTG";
			this.txt_TenTG.Size = new System.Drawing.Size(196, 22);
			this.txt_TenTG.TabIndex = 10;
			// 
			// txt_SL
			// 
			this.txt_SL.Location = new System.Drawing.Point(852, 37);
			this.txt_SL.Name = "txt_SL";
			this.txt_SL.Size = new System.Drawing.Size(109, 22);
			this.txt_SL.TabIndex = 9;
			// 
			// txt_Ma
			// 
			this.txt_Ma.Location = new System.Drawing.Point(195, 34);
			this.txt_Ma.Name = "txt_Ma";
			this.txt_Ma.Size = new System.Drawing.Size(196, 22);
			this.txt_Ma.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.Location = new System.Drawing.Point(748, 34);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 24);
			this.label10.TabIndex = 6;
			this.label10.Text = "Số Lượng";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label9.Location = new System.Drawing.Point(51, 97);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 24);
			this.label9.TabIndex = 5;
			this.label9.Text = "Tên Sách";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(432, 167);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 24);
			this.label8.TabIndex = 4;
			this.label8.Text = "Giá Sách";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(432, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 24);
			this.label7.TabIndex = 3;
			this.label7.Text = "Ngày Mua";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(51, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 24);
			this.label6.TabIndex = 2;
			this.label6.Text = "Tên Tác Giả";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(432, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 24);
			this.label5.TabIndex = 1;
			this.label5.Text = "Nhà Xuất Bản";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(51, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mã Sách";
			// 
			// frm_ThongTinSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 763);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.txt_Tim);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "frm_ThongTinSach";
			this.Text = "ThongTinSach";
			this.Load += new System.EventHandler(this.frm_ThongTinSach_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_TenSach;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_NXB;
        private System.Windows.Forms.TextBox txt_TenTG;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}