namespace DOAN.GUI
{
    partial class QLNXB
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
            this.dgrd_NXB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MaNXB = new System.Windows.Forms.Label();
            this.lbl_TenNXB = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_TìmKiem = new System.Windows.Forms.TextBox();
            this.txt_MaNXB = new System.Windows.Forms.TextBox();
            this.txt_TenNXB = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_NXB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrd_NXB
            // 
            this.dgrd_NXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_NXB.Location = new System.Drawing.Point(23, 91);
            this.dgrd_NXB.Name = "dgrd_NXB";
            this.dgrd_NXB.RowHeadersWidth = 51;
            this.dgrd_NXB.RowTemplate.Height = 24;
            this.dgrd_NXB.Size = new System.Drawing.Size(568, 344);
            this.dgrd_NXB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(343, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÀ XUẤT BẢN";
            // 
            // lbl_MaNXB
            // 
            this.lbl_MaNXB.AutoSize = true;
            this.lbl_MaNXB.Location = new System.Drawing.Point(618, 174);
            this.lbl_MaNXB.Name = "lbl_MaNXB";
            this.lbl_MaNXB.Size = new System.Drawing.Size(62, 16);
            this.lbl_MaNXB.TabIndex = 2;
            this.lbl_MaNXB.Text = "Mã NXB :";
            // 
            // lbl_TenNXB
            // 
            this.lbl_TenNXB.AutoSize = true;
            this.lbl_TenNXB.Location = new System.Drawing.Point(618, 235);
            this.lbl_TenNXB.Name = "lbl_TenNXB";
            this.lbl_TenNXB.Size = new System.Drawing.Size(67, 16);
            this.lbl_TenNXB.TabIndex = 3;
            this.lbl_TenNXB.Text = "Tên NXB :";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(825, 116);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(627, 292);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(731, 292);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(832, 292);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_TìmKiem
            // 
            this.txt_TìmKiem.Location = new System.Drawing.Point(627, 116);
            this.txt_TìmKiem.Name = "txt_TìmKiem";
            this.txt_TìmKiem.Size = new System.Drawing.Size(168, 22);
            this.txt_TìmKiem.TabIndex = 9;
            // 
            // txt_MaNXB
            // 
            this.txt_MaNXB.Location = new System.Drawing.Point(719, 168);
            this.txt_MaNXB.Name = "txt_MaNXB";
            this.txt_MaNXB.Size = new System.Drawing.Size(181, 22);
            this.txt_MaNXB.TabIndex = 10;
            // 
            // txt_TenNXB
            // 
            this.txt_TenNXB.Location = new System.Drawing.Point(719, 229);
            this.txt_TenNXB.Name = "txt_TenNXB";
            this.txt_TenNXB.Size = new System.Drawing.Size(181, 22);
            this.txt_TenNXB.TabIndex = 11;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(825, 411);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // QLNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 468);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_TenNXB);
            this.Controls.Add(this.txt_MaNXB);
            this.Controls.Add(this.txt_TìmKiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.lbl_TenNXB);
            this.Controls.Add(this.lbl_MaNXB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrd_NXB);
            this.Name = "QLNXB";
            this.Text = "QLNXB";
            this.Load += new System.EventHandler(this.QLNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_NXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrd_NXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MaNXB;
        private System.Windows.Forms.Label lbl_TenNXB;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_TìmKiem;
        private System.Windows.Forms.TextBox txt_MaNXB;
        private System.Windows.Forms.TextBox txt_TenNXB;
        private System.Windows.Forms.Button btn_thoat;
    }
}