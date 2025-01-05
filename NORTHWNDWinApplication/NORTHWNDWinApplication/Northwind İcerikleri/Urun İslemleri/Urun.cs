using NORTHWNDWinApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTHWNDWinApplication.Northwind_İçerikleri
{
    public partial class Urun : Form
    {
        int rowindex = -1;
        public Urun()
        {
            InitializeComponent();
            KategoriListele();
            UrunListele();
        }

        private void btn_kategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriCB ktCB = new KategoriCB();
            ktCB.ShowDialog();
        }

        public void KategoriListele()
        {
            List<Category> kategoriler = new List<Category>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CategoryName FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category k = new Category();
                k.Name = reader.GetString(0);
                kategoriler.Add(k);
            }
            con.Close();
            cb_kategoriAd.Items.Clear();
            cb_kategoriAd.DataSource = kategoriler;
            cb_kategoriAd.DisplayMember = "Name";
        }

        public void UrunListele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT ProductID, ProductName, CompanyName, CategoryName, UnitPrice, UnitsInstock, ReorderLevel, Discontinued FROM Products as P JOIN Categories as C ON C.CategoryID = P.CategoryID JOIN Suppliers as S ON S.SupplierID= P.SupplierID";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ürün Adı");
            dt.Columns.Add("Tedarikçi Şirket");
            dt.Columns.Add("Kategori Adı");
            dt.Columns.Add("Ürün Fiyatı");
            dt.Columns.Add("Stok Miktarı");
            dt.Columns.Add("Minimum Stok Miktarı");
            dt.Columns.Add("Satışta mı");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string isim = reader.GetString(1);
                string sirket = reader.GetString(2);
                string kategori = reader.GetString(3);
                decimal fiyat = reader.GetDecimal(4);
                short stokMik = reader.GetInt16(5);
                short minStok = reader.GetInt16(6);
                bool gelen = reader.GetBoolean(7);
                string satistami = gelen ? "Evet" : "Hayır";


                dt.Rows.Add(id, isim, sirket, kategori, fiyat, stokMik, minStok, satistami);
            }
            DGV_urun.DataSource = dt;
        }

        private void DGV_urun_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DGV_urun.ClearSelection();
                rowindex = DGV_urun.HitTest(e.X, e.Y).RowIndex;

                if (rowindex != -1)
                {
                    //MessageBox.Show("Sağ Button", "Tıklandı");
                    contextMenuStrip1.Show(DGV_urun, e.X, e.Y);
                    DGV_urun.Rows[rowindex].Selected = true;
                }
            }
        }

        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                btn_ekle.Text = "Düzenle";
                int id = Convert.ToInt32(DGV_urun.Rows[rowindex].Cells[0].Value);
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock, ReorderLevel, Discontinued FROM Products WHERE ProductID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb_ID.Text = reader.GetInt32(0).ToString();
                        tb_isim.Text = reader.GetString(1);
                        tb_fiyat.Text = reader.GetDecimal(2).ToString();
                        tb_stokMiktar.Text = reader.GetInt16(3).ToString();
                        tb_siparisSayisi.Text = reader.GetInt16(4).ToString();
                        bool dis = reader.GetBoolean(5);
                        if (dis == true)
                        {
                            rb_evet.Checked = true;
                        }
                        else
                        {
                            rb_hayir.Checked = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Kategori getirilirken bir hata oluştu", "Hata");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice, UnitInStock, ReorderLevel, Discontinued) VALUES (@name,@sID,@cID,@price,@stok,@minstok,@dis)";
            cmd.Parameters.AddWithValue("@name", tb_isim.Text);
            int cid = cb_kategoriAd.SelectedIndex;
            cmd.Parameters.AddWithValue("@cID", cid);
            decimal price = Convert.ToDecimal(tb_fiyat.Text);
            cmd.Parameters.AddWithValue("@price", price);
            int stok = Convert.ToInt16(tb_stokMiktar.Text);
            cmd.Parameters.AddWithValue("@stok", stok);
            int reord = Convert.ToInt16(tb_siparisSayisi.Text);
            cmd.Parameters.AddWithValue("@minstok", reord);
            bool dis = rb_evet.Checked;
            if (dis == true)
            {
                cmd.Parameters.AddWithValue("@dis", rb_evet.Checked);
            }
            else
            {
                cmd.Parameters.AddWithValue("@dis", rb_hayir.Checked);
            }

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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
        }

        private void btn_düzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Products SET ProductID=@id, ProductName=@pn, UnitPrice=@up, UnitInStock=@uis, ReorderLevel=@rol, Discontinued=@dc WHERE ProductID=@id";
                cmd.Parameters.AddWithValue("@pn", tb_isim.Text);
                cmd.Parameters.AddWithValue("@id", tb_ID.Text);
                cmd.Parameters.AddWithValue("@up", tb_fiyat.Text);
                cmd.Parameters.AddWithValue("@uis", tb_stokMiktar.Text);
                cmd.Parameters.AddWithValue("@rol", tb_siparisSayisi.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarıyla güncellenmiştir", "Başarılı");
                }
                catch
                {
                    MessageBox.Show("Ürün güncellenirken bir hata oluştu", "Hata Var");
                }
                finally
                {
                    con.Close();
                }
                btn_duzenle.Visible = false;
                tb_ID.Text = tb_isim.Text = tb_fiyat.Text = tb_siparisSayisi.Text = tb_stokMiktar.Text = "";
            }
        }

    }
}

