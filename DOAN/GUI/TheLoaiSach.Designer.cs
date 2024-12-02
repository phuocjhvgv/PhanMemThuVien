namespace DOAN.GUI
{
	partial class TheLoaiSach
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
			this.btn_Thoat = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dtgr_TheLoaiSach = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_SuaTL = new System.Windows.Forms.Button();
			this.txt_TenTL = new System.Windows.Forms.TextBox();
			this.btn_XoaTL = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_ThemTL = new System.Windows.Forms.Button();
			this.txt_MaTL = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgr_TheLoaiSach)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.BackColor = System.Drawing.Color.Red;
			this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Thoat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Thoat.Location = new System.Drawing.Point(946, 12);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(42, 37);
			this.btn_Thoat.TabIndex = 16;
			this.btn_Thoat.Text = "X";
			this.btn_Thoat.UseVisualStyleBackColor = false;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(303, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(377, 32);
			this.label3.TabIndex = 15;
			this.label3.Text = "QUẢN LÝ THỂ LOẠI SÁCH";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dtgr_TheLoaiSach);
			this.panel2.Location = new System.Drawing.Point(13, 180);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(479, 292);
			this.panel2.TabIndex = 14;
			// 
			// dtgr_TheLoaiSach
			// 
			this.dtgr_TheLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgr_TheLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgr_TheLoaiSach.Location = new System.Drawing.Point(3, 4);
			this.dtgr_TheLoaiSach.Name = "dtgr_TheLoaiSach";
			this.dtgr_TheLoaiSach.RowHeadersWidth = 51;
			this.dtgr_TheLoaiSach.RowTemplate.Height = 24;
			this.dtgr_TheLoaiSach.Size = new System.Drawing.Size(473, 243);
			this.dtgr_TheLoaiSach.TabIndex = 0;
			this.dtgr_TheLoaiSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgr_TheLoaiSach_CellContentClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.btn_SuaTL);
			this.panel1.Controls.Add(this.txt_TenTL);
			this.panel1.Controls.Add(this.btn_XoaTL);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_ThemTL);
			this.panel1.Controls.Add(this.txt_MaTL);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(543, 117);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(458, 437);
			this.panel1.TabIndex = 13;
			// 
			// btn_SuaTL
			// 
			this.btn_SuaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_SuaTL.Location = new System.Drawing.Point(311, 298);
			this.btn_SuaTL.Name = "btn_SuaTL";
			this.btn_SuaTL.Size = new System.Drawing.Size(118, 45);
			this.btn_SuaTL.TabIndex = 2;
			this.btn_SuaTL.Text = "Sửa";
			this.btn_SuaTL.UseVisualStyleBackColor = true;
			this.btn_SuaTL.Click += new System.EventHandler(this.btn_SuaTL_Click_1);
			// 
			// txt_TenTL
			// 
			this.txt_TenTL.Location = new System.Drawing.Point(168, 152);
			this.txt_TenTL.Name = "txt_TenTL";
			this.txt_TenTL.Size = new System.Drawing.Size(227, 22);
			this.txt_TenTL.TabIndex = 10;
			// 
			// btn_XoaTL
			// 
			this.btn_XoaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_XoaTL.Location = new System.Drawing.Point(168, 298);
			this.btn_XoaTL.Name = "btn_XoaTL";
			this.btn_XoaTL.Size = new System.Drawing.Size(118, 45);
			this.btn_XoaTL.TabIndex = 1;
			this.btn_XoaTL.Text = "Xóa";
			this.btn_XoaTL.UseVisualStyleBackColor = true;
			this.btn_XoaTL.Click += new System.EventHandler(this.btn_XoaTL_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Mã thể loại:";
			// 
			// btn_ThemTL
			// 
			this.btn_ThemTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ThemTL.Location = new System.Drawing.Point(19, 298);
			this.btn_ThemTL.Name = "btn_ThemTL";
			this.btn_ThemTL.Size = new System.Drawing.Size(118, 45);
			this.btn_ThemTL.TabIndex = 0;
			this.btn_ThemTL.Text = "Thêm";
			this.btn_ThemTL.UseVisualStyleBackColor = true;
			this.btn_ThemTL.Click += new System.EventHandler(this.btn_ThemTL_Click_1);
			// 
			// txt_MaTL
			// 
			this.txt_MaTL.Location = new System.Drawing.Point(168, 66);
			this.txt_MaTL.Name = "txt_MaTL";
			this.txt_MaTL.Size = new System.Drawing.Size(227, 22);
			this.txt_MaTL.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(33, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "Tên thể loại:";
			// 
			// TheLoaiSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1036, 582);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "TheLoaiSach";
			this.Text = "frm_TheLoaiSach";
			this.Load += new System.EventHandler(this.TheLoaiSach_Load_1);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgr_TheLoaiSach)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Thoat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dtgr_TheLoaiSach;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_SuaTL;
		private System.Windows.Forms.TextBox txt_TenTL;
		private System.Windows.Forms.Button btn_XoaTL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_ThemTL;
		private System.Windows.Forms.TextBox txt_MaTL;
		private System.Windows.Forms.Label label2;
	}
}