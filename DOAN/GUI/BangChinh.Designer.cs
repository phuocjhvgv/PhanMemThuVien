namespace DOAN.GUI
{
    partial class frm_BangChinh
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BangChinh));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.completeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.completeToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1403, 58);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// bookToolStripMenuItem
			// 
			this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBooksToolStripMenuItem});
			this.bookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookToolStripMenuItem.Image")));
			this.bookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
			this.bookToolStripMenuItem.Size = new System.Drawing.Size(109, 54);
			this.bookToolStripMenuItem.Text = "SÁCH";
			// 
			// addNewBookToolStripMenuItem
			// 
			this.addNewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookToolStripMenuItem.Image")));
			this.addNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
			this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(234, 56);
			this.addNewBookToolStripMenuItem.Text = "THÊM SÁCH";
			this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
			// 
			// viewBooksToolStripMenuItem
			// 
			this.viewBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBooksToolStripMenuItem.Image")));
			this.viewBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
			this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(234, 56);
			this.viewBooksToolStripMenuItem.Text = "THÔNG TIN SÁCH";
			this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
			// 
			// studentToolStripMenuItem
			// 
			this.studentToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
			this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentInfoToolStripMenuItem});
			this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
			this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
			this.studentToolStripMenuItem.Size = new System.Drawing.Size(141, 54);
			this.studentToolStripMenuItem.Text = "SINH VIÊN";
			// 
			// addStudentToolStripMenuItem
			// 
			this.addStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem.Image")));
			this.addStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
			this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(266, 56);
			this.addStudentToolStripMenuItem.Text = "THÊM SINH VIÊN";
			this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
			// 
			// viewStudentInfoToolStripMenuItem
			// 
			this.viewStudentInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentInfoToolStripMenuItem.Image")));
			this.viewStudentInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
			this.viewStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(266, 56);
			this.viewStudentInfoToolStripMenuItem.Text = "THÔNG TIN SINH VIÊN";
			this.viewStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.viewStudentInfoToolStripMenuItem_Click);
			// 
			// issueBooksToolStripMenuItem
			// 
			this.issueBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksToolStripMenuItem.Image")));
			this.issueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
			this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(249, 54);
			this.issueBooksToolStripMenuItem.Text = "SINH VIÊN ĐÃ THUÊ SÁCH";
			this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
			// 
			// returnBooksToolStripMenuItem
			// 
			this.returnBooksToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
			this.returnBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBooksToolStripMenuItem.Image")));
			this.returnBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
			this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(239, 54);
			this.returnBooksToolStripMenuItem.Text = "SINH VIÊN ĐÃ TRẢ SÁCH";
			this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
			// 
			// completeToolStripMenuItem
			// 
			this.completeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completeToolStripMenuItem.Image")));
			this.completeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.completeToolStripMenuItem.Name = "completeToolStripMenuItem";
			this.completeToolStripMenuItem.Size = new System.Drawing.Size(241, 54);
			this.completeToolStripMenuItem.Text = "CHI TIẾT THUÊ TRẢ SÁCH";
			this.completeToolStripMenuItem.Click += new System.EventHandler(this.completeToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 54);
			this.exitToolStripMenuItem.Text = "THOÁT";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// frm_BangChinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1403, 730);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.Name = "frm_BangChinh";
			this.Text = "BangChinh";
			this.Load += new System.EventHandler(this.frm_BangChinh_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}