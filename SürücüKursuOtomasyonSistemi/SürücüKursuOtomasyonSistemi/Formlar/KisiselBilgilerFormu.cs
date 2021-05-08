using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SurucuKursuOtomasyonSistemi.Formlar
{
    public partial class KisiselBilgilerFormu : Form
    {

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



        public KisiselBilgilerFormu()
        {
            InitializeComponent();
        }

        private void TemaYükle()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Renkler.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Renkler.SecondaryColor;
                }
            }


        }

        private void KisiselBilgilerFormu_Load(object sender, EventArgs e)
        {
            TemaYükle();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }
            
                
                komut = "insert into nufus(tc_no,seri_no,ad,soyad,baba_adi,anne_adi,dogum_yeri,dogum_tarihi,tel_no,cinsiyet,medeni_hal,kan_grubu) " +
                "values (@txtTc,@txtSeriNo,@txtAd,@txtSoyad,@txtBabaAdi,@txtAnneAdi,@txtDogumYeri,@dtDogumTarihi,@txtTelNo,@cinsiyet,@txtMedeniHal,@txtKanGrubu)";
                kmt = new MySqlCommand(komut, baglanti);
                kmt.Parameters.AddWithValue("@txtTc", txtTc.Text);
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
                MessageBox.Show("Müşteriyi Nüfusa Kaydetme İşlemi Gerçekleşti.");

                foreach (Control item in this.Controls)

                {

                    if (item is TextBox)

                    {

                        TextBox tbox = (TextBox)item;

                        tbox.Clear();

                    }

                }







            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
    }
}

