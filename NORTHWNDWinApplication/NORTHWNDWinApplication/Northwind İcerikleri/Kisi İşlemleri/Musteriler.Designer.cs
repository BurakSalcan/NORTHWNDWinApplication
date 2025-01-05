namespace NORTHWNDWinApplication.Northwind_İçerikleri.Kişi_İşlemleri
{
    partial class Musteriler
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
            this.DGV_musteriler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMS_Musteriler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_sirketAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_arayanKisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_unvan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sehir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_bolge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ulke = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_postaKodu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.mtb_telNo = new System.Windows.Forms.MaskedTextBox();
            this.mtb_faxNo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_musteriler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.CMS_Musteriler.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_musteriler
            // 
            this.DGV_musteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_musteriler.Location = new System.Drawing.Point(12, 288);
            this.DGV_musteriler.Name = "DGV_musteriler";
            this.DGV_musteriler.RowHeadersWidth = 51;
            this.DGV_musteriler.RowTemplate.Height = 24;
            this.DGV_musteriler.Size = new System.Drawing.Size(951, 234);
            this.DGV_musteriler.TabIndex = 0;
            this.DGV_musteriler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_musteriler_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtb_faxNo);
            this.groupBox1.Controls.Add(this.mtb_telNo);
            this.groupBox1.Controls.Add(this.btn_duzenle);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_postaKodu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_ulke);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_bolge);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_sehir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_adres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_unvan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_arayanKisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_sirketAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CMS_Musteriler
            // 
            this.CMS_Musteriler.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_Musteriler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_duzenle,
            this.TSMI_sil});
            this.CMS_Musteriler.Name = "CMS_Musteriler";
            this.CMS_Musteriler.Size = new System.Drawing.Size(133, 52);
            // 
            // TSMI_duzenle
            // 
            this.TSMI_duzenle.Name = "TSMI_duzenle";
            this.TSMI_duzenle.Size = new System.Drawing.Size(210, 24);
            this.TSMI_duzenle.Text = "Düzenle";
            this.TSMI_duzenle.Click += new System.EventHandler(this.TSMI_duzenle_Click);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(210, 24);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(9, 64);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(145, 22);
            this.tb_ID.TabIndex = 1;
            // 
            // tb_sirketAd
            // 
            this.tb_sirketAd.Location = new System.Drawing.Point(9, 137);
            this.tb_sirketAd.Name = "tb_sirketAd";
            this.tb_sirketAd.Size = new System.Drawing.Size(145, 22);
            this.tb_sirketAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şirket Adı:";
            // 
            // tb_arayanKisi
            // 
            this.tb_arayanKisi.Location = new System.Drawing.Point(9, 207);
            this.tb_arayanKisi.Name = "tb_arayanKisi";
            this.tb_arayanKisi.Size = new System.Drawing.Size(145, 22);
            this.tb_arayanKisi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arayan Kişi: ";
            // 
            // tb_unvan
            // 
            this.tb_unvan.Location = new System.Drawing.Point(279, 64);
            this.tb_unvan.Name = "tb_unvan";
            this.tb_unvan.Size = new System.Drawing.Size(145, 22);
            this.tb_unvan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ünvan: ";
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(279, 137);
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(145, 22);
            this.tb_adres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres: ";
            // 
            // tb_sehir
            // 
            this.tb_sehir.Location = new System.Drawing.Point(279, 207);
            this.tb_sehir.Name = "tb_sehir";
            this.tb_sehir.Size = new System.Drawing.Size(145, 22);
            this.tb_sehir.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şehir: ";
            // 
            // tb_bolge
            // 
            this.tb_bolge.Location = new System.Drawing.Point(529, 64);
            this.tb_bolge.Name = "tb_bolge";
            this.tb_bolge.Size = new System.Drawing.Size(145, 22);
            this.tb_bolge.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bölge: ";
            // 
            // tb_ulke
            // 
            this.tb_ulke.Location = new System.Drawing.Point(529, 137);
            this.tb_ulke.Name = "tb_ulke";
            this.tb_ulke.Size = new System.Drawing.Size(145, 22);
            this.tb_ulke.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ülke: ";
            // 
            // tb_postaKodu
            // 
            this.tb_postaKodu.Location = new System.Drawing.Point(529, 207);
            this.tb_postaKodu.Name = "tb_postaKodu";
            this.tb_postaKodu.Size = new System.Drawing.Size(145, 22);
            this.tb_postaKodu.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Posta Kodu: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(747, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Telefon No: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(747, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fax No: ";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(787, 207);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(80, 23);
            this.btn_ekle.TabIndex = 22;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(750, 175);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(145, 23);
            this.btn_temizle.TabIndex = 23;
            this.btn_temizle.Text = "Formu Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(787, 207);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(80, 23);
            this.btn_duzenle.TabIndex = 24;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.UseWaitCursor = true;
            this.btn_duzenle.Visible = false;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // mtb_telNo
            // 
            this.mtb_telNo.Location = new System.Drawing.Point(750, 63);
            this.mtb_telNo.Mask = "(999) 000-0000";
            this.mtb_telNo.Name = "mtb_telNo";
            this.mtb_telNo.Size = new System.Drawing.Size(145, 22);
            this.mtb_telNo.TabIndex = 25;
            // 
            // mtb_faxNo
            // 
            this.mtb_faxNo.Location = new System.Drawing.Point(750, 136);
            this.mtb_faxNo.Mask = "(999) 000-0000";
            this.mtb_faxNo.Name = "mtb_faxNo";
            this.mtb_faxNo.Size = new System.Drawing.Size(145, 22);
            this.mtb_faxNo.TabIndex = 26;
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_musteriler);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_musteriler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CMS_Musteriler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_musteriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip CMS_Musteriler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_postaKodu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_ulke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_bolge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_sehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_unvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_arayanKisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sirketAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.MaskedTextBox mtb_faxNo;
        private System.Windows.Forms.MaskedTextBox mtb_telNo;
    }
}