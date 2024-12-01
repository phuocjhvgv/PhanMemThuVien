namespace DOAN.GUI
{
    partial class frm_QuanLySach
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
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.txt_tacgia = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.cb_TheLoai = new System.Windows.Forms.ComboBox();
            this.cb_NgonNgu = new System.Windows.Forms.ComboBox();
            this.dgv_Danhsach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Danhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thể Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngôn Ngữ";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(161, 131);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(100, 22);
            this.txt_tensach.TabIndex = 5;
            // 
            // txt_tacgia
            // 
            this.txt_tacgia.Location = new System.Drawing.Point(161, 197);
            this.txt_tacgia.Name = "txt_tacgia";
            this.txt_tacgia.Size = new System.Drawing.Size(100, 22);
            this.txt_tacgia.TabIndex = 6;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(644, 194);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // cb_TheLoai
            // 
            this.cb_TheLoai.FormattingEnabled = true;
            this.cb_TheLoai.Location = new System.Drawing.Point(385, 127);
            this.cb_TheLoai.Name = "cb_TheLoai";
            this.cb_TheLoai.Size = new System.Drawing.Size(121, 24);
            this.cb_TheLoai.TabIndex = 8;
            // 
            // cb_NgonNgu
            // 
            this.cb_NgonNgu.FormattingEnabled = true;
            this.cb_NgonNgu.Location = new System.Drawing.Point(635, 131);
            this.cb_NgonNgu.Name = "cb_NgonNgu";
            this.cb_NgonNgu.Size = new System.Drawing.Size(121, 24);
            this.cb_NgonNgu.TabIndex = 9;
            // 
            // dgv_Danhsach
            // 
            this.dgv_Danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Danhsach.Location = new System.Drawing.Point(121, 271);
            this.dgv_Danhsach.Name = "dgv_Danhsach";
            this.dgv_Danhsach.RowTemplate.Height = 24;
            this.dgv_Danhsach.Size = new System.Drawing.Size(598, 150);
            this.dgv_Danhsach.TabIndex = 10;
            // 
            // frm_QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Danhsach);
            this.Controls.Add(this.cb_NgonNgu);
            this.Controls.Add(this.cb_TheLoai);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_tacgia);
            this.Controls.Add(this.txt_tensach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_QuanLySach";
            this.Text = "frm_QuanLySach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Danhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.TextBox txt_tacgia;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ComboBox cb_TheLoai;
        private System.Windows.Forms.ComboBox cb_NgonNgu;
        private System.Windows.Forms.DataGridView dgv_Danhsach;
    }
}