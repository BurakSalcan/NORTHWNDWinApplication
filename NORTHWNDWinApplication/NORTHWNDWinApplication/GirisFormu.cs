using NORTHWNDWinApplication.Model;
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

namespace NORTHWNDWinApplication
{
    public partial class GirisFormu : Form
    {
        bool islogin = false;

        public GirisFormu()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_kullanici.Text) && !String.IsNullOrEmpty(tb_sifre.Text))
            {
                //using otomatik olarak try-finally komutları üretir
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=true"))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT EmployeeID, FirstName, LastName, FirstName+' '+LastName FROM Employees WHERE UserName=@un AND Password=@pss";
                    cmd.Parameters.AddWithValue("@un", tb_kullanici.Text);
                    cmd.Parameters.AddWithValue("@pss", tb_sifre.Text);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    User u = null;
                    while (reader.Read())
                    {
                        u = new User();
                        u.ID = reader.GetInt32(0);
                        u.Name = reader.GetString(1);
                        u.Surname = reader.GetString(2);
                        u.Fullname = reader.GetString(3);
                    }
                    if (u!= null)
                    {
                        LoginUser.user = u;
                        islogin = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }//using parantezi bittiği anda using içerisinde oluşturulan nesneyi Dispose eder(Yok eder)
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (islogin == false)
            {
                Application.Exit();
            }
        }
    }
}
