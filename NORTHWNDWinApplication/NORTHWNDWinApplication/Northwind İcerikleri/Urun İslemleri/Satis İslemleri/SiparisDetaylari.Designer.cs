namespace NORTHWNDWinApplication.Northwind_İçerikleri
{
    partial class SiparisDetaylari
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
            this.DGV_detay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detay)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_detay
            // 
            this.DGV_detay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_detay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_detay.Location = new System.Drawing.Point(12, 278);
            this.DGV_detay.Name = "DGV_detay";
            this.DGV_detay.RowHeadersWidth = 51;
            this.DGV_detay.RowTemplate.Height = 24;
            this.DGV_detay.Size = new System.Drawing.Size(833, 290);
            this.DGV_detay.TabIndex = 0;
            // 
            // SiparisDetaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 580);
            this.Controls.Add(this.DGV_detay);
            this.Name = "SiparisDetaylari";
            this.Text = "SiparisDetaylari";
            this.Load += new System.EventHandler(this.SiparisDetaylari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_detay;
    }
}