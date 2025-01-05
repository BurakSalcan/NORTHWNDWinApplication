using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTHWNDWinApplication.Northwind_İçerikleri.Kişi_İşlemleri
{
    public partial class Tedarikciler : Form
    {
        int rowindex = -1;
        public Tedarikciler()
        {
            InitializeComponent();
        }

        private void Tedarikciler_Load(object sender, EventArgs e)
        {
            TedarikciGetir();
        }

        private void TedarikciGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Suppliers";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tedarikçi No");
            dt.Columns.Add("Şirket Adı");
            dt.Columns.Add("Arayan Kişi");
            dt.Columns.Add("Ünvan");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Şehir");
            dt.Columns.Add("Bölge");
            dt.Columns.Add("Ülke");
            dt.Columns.Add("Posta Kodu");
            dt.Columns.Add("Telefon Numarası");
            dt.Columns.Add("Fax Numarası");
            dt.Columns.Add("Ana Sayfa");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string sirketIsim = reader.GetString(1);
                string arayan = reader.GetString(2);
                string unvan = reader.GetString(3);
                string adres = reader.GetString(4);
                string sehir = reader.GetString(5);
                string bolge = reader.IsDBNull(6) ? " " : reader.GetString(6);
                string postaKodu = reader.GetString(7);
                string ulke = reader.GetString(8);
                string telNo = reader.GetString(9);
                string faxNo = reader.IsDBNull(10) ? " " : reader.GetString(10);
                string anaSayfa = reader.IsDBNull(11) ? " " : reader.GetString(11);
                dt.Rows.Add(id, sirketIsim, arayan, unvan, adres, sehir, bolge, postaKodu, ulke, telNo, faxNo, anaSayfa);
            }

            DGV_tedarikciler.DataSource = dt;
        }

        private void DGV_tedarikciler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DGV_tedarikciler.ClearSelection();
                rowindex = DGV_tedarikciler.HitTest(e.X, e.Y).RowIndex;

                if (rowindex != -1)
                {
                    //MessageBox.Show("Sağ Button", "Tıklandı");
                    CMS_Tedarikciler.Show(DGV_tedarikciler, e.X, e.Y);
                    DGV_tedarikciler.Rows[rowindex].Selected = true;
                }
            }
        }

        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                btn_duzenle.Visible = true;
                int id = Convert.ToInt32(DGV_tedarikciler.Rows[rowindex].Cells[0].Value);

                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers WHERE SupplierID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb_ID.Text = reader.GetInt32(0).ToString();
                        tb_sirketAd.Text = reader.GetString(1);
                        tb_arayanKisi.Text = reader.GetString(2);
                        tb_unvan.Text = reader.GetString(3);
                        tb_adres.Text = reader.GetString(4);
                        tb_sehir.Text = reader.GetString(5);
                        tb_bolge.Text = reader.IsDBNull(6) == false ? reader.GetString(6) : "";
                        tb_postaKodu.Text = reader.GetString(7);
                        tb_ulke.Text = reader.GetString(8);
                        mtb_telNo.Text = reader.GetString(9);
                        mtb_faxNo.Text = reader.IsDBNull(10) == false ? reader.GetString(10) : "";
                        tb_anaSayfa.Text = reader.IsDBNull(11) == false ? reader.GetString(11) : "";
                    }
                }
                catch
                {
                    MessageBox.Show("Kategori getirilirken bir hata oluştu reisim", "Hata Var");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(DGV_tedarikciler.Rows[rowindex].Cells[0].Value);

                if (MessageBox.Show($"{id} id'li kategori silinecektir.\n Onaylıyor musunuz?", "Kategori Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Suppliers WHERE SupplierID=@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id);
                    try { con.Open(); cmd.ExecuteNonQuery(); }
                    finally { con.Close(); }
                    TedarikciGetir();
                }

            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) VALUES(@name,@cname, @ctit, @add, @city, @reg, @pcode, @coun, @pho, @fax, @hpage)";
            cmd.Parameters.AddWithValue("@name", tb_sirketAd.Text);
            cmd.Parameters.AddWithValue("@cname", tb_arayanKisi.Text);
            cmd.Parameters.AddWithValue("@ctit", tb_unvan.Text);
            cmd.Parameters.AddWithValue("@add", tb_adres.Text);
            cmd.Parameters.AddWithValue("@city", tb_sehir.Text);
            cmd.Parameters.AddWithValue("@reg", tb_bolge.Text);
            cmd.Parameters.AddWithValue("@pcode", tb_ulke.Text);
            cmd.Parameters.AddWithValue("@coun", tb_postaKodu.Text);
            cmd.Parameters.AddWithValue("@pho", mtb_telNo.Text);
            cmd.Parameters.AddWithValue("@fax", mtb_faxNo.Text);
            cmd.Parameters.AddWithValue("@hpage", tb_anaSayfa.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                tb_sirketAd.Text = tb_arayanKisi.Text = tb_unvan.Text = tb_adres.Text = tb_sehir.Text = tb_bolge.Text = tb_ulke.Text = tb_postaKodu.Text = mtb_telNo.Text = mtb_faxNo.Text = tb_anaSayfa.Text = "";
                MessageBox.Show("Kategori başarıyla eklendi", "Başarılı");
            }
            catch
            {
                MessageBox.Show("Kategori eklenirken bir hata oluştu", "Hata Var");
            }
            finally
            {
                con.Close();
            }
            TedarikciGetir();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_sirketAd.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Suppliers SET CompanyName=@name, ContactName=@cname, ContactTitle=@ctit, Address=@add, City=@city, Region=@reg, PostalCode=@pcode, Country=@coun, Phone=@pho, Fax=@fax, HomePage=@hpage WHERE SupplierID=@id";
                cmd.Parameters.AddWithValue("@name", tb_sirketAd.Text);
                cmd.Parameters.AddWithValue("@cname", tb_arayanKisi.Text);
                cmd.Parameters.AddWithValue("@ctit", tb_unvan.Text);
                cmd.Parameters.AddWithValue("@add", tb_adres.Text);
                cmd.Parameters.AddWithValue("@city", tb_sehir.Text);
                cmd.Parameters.AddWithValue("@reg", tb_bolge.Text);
                cmd.Parameters.AddWithValue("@pcode", tb_ulke.Text);
                cmd.Parameters.AddWithValue("@coun", tb_postaKodu.Text);
                cmd.Parameters.AddWithValue("@pho", mtb_telNo.Text);
                cmd.Parameters.AddWithValue("@fax", mtb_faxNo.Text);
                cmd.Parameters.AddWithValue("@hpage", tb_anaSayfa.Text);
                cmd.Parameters.AddWithValue("@id", tb_ID.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori başarıyla güncellenmiştir", "Başarılı");
                }
                catch
                {
                    MessageBox.Show("Kategori güncellenirken bir hata oluştu", "Hata Var");
                }
                finally
                {
                    con.Close();
                }
                btn_duzenle.Visible = false;
                tb_sirketAd.Text = tb_arayanKisi.Text = tb_unvan.Text = tb_adres.Text = tb_sehir.Text = tb_bolge.Text = tb_ulke.Text = tb_postaKodu.Text = mtb_telNo.Text = mtb_faxNo.Text = tb_anaSayfa.Text = "";
                TedarikciGetir();
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tb_sirketAd.Text = tb_arayanKisi.Text = tb_unvan.Text = tb_adres.Text = tb_sehir.Text = tb_bolge.Text = tb_ulke.Text = tb_postaKodu.Text = mtb_telNo.Text = mtb_faxNo.Text = tb_anaSayfa.Text = "";
        }
    }
}
