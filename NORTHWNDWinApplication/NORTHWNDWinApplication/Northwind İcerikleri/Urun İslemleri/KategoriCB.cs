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

namespace NORTHWNDWinApplication.Northwind_İçerikleri
{
    public partial class KategoriCB : Form
    {
        public KategoriCB()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Categories (CategoryName, Description) VALUES(@name,@des)";
            cmd.Parameters.AddWithValue("@name", tb_isim.Text);
            cmd.Parameters.AddWithValue("@des", tb_aciklama.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                tb_aciklama.Text = tb_isim.Text = "";
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

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tb_aciklama.Text = tb_isim.Text = tb_aciklama.Text = "";
        }
    }
}
