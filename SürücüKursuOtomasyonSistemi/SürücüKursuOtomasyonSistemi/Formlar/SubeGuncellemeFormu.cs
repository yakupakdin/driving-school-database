using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SürücüKursuOtomasyonSistemi.Formlar
{
    public partial class SubeGuncellemeFormu : Form
    {public string ad,telNo,adres;
        public static string ConnStr = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
        public MySqlConnection baglanti = new MySqlConnection(ConnStr);
        string komut;
        MySqlCommand kmt = new MySqlCommand();
        public string baglanti_check()
        {
            try
            {
                baglanti.Open();
                return "true";

            }
            catch (MySqlException x)
            {
                return x.Message;
            }

        }

        private void SubeGuncellemeFormu_Load(object sender, EventArgs e)
        {
            txtSubeAdi.Text = ad;
            txtTelefon.Text = telNo;
            txtAdres.Text = adres;
            txtSubeNumarasi.Text = subeId.ToString();
            txtSubeNumarasi.Enabled = false;
        }

        public int subeId;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        public SubeGuncellemeFormu()
        {
            InitializeComponent();
        }
        public void guncelle()
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }
                

               
                komut = ("UPDATE sube SET sube_id="+Convert.ToInt32(txtSubeNumarasi.Text)+ " ,ad='" + txtSubeAdi.Text + "',tel_no='" + txtTelefon.Text + "', adres='" + txtAdres.Text + "' where sube_id=" + Convert.ToInt32(txtSubeNumarasi.Text) + "" );
                kmt = new MySqlCommand(komut, baglanti);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı.");
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata);
            }

        }
    }
}
