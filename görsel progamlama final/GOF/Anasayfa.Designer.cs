namespace GOF
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
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleSilGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilereDersİliştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencilerVeDersleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.öğrenciToolStripMenuItem,
            this.öğrenciDersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelİşlemleriToolStripMenuItem,
            this.personelListeleToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel Ekle/Sil/Güncelle";
            this.personelİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.personelİşlemleriToolStripMenuItem_Click);
            // 
            // personelListeleToolStripMenuItem
            // 
            this.personelListeleToolStripMenuItem.Name = "personelListeleToolStripMenuItem";
            this.personelListeleToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.personelListeleToolStripMenuItem.Text = "Personelleri Listele";
            this.personelListeleToolStripMenuItem.Click += new System.EventHandler(this.personelListeleToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersİşlemleriToolStripMenuItem,
            this.dersleriListeleToolStripMenuItem});
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.dersToolStripMenuItem.Text = "Ders İşlemleri";
            // 
            // dersİşlemleriToolStripMenuItem
            // 
            this.dersİşlemleriToolStripMenuItem.Name = "dersİşlemleriToolStripMenuItem";
            this.dersİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.dersİşlemleriToolStripMenuItem.Text = "Ders Ekle/Sil/Güncelle";
            this.dersİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.dersİşlemleriToolStripMenuItem_Click);
            // 
            // dersleriListeleToolStripMenuItem
            // 
            this.dersleriListeleToolStripMenuItem.Name = "dersleriListeleToolStripMenuItem";
            this.dersleriListeleToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.dersleriListeleToolStripMenuItem.Text = "Dersleri Listele";
            this.dersleriListeleToolStripMenuItem.Click += new System.EventHandler(this.dersleriListeleToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleSilGüncelleToolStripMenuItem,
            this.öğrenciListeleToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // öğrenciEkleSilGüncelleToolStripMenuItem
            // 
            this.öğrenciEkleSilGüncelleToolStripMenuItem.Name = "öğrenciEkleSilGüncelleToolStripMenuItem";
            this.öğrenciEkleSilGüncelleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.öğrenciEkleSilGüncelleToolStripMenuItem.Text = "Öğrenci Ekle/Sil/Güncelle";
            this.öğrenciEkleSilGüncelleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleSilGüncelleToolStripMenuItem_Click);
            // 
            // öğrenciListeleToolStripMenuItem
            // 
            this.öğrenciListeleToolStripMenuItem.Name = "öğrenciListeleToolStripMenuItem";
            this.öğrenciListeleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.öğrenciListeleToolStripMenuItem.Text = "Öğrenci Listele";
            this.öğrenciListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListeleToolStripMenuItem_Click);
            // 
            // öğrenciDersToolStripMenuItem
            // 
            this.öğrenciDersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilereDersİliştirToolStripMenuItem,
            this.öğrencilerVeDersleriListeleToolStripMenuItem});
            this.öğrenciDersToolStripMenuItem.Name = "öğrenciDersToolStripMenuItem";
            this.öğrenciDersToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.öğrenciDersToolStripMenuItem.Text = "Öğrenci-Ders İşlemleri";
            // 
            // öğrencilereDersİliştirToolStripMenuItem
            // 
            this.öğrencilereDersİliştirToolStripMenuItem.Name = "öğrencilereDersİliştirToolStripMenuItem";
            this.öğrencilereDersİliştirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.öğrencilereDersİliştirToolStripMenuItem.Text = "Öğrencilere Ders İliştir";
            this.öğrencilereDersİliştirToolStripMenuItem.Click += new System.EventHandler(this.öğrencilereDersİliştirToolStripMenuItem_Click);
            // 
            // öğrencilerVeDersleriListeleToolStripMenuItem
            // 
            this.öğrencilerVeDersleriListeleToolStripMenuItem.Name = "öğrencilerVeDersleriListeleToolStripMenuItem";
            this.öğrencilerVeDersleriListeleToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.öğrencilerVeDersleriListeleToolStripMenuItem.Text = "Öğrenciler ve Dersleri Listele";
            this.öğrencilerVeDersleriListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrencilerVeDersleriListeleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 571);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Ana-Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleSilGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilereDersİliştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerVeDersleriListeleToolStripMenuItem;
    }
}

