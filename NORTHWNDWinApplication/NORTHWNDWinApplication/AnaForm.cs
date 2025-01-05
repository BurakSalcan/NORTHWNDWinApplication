using NORTHWNDWinApplication.Model;
using NORTHWNDWinApplication.Northwind_İçerikleri;
using NORTHWNDWinApplication.Northwind_İçerikleri.Kişi_İşlemleri;
using NORTHWNDWinApplication.Northwind_İcerikleri.Kisi_İşlemleri.Calisanlar;
using NORTHWNDWinApplication.Northwind_İçerikleri.Ürün_İşlemleri.Satış_İşlemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTHWNDWinApplication
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            GirisFormu frm = new GirisFormu();
            frm.ShowDialog();

            toolStripStatusLabel1.Text = "Kullanıcı: " + LoginUser.user.Fullname;
        }

        private void TSMI_kategoriler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Kategori))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                Kategori frm = new Kategori();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_urunler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Urun))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                Urun frm = new Urun();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_siparisDetaylari_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(SiparisDetaylari))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                SiparisDetaylari frm = new SiparisDetaylari();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_nakliyeciler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Nakliye))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                Nakliye frm = new Nakliye();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_satıslar_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Satislar))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                Satislar frm = new Satislar();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_bölgeler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Bolgeler))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                Bolgeler frm = new Bolgeler();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_tedarikciler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Tedarikciler))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                Tedarikciler frm = new Tedarikciler();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_musteriler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Musteriler))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                Musteriler frm = new Musteriler();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_personeller_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(Personeller))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                Personeller frm = new Personeller();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void TSMI_personelBolgeleri_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(PersonelBolgeleri))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                PersonelBolgeleri frm = new PersonelBolgeleri();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
    }
}
