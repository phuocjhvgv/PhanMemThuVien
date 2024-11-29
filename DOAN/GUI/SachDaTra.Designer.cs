namespace DOAN.GUI
{
    partial class frm_SachDaTra
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.lbl_SoLuong = new System.Windows.Forms.Label();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.btn_Search = new System.Windows.Forms.Button();
			this.txt_Search = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-3, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1120, 112);
			this.panel1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(437, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "SÁCH ĐÃ TRẢ";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.lbl_SoLuong);
			this.panel2.Controls.Add(this.btn_Exit);
			this.panel2.Controls.Add(this.btn_Clear);
			this.panel2.Controls.Add(this.btn_Search);
			this.panel2.Controls.Add(this.txt_Search);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(-3, 112);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(368, 611);
			this.panel2.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.Location = new System.Drawing.Point(29, 353);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(188, 76);
			this.button1.TabIndex = 10;
			this.button1.Text = "TỔNG SÁCH ĐÃ TRẢ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbl_SoLuong
			// 
			this.lbl_SoLuong.AutoSize = true;
			this.lbl_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SoLuong.Location = new System.Drawing.Point(260, 367);
			this.lbl_SoLuong.Name = "lbl_SoLuong";
			this.lbl_SoLuong.Size = new System.Drawing.Size(36, 38);
			this.lbl_SoLuong.TabIndex = 9;
			this.lbl_SoLuong.Text = "0";
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.Red;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Exit.Location = new System.Drawing.Point(226, 245);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(101, 38);
			this.btn_Exit.TabIndex = 5;
			this.btn_Exit.Text = "THOÁT";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_Clear
			// 
			this.btn_Clear.BackColor = System.Drawing.Color.SkyBlue;
			this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Clear.Location = new System.Drawing.Point(29, 245);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(134, 38);
			this.btn_Clear.TabIndex = 4;
			this.btn_Clear.Text = "LÀM MỚI";
			this.btn_Clear.UseVisualStyleBackColor = false;
			this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Search.Location = new System.Drawing.Point(89, 166);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(190, 46);
			this.btn_Search.TabIndex = 3;
			this.btn_Search.Text = "TÌM KIẾM";
			this.btn_Search.UseVisualStyleBackColor = false;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// txt_Search
			// 
			this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Search.Location = new System.Drawing.Point(64, 95);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.Size = new System.Drawing.Size(232, 34);
			this.txt_Search.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(86, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nhập Mã Sinh Viên";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(361, 112);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(753, 611);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// frm_SachDaTra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 724);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frm_SachDaTra";
			this.Text = "SachDaTra";
			this.Load += new System.EventHandler(this.frm_SachDaTra_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}