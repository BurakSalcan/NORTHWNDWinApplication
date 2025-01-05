namespace NORTHWNDWinApplication
{
    partial class AnaForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_kategoriler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_urunler = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_satıslar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_siparisDetaylari = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_tedarikciler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_musteriler = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_personeller = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_personelBolgeleri = new System.Windows.Forms.ToolStripMenuItem();
            this.nakliyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_nakliyeciler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_bölgeler = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünİşlemleriToolStripMenuItem,
            this.kişiİşlemleriToolStripMenuItem,
            this.nakliyeİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_kategoriler,
            this.TSMI_urunler,
            this.satışİşlemleriToolStripMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // TSMI_kategoriler
            // 
            this.TSMI_kategoriler.Name = "TSMI_kategoriler";
            this.TSMI_kategoriler.Size = new System.Drawing.Size(183, 26);
            this.TSMI_kategoriler.Text = "Kategoriler";
            this.TSMI_kategoriler.Click += new System.EventHandler(this.TSMI_kategoriler_Click);
            // 
            // TSMI_urunler
            // 
            this.TSMI_urunler.Name = "TSMI_urunler";
            this.TSMI_urunler.Size = new System.Drawing.Size(183, 26);
            this.TSMI_urunler.Text = "Ürünler";
            this.TSMI_urunler.Click += new System.EventHandler(this.TSMI_urunler_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_satıslar,
            this.TSMI_siparisDetaylari});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // TSMI_satıslar
            // 
            this.TSMI_satıslar.Name = "TSMI_satıslar";
            this.TSMI_satıslar.Size = new System.Drawing.Size(200, 26);
            this.TSMI_satıslar.Text = "Satışlar";
            this.TSMI_satıslar.Click += new System.EventHandler(this.TSMI_satıslar_Click);
            // 
            // TSMI_siparisDetaylari
            // 
            this.TSMI_siparisDetaylari.Name = "TSMI_siparisDetaylari";
            this.TSMI_siparisDetaylari.Size = new System.Drawing.Size(200, 26);
            this.TSMI_siparisDetaylari.Text = "Sipariş Detayları";
            this.TSMI_siparisDetaylari.Click += new System.EventHandler(this.TSMI_siparisDetaylari_Click);
            // 
            // kişiİşlemleriToolStripMenuItem
            // 
            this.kişiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_tedarikciler,
            this.TSMI_musteriler,
            this.çalışanlarToolStripMenuItem});
            this.kişiİşlemleriToolStripMenuItem.Name = "kişiİşlemleriToolStripMenuItem";
            this.kişiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.kişiİşlemleriToolStripMenuItem.Text = "Kişi İşlemleri";
            // 
            // TSMI_tedarikciler
            // 
            this.TSMI_tedarikciler.Name = "TSMI_tedarikciler";
            this.TSMI_tedarikciler.Size = new System.Drawing.Size(224, 26);
            this.TSMI_tedarikciler.Text = "Tedarikçiler";
            this.TSMI_tedarikciler.Click += new System.EventHandler(this.TSMI_tedarikciler_Click);
            // 
            // TSMI_musteriler
            // 
            this.TSMI_musteriler.Name = "TSMI_musteriler";
            this.TSMI_musteriler.Size = new System.Drawing.Size(224, 26);
            this.TSMI_musteriler.Text = "Müşteriler";
            this.TSMI_musteriler.Click += new System.EventHandler(this.TSMI_musteriler_Click);
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_personeller,
            this.TSMI_personelBolgeleri});
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            // 
            // TSMI_personeller
            // 
            this.TSMI_personeller.Name = "TSMI_personeller";
            this.TSMI_personeller.Size = new System.Drawing.Size(224, 26);
            this.TSMI_personeller.Text = "Personeller";
            this.TSMI_personeller.Click += new System.EventHandler(this.TSMI_personeller_Click);
            // 
            // TSMI_personelBolgeleri
            // 
            this.TSMI_personelBolgeleri.Name = "TSMI_personelBolgeleri";
            this.TSMI_personelBolgeleri.Size = new System.Drawing.Size(224, 26);
            this.TSMI_personelBolgeleri.Text = "Personel Bölgeleri";
            this.TSMI_personelBolgeleri.Click += new System.EventHandler(this.TSMI_personelBolgeleri_Click);
            // 
            // nakliyeİşlemleriToolStripMenuItem
            // 
            this.nakliyeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_nakliyeciler,
            this.TSMI_bölgeler});
            this.nakliyeİşlemleriToolStripMenuItem.Name = "nakliyeİşlemleriToolStripMenuItem";
            this.nakliyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.nakliyeİşlemleriToolStripMenuItem.Text = "Nakliye İşlemleri";
            // 
            // TSMI_nakliyeciler
            // 
            this.TSMI_nakliyeciler.Name = "TSMI_nakliyeciler";
            this.TSMI_nakliyeciler.Size = new System.Drawing.Size(224, 26);
            this.TSMI_nakliyeciler.Text = "Nakliyeciler";
            this.TSMI_nakliyeciler.Click += new System.EventHandler(this.TSMI_nakliyeciler_Click);
            // 
            // TSMI_bölgeler
            // 
            this.TSMI_bölgeler.Name = "TSMI_bölgeler";
            this.TSMI_bölgeler.Size = new System.Drawing.Size(224, 26);
            this.TSMI_bölgeler.Text = "Bölgeler";
            this.TSMI_bölgeler.Click += new System.EventHandler(this.TSMI_bölgeler_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "NORTHWIND Ticaret A.S.";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kategoriler;
        private System.Windows.Forms.ToolStripMenuItem kişiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_tedarikciler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_musteriler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_urunler;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_satıslar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_siparisDetaylari;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_personeller;
        private System.Windows.Forms.ToolStripMenuItem TSMI_personelBolgeleri;
        private System.Windows.Forms.ToolStripMenuItem nakliyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_nakliyeciler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_bölgeler;
    }
}