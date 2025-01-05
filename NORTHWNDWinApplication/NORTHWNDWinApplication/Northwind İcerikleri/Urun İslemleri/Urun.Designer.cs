namespace NORTHWNDWinApplication.Northwind_İçerikleri
{
    partial class Urun
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kategoriEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_kategoriAd = new System.Windows.Forms.ComboBox();
            this.rb_hayir = new System.Windows.Forms.RadioButton();
            this.rb_evet = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_siparisSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_stokMiktar = new System.Windows.Forms.TextBox();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_urun = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_urun)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_duzenle);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_kategoriEkle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_kategoriAd);
            this.groupBox1.Controls.Add(this.rb_hayir);
            this.groupBox1.Controls.Add(this.rb_evet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_siparisSayisi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_stokMiktar);
            this.groupBox1.Controls.Add(this.tb_fiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(665, 285);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_duzenle.TabIndex = 19;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Visible = false;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_düzenle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(665, 285);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 18;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(554, 285);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 24);
            this.btn_temizle.TabIndex = 17;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            // 
            // btn_kategoriEkle
            // 
            this.btn_kategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kategoriEkle.Location = new System.Drawing.Point(305, 285);
            this.btn_kategoriEkle.Name = "btn_kategoriEkle";
            this.btn_kategoriEkle.Size = new System.Drawing.Size(41, 24);
            this.btn_kategoriEkle.TabIndex = 9;
            this.btn_kategoriEkle.Text = "+";
            this.btn_kategoriEkle.UseVisualStyleBackColor = true;
            this.btn_kategoriEkle.Click += new System.EventHandler(this.btn_kategoriEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kategori Adı: ";
            // 
            // cb_kategoriAd
            // 
            this.cb_kategoriAd.FormattingEnabled = true;
            this.cb_kategoriAd.Location = new System.Drawing.Point(129, 285);
            this.cb_kategoriAd.Name = "cb_kategoriAd";
            this.cb_kategoriAd.Size = new System.Drawing.Size(169, 24);
            this.cb_kategoriAd.TabIndex = 8;
            // 
            // rb_hayir
            // 
            this.rb_hayir.AutoSize = true;
            this.rb_hayir.Location = new System.Drawing.Point(286, 242);
            this.rb_hayir.Name = "rb_hayir";
            this.rb_hayir.Size = new System.Drawing.Size(60, 20);
            this.rb_hayir.TabIndex = 7;
            this.rb_hayir.TabStop = true;
            this.rb_hayir.Text = "Hayır";
            this.rb_hayir.UseVisualStyleBackColor = true;
            // 
            // rb_evet
            // 
            this.rb_evet.AutoSize = true;
            this.rb_evet.Location = new System.Drawing.Point(129, 242);
            this.rb_evet.Name = "rb_evet";
            this.rb_evet.Size = new System.Drawing.Size(55, 20);
            this.rb_evet.TabIndex = 6;
            this.rb_evet.TabStop = true;
            this.rb_evet.Text = "Evet";
            this.rb_evet.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Satışta mı: ";
            // 
            // tb_siparisSayisi
            // 
            this.tb_siparisSayisi.Location = new System.Drawing.Point(129, 197);
            this.tb_siparisSayisi.Name = "tb_siparisSayisi";
            this.tb_siparisSayisi.Size = new System.Drawing.Size(217, 22);
            this.tb_siparisSayisi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sipariş Sayısı: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok Miktarı: ";
            // 
            // tb_stokMiktar
            // 
            this.tb_stokMiktar.Location = new System.Drawing.Point(129, 156);
            this.tb_stokMiktar.Name = "tb_stokMiktar";
            this.tb_stokMiktar.Size = new System.Drawing.Size(217, 22);
            this.tb_stokMiktar.TabIndex = 4;
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(129, 114);
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(217, 22);
            this.tb_fiyat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Fiyatı: ";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(129, 80);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(217, 22);
            this.tb_isim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı: ";
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(129, 40);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(217, 22);
            this.tb_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // DGV_urun
            // 
            this.DGV_urun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_urun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_urun.Location = new System.Drawing.Point(13, 353);
            this.DGV_urun.Name = "DGV_urun";
            this.DGV_urun.RowHeadersWidth = 51;
            this.DGV_urun.RowTemplate.Height = 24;
            this.DGV_urun.Size = new System.Drawing.Size(834, 299);
            this.DGV_urun.TabIndex = 1;
            this.DGV_urun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGV_urun_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_duzenle,
            this.TSMI_sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // TSMI_duzenle
            // 
            this.TSMI_duzenle.Name = "TSMI_duzenle";
            this.TSMI_duzenle.Size = new System.Drawing.Size(132, 24);
            this.TSMI_duzenle.Text = "Düzenle";
            this.TSMI_duzenle.Click += new System.EventHandler(this.TSMI_duzenle_Click);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(132, 24);
            this.TSMI_sil.Text = "Sil";
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 664);
            this.Controls.Add(this.DGV_urun);
            this.Controls.Add(this.groupBox1);
            this.Name = "Urun";
            this.Text = "Urun";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_urun)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_urun;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stokMiktar;
        private System.Windows.Forms.TextBox tb_fiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.RadioButton rb_hayir;
        private System.Windows.Forms.RadioButton rb_evet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_siparisSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kategoriEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_kategoriAd;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
    }
}