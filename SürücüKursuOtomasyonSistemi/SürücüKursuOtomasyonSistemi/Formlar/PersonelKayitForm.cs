using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SurucuKursuOtomasyonSistemi.Formlar
{
    public partial class PersonelKayitForm : Form
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
        MySqlCommand kmt = new MySqlCommand();
        MySqlCommand kmt2 = new MySqlCommand();
        MySqlCommand kmt3 = new MySqlCommand();
        MySqlCommand kmt4 = new MySqlCommand();
        MySqlDataReader dr;
        MySqlDataReader dr2;
        MySqlDataReader dr3;
        MySqlDataReader dr4;
        string komut;
        public PersonelKayitForm()
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

        private void PersonelKayitForm_Load(object sender, EventArgs e)
        {
            TemaYükle();
            btnYeniKayit.Enabled = false;

            if (baglanti.State == ConnectionState.Closed)
            { baglanti_check(); }
            string arac_kombo;

            kmt2.CommandText = "SELECT * FROM arac ";
            kmt2.Connection = baglanti;
            dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                arac_kombo = Convert.ToString(dr2["plaka"]);

                aracId.Items.Add(arac_kombo);
            }

            dr2.Close();

            string sube_kombo;

            kmt2.CommandText = "SELECT * FROM sube ";
            kmt2.Connection = baglanti;
            dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                sube_kombo = Convert.ToString(dr2["ad"]);

                subeId.Items.Add(sube_kombo);
            }

            dr2.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_GotFocus(Object sender, EventArgs e)
        {

        }
        private void textBox1_LostFocus(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string arama;
                arama = txtTc.Text;
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }

                kmt4.CommandText = "SELECT * FROM nufus where tc_no='" + arama + "'";
                kmt4.Connection = baglanti;
                dr4 = kmt4.ExecuteReader();

                if (dr4.HasRows)
                {
                    while (dr4.Read())
                    {

                         txtAd.Text = Convert.ToString(dr4["ad"]); txtAd.Enabled = false; 
                         txtSoyad.Text = Convert.ToString(dr4["soyad"]); txtSoyad.Enabled = false; 

                    }




                }
                dr4.Close();

                kmt.CommandText = "SELECT * FROM personel where tc_no=" + arama;
                kmt.Connection = baglanti;
                dr = kmt.ExecuteReader();



                if (dr.HasRows)
                {
                    while (dr.Read())
                    {


                        if ((dr["gorev"] != null)) { txtGorev.Text = Convert.ToString(dr["gorev"]); txtGorev.Enabled = false; }

                        if ((dr["sube_id"] != null)) { subeId.Text = Convert.ToString(dr["sube_id"]); subeId.Enabled = false; }

                        if ((dr["arac_id"] != null)) { aracId.Text = Convert.ToString(dr["arac_id"]); aracId.Enabled = false; }
                    }

                    dr.Close();


                }

                else
                {

                    dr.Close();

                    MessageBox.Show("Personel bulunamadı yeni kayıt için devam ediniz.");
                    btnYeniKayit.Enabled = true;
                    txtAd.Enabled = false;
                    txtSoyad.Enabled = false;
                    txtGorev.Enabled = true;
                    subeId.Enabled = true;
                    aracId.Enabled = true;

                    txtGorev.Text = "";
                    subeId.Text = "";
                    aracId.Text = "";
                    

                }

            }
            catch (Exception x)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu" + x);
                dr.Close();
                dr2.Close();
                dr3.Close();
                dr4.Close();
            }

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }


                komut = "insert into personel(tc_no,ad,soyad,gorev,sube_id,arac_id) " +
                "values (@tc_no,@ad,@soyad,@gorev,@sube_id,@arac_id)";
                kmt = new MySqlCommand(komut, baglanti);
                kmt.Parameters.AddWithValue("@tc_no", txtTc.Text);
                kmt.Parameters.AddWithValue("@ad", txtAd.Text);
                kmt.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                kmt.Parameters.AddWithValue("@gorev", txtGorev.Text);

                int sube_id_ceken = 0;
                int arac_id_ceken = 0;

                kmt3.CommandText = "SELECT * FROM sube where ad='" + subeId.Text + "'";
                kmt3.Connection = baglanti;
                dr3 = kmt3.ExecuteReader();
                if (dr3.HasRows)
                {
                    while (dr3.Read())
                    {
                        sube_id_ceken = Convert.ToInt32(dr3["sube_id"]);


                    }

                }
                dr3.Close();


                kmt.Parameters.AddWithValue("@sube_id", sube_id_ceken);


                kmt3.CommandText = "SELECT * FROM arac where plaka='" + aracId.Text + "'";
                kmt3.Connection = baglanti;
                dr3 = kmt3.ExecuteReader();
                if (dr3.HasRows)
                {
                    while (dr3.Read())
                    {
                        arac_id_ceken = Convert.ToInt32(dr3["arac_id"]);


                    }

                }
                dr3.Close();
                kmt.Parameters.AddWithValue("@arac_id", arac_id_ceken);






                kmt.ExecuteNonQuery();

                MessageBox.Show("Kayıt Gerçekleştirildi");




            }
            catch (Exception)
            {

                MessageBox.Show("Ekleme Yapılamadı Tc yi Önce Nüfusa Kaydediniz");
                dr.Close();
                dr2.Close();

                dr4.Close();
            }








        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click_1(object sender, EventArgs e)
        {

        }
    }
}




