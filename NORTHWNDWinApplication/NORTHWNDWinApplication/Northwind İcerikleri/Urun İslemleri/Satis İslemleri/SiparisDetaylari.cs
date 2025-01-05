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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NORTHWNDWinApplication.Northwind_İçerikleri
{
    public partial class SiparisDetaylari : Form
    {
        public SiparisDetaylari()
        {
            InitializeComponent();
        }

        private void SiparisDetaylari_Load(object sender, EventArgs e)
        {
            DetayGetir();
        }

        private void DetayGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT OD.OrderID, P.ProductName, OD.UnitPrice, OD.Quantity, OD.Discount FROM[Order Details] as OD JOIN Products as P ON OD.ProductID = P.ProductID";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Sipariş No");
            dt.Columns.Add("Ürün İsim");
            dt.Columns.Add("Ürün Fiyatı");
            dt.Columns.Add("Ürün Miktarı");
            dt.Columns.Add("İndirim miktarı");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string isim = reader.GetString(1);
                decimal fiyat = reader.GetDecimal(2);
                short miktar = reader.GetInt16(3);
                float indirim = reader.GetFloat(4);
                string yuzde = indirim.ToString("0.00");

                dt.Rows.Add(id, isim, fiyat, miktar, indirim);
            }
            DGV_detay.DataSource = dt;
        }
    }
}
