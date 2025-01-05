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
    public partial class Bolgeler : Form
    {
        int rowindex = -1;
        public Bolgeler()
        {
            InitializeComponent();
        }

        private void Bolgeler_Load(object sender, EventArgs e)
        {
            BolgeGetir();
        }

        private void BolgeGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT T.TerritoryID, T.TerritoryDescription, R.RegionDescription FROM Territories as T JOIN Region as R ON T.RegionID = R.RegionID";
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Bölge No");
                dt.Columns.Add("Bölge Açıklaması");
                dt.Columns.Add("Ait olduğu Yön");
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string aciklama = reader.GetString(1);
                    string yon = reader.GetString(2);

                    dt.Rows.Add(id, aciklama, yon);
                }
                DGV_bolge.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DGV_bolge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DGV_bolge.ClearSelection();
                rowindex = DGV_bolge.HitTest(e.X, e.Y).RowIndex;

                if (rowindex != -1)
                {
                    //MessageBox.Show("Sağ Button", "Tıklandı");
                    CMS_sagTiklama.Show(DGV_bolge, e.X, e.Y);
                    DGV_bolge.Rows[rowindex].Selected = true;
                }
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Territories (TerritoryDescription) VALUES(@des)";
            cmd.Parameters.AddWithValue("@des", tb_aciklama.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                tb_aciklama.Text = "";
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
            BolgeGetir();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_aciklama.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Territories SET TerritoryDescription=@des WHERE TerritoryID=@id";
                cmd.Parameters.AddWithValue("@des", tb_aciklama.Text);
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
                tb_ID.Text = tb_aciklama.Text = "";
                BolgeGetir();
            }
        }

        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                btn_duzenle.Visible = true;
                int id = Convert.ToInt32(DGV_bolge.Rows[rowindex].Cells[0].Value);
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT TerritoryID, TerritoryDescription FROM Territories WHERE TerritoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb_ID.Text = reader.GetInt32(0).ToString();
                        tb_aciklama.Text = reader.GetString(1);
                    }
                }
                catch
                {
                    MessageBox.Show("Bölgeler getirilirken bir hata ile karşılaştık Houston", "Hata Var");
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
                int id = Convert.ToInt32(DGV_bolge.Rows[rowindex].Cells[0].Value);

                if (MessageBox.Show($"{id} id'li kategori silinecektir.\n Onaylıyor musunuz?", "Kategori Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Territories WHERE TerritoryID=@id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id);
                    try { con.Open(); cmd.ExecuteNonQuery(); }
                    finally { con.Close(); }
                    BolgeGetir();
                }

            }
        }
    }
}
