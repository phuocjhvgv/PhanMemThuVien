namespace DOAN.GUI
{
    partial class frm_DangKy
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
			this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_MatKhau = new System.Windows.Forms.TextBox();
			this.btn_Dky = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(217, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "ĐĂNG KÝ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 24);
			this.label2.TabIndex = 16;
			this.label2.Text = "TÊN ĐĂNG NHẬP";
			// 
			// txt_TaiKhoan
			// 
			this.txt_TaiKhoan.BackColor = System.Drawing.Color.White;
			this.txt_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_TaiKhoan.ForeColor = System.Drawing.Color.White;
			this.txt_TaiKhoan.Location = new System.Drawing.Point(299, 184);
			this.txt_TaiKhoan.Name = "txt_TaiKhoan";
			this.txt_TaiKhoan.Size = new System.Drawing.Size(222, 23);
			this.txt_TaiKhoan.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(46, 270);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 24);
			this.label3.TabIndex = 18;
			this.label3.Text = "MẬT KHẨU";
			// 
			// txt_MatKhau
			// 
			this.txt_MatKhau.BackColor = System.Drawing.Color.White;
			this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt_MatKhau.ForeColor = System.Drawing.Color.White;
			this.txt_MatKhau.Location = new System.Drawing.Point(299, 268);
			this.txt_MatKhau.Name = "txt_MatKhau";
			this.txt_MatKhau.Size = new System.Drawing.Size(222, 23);
			this.txt_MatKhau.TabIndex = 19;
			// 
			// btn_Dky
			// 
			this.btn_Dky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_Dky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Dky.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Dky.ForeColor = System.Drawing.Color.Black;
			this.btn_Dky.Location = new System.Drawing.Point(126, 374);
			this.btn_Dky.Name = "btn_Dky";
			this.btn_Dky.Size = new System.Drawing.Size(123, 32);
			this.btn_Dky.TabIndex = 22;
			this.btn_Dky.Text = "Đăng Ký";
			this.btn_Dky.UseVisualStyleBackColor = false;
			this.btn_Dky.Click += new System.EventHandler(this.btn_Dky_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(329, 374);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 32);
			this.button2.TabIndex = 23;
			this.button2.Text = "Thoát";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// frm_DangKy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 560);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_Dky);
			this.Controls.Add(this.txt_MatKhau);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_TaiKhoan);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frm_DangKy";
			this.Text = "DangKy";
			this.Load += new System.EventHandler(this.frm_DangKy_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_Dky;
        private System.Windows.Forms.Button button2;
    }
}