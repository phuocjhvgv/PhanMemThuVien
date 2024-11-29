namespace DOAN.GUI
{
    partial class frm_ChiTietThueTraSach
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
			this.dataGridView_ThueSach = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView_TraSach = new System.Windows.Forms.DataGridView();
			this.btn_exit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThueSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraSach)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_ThueSach
			// 
			this.dataGridView_ThueSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_ThueSach.Location = new System.Drawing.Point(2, 141);
			this.dataGridView_ThueSach.Name = "dataGridView_ThueSach";
			this.dataGridView_ThueSach.RowHeadersWidth = 51;
			this.dataGridView_ThueSach.RowTemplate.Height = 24;
			this.dataGridView_ThueSach.Size = new System.Drawing.Size(1194, 281);
			this.dataGridView_ThueSach.TabIndex = 2;
			this.dataGridView_ThueSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ThueSach_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(431, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 32);
			this.label1.TabIndex = 4;
			this.label1.Text = "CHI TIẾT THUÊ SÁCH";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(441, 465);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(294, 32);
			this.label2.TabIndex = 5;
			this.label2.Text = "CHI TIẾT TRẢ SÁCH";
			// 
			// dataGridView_TraSach
			// 
			this.dataGridView_TraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_TraSach.Location = new System.Drawing.Point(2, 542);
			this.dataGridView_TraSach.Name = "dataGridView_TraSach";
			this.dataGridView_TraSach.RowHeadersWidth = 51;
			this.dataGridView_TraSach.RowTemplate.Height = 24;
			this.dataGridView_TraSach.Size = new System.Drawing.Size(1194, 261);
			this.dataGridView_TraSach.TabIndex = 6;
			// 
			// btn_exit
			// 
			this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_exit.ForeColor = System.Drawing.Color.Red;
			this.btn_exit.Location = new System.Drawing.Point(1139, 12);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(43, 34);
			this.btn_exit.TabIndex = 7;
			this.btn_exit.Text = "X";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// frm_ChiTietThueTraSach
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1194, 803);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.dataGridView_TraSach);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView_ThueSach);
			this.Name = "frm_ChiTietThueTraSach";
			this.Text = "ChiTietThueTraSach";
			this.Load += new System.EventHandler(this.frm_ChiTietThueTraSach_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThueSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraSach)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ThueSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_TraSach;
        private System.Windows.Forms.Button btn_exit;
    }
}