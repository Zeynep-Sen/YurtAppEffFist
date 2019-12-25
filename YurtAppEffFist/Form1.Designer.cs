namespace YurtAppEffFist
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ogrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciİşlemleriToolStripMenuItem
            // 
            this.ogrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciKaydetToolStripMenuItem,
            this.ogrenciSilToolStripMenuItem,
            this.ogrenciGüncelleToolStripMenuItem});
            this.ogrenciİşlemleriToolStripMenuItem.Name = "ogrenciİşlemleriToolStripMenuItem";
            this.ogrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ogrenciİşlemleriToolStripMenuItem.Text = "Ogrenci İşlemleri";
            // 
            // ogrenciKaydetToolStripMenuItem
            // 
            this.ogrenciKaydetToolStripMenuItem.Name = "ogrenciKaydetToolStripMenuItem";
            this.ogrenciKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ogrenciKaydetToolStripMenuItem.Text = "Ogrenci Kaydet";
            this.ogrenciKaydetToolStripMenuItem.Click += new System.EventHandler(this.ogrenciKaydetToolStripMenuItem_Click);
            // 
            // ogrenciSilToolStripMenuItem
            // 
            this.ogrenciSilToolStripMenuItem.Name = "ogrenciSilToolStripMenuItem";
            this.ogrenciSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ogrenciSilToolStripMenuItem.Text = "Ogrenci Sil";
            this.ogrenciSilToolStripMenuItem.Click += new System.EventHandler(this.ogrenciSilToolStripMenuItem_Click);
            // 
            // ogrenciGüncelleToolStripMenuItem
            // 
            this.ogrenciGüncelleToolStripMenuItem.Name = "ogrenciGüncelleToolStripMenuItem";
            this.ogrenciGüncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ogrenciGüncelleToolStripMenuItem.Text = "Ogrenci Güncelle";
            this.ogrenciGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ogrenciGüncelleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 388);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ogrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciGüncelleToolStripMenuItem;
    }
}

