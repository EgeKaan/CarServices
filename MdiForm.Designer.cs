namespace CarServices
{
    partial class MdiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriKayıtToolStripMenuItem,
            this.araçKayıtToolStripMenuItem});
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            // 
            // müşteriKayıtToolStripMenuItem
            // 
            this.müşteriKayıtToolStripMenuItem.Name = "müşteriKayıtToolStripMenuItem";
            this.müşteriKayıtToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.müşteriKayıtToolStripMenuItem.Text = "Müşteri Kayıt";
            this.müşteriKayıtToolStripMenuItem.Click += new System.EventHandler(this.müşteriKayıtToolStripMenuItem_Click);
            // 
            // araçKayıtToolStripMenuItem
            // 
            this.araçKayıtToolStripMenuItem.Name = "araçKayıtToolStripMenuItem";
            this.araçKayıtToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.araçKayıtToolStripMenuItem.Text = "Araç Kayıt";
            this.araçKayıtToolStripMenuItem.Click += new System.EventHandler(this.araçKayıtToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.araçGüncelleToolStripMenuItem});
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.mToolStripMenuItem.Text = "Müşteri Güncelle";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // araçGüncelleToolStripMenuItem
            // 
            this.araçGüncelleToolStripMenuItem.Name = "araçGüncelleToolStripMenuItem";
            this.araçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.araçGüncelleToolStripMenuItem.Text = "Araç Güncelle";
            this.araçGüncelleToolStripMenuItem.Click += new System.EventHandler(this.araçGüncelleToolStripMenuItem_Click);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis Kayıt Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MdiForm_FormClosed);
            this.Load += new System.EventHandler(this.MdiForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçGüncelleToolStripMenuItem;
    }
}