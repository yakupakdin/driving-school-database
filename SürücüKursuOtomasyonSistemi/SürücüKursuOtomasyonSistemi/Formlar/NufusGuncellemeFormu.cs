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
    public partial class NufusGuncellemeFormu : Form
    {
        public string tc_no,seri_no, ad, soyad,  baba_adi, anne_adi, dogum_yeri, dogum_tarihi, tel_no, cinsiyet, medeni_hal, kan_grubu;

        public static string ConnStr = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
        public MySqlConnection baglanti = new MySqlConnection(ConnStr);
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
        MySqlCommand kmt;
        string komut;
        public NufusGuncellemeFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }


                komut = "UPDATE nufus SET seri_no=@txtSeriNo,ad=@txtAd,soyad=@txtSoyad,baba_adi=@txtBabaAdi,anne_adi=@txtAnneAdi,dogum_yeri=@txtDogumYeri," +
                    "dogum_tarihi=@dtDogumTarihi,tel_no=@txtTelNo,cinsiyet=@cinsiyet,medeni_hal=@txtMedeniHal,kan_grubu=@txtKanGrubu  where tc_no='"+tc_no+"'";
                kmt = new MySqlCommand(komut, baglanti);
                
                kmt.Parameters.AddWithValue("@txtSeriNo", txtSeriNo.Text);
                kmt.Parameters.AddWithValue("@txtAd", txtAd.Text);
                kmt.Parameters.AddWithValue("@txtSoyad", txtSoyad.Text);
                kmt.Parameters.AddWithValue("@txtBabaAdi", txtBabaAdi.Text);
                kmt.Parameters.AddWithValue("@txtAnneAdi", txtAnneAdi.Text);
                kmt.Parameters.AddWithValue("@txtDogumYeri", txtDogumYeri.Text);
                kmt.Parameters.AddWithValue("@dtDogumTarihi", dtDogumTarihi.Value);
                kmt.Parameters.AddWithValue("@txtTelNo", txtTelNo.Text);

                string cinsiyet = "";
                if (radioButton1.Checked)
                    cinsiyet = "E";
                else if (radioButton2.Checked)
                    cinsiyet = "K";
                kmt.Parameters.AddWithValue("@cinsiyet", cinsiyet);

                kmt.Parameters.AddWithValue("@txtMedeniHal", txtMedeniHal.Text);
                kmt.Parameters.AddWithValue("@txtKanGrubu", txtKanGrubu.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı");     


            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }


        }

        private void NufusGuncellemeFormu_Load(object sender, EventArgs e)
        {
            txtTc.Text = tc_no;
            txtSeriNo.Text = seri_no;
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtBabaAdi.Text = baba_adi;
            txtAnneAdi.Text = anne_adi;
            txtDogumYeri.Text = dogum_yeri;
            dtDogumTarihi.Text = dogum_tarihi;
            txtTelNo.Text = tel_no;
            

            if (cinsiyet=="e"||cinsiyet=="E")
            {
                radioButton1.Checked = true;
            }

            else if (cinsiyet == "K" || cinsiyet == "k")
            {
                radioButton2.Checked = true;
            }
                
            txtMedeniHal.Text = medeni_hal;
            txtKanGrubu.Text = kan_grubu;
            txtTc.Enabled = false;
        }
    }
}
