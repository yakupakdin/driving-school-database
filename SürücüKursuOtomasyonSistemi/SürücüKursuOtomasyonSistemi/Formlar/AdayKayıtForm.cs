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
    public partial class AdayKayıtForm : Form
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
        MySqlCommand kmt4 = new MySqlCommand();
        MySqlCommand kmt5 = new MySqlCommand();

        MySqlDataReader dr;
        string komut;
        string komut2;
        
        public AdayKayıtForm()
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

        private void AdayKayıtForm_Load(object sender, EventArgs e)

        {

            TemaYükle();
            tcText.Enabled = false;
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtTelefon.Enabled = false;


             string personel_combo;
             
             if (baglanti.State == ConnectionState.Closed)
             { baglanti_check(); }
             kmt.Connection = baglanti;
             kmt.CommandText = "SELECT * FROM personel   ";
             dr = kmt.ExecuteReader();
             while (dr.Read())
             {
                personel_combo = Convert.ToString(dr["ad"])+" "+Convert.ToString(dr["soyad"]);
                
                personelListe.Items.Add(personel_combo);
            }
            dr.Close();
            string arac_kombo;
            kmt.CommandText = "SELECT * FROM arac   ";
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                arac_kombo = Convert.ToString(dr["plaka"]) + " " + Convert.ToString(dr["arac_tipi"]);

                aracListe.Items.Add(arac_kombo);
            }
            dr.Close();
            string sube_kombo;
            kmt.CommandText = "SELECT * FROM sube   ";
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                sube_kombo = Convert.ToString(dr["ad"]);

                subeListe.Items.Add(sube_kombo);
            }
            dr.Close();







        }

        private void btnAdayKayit_Click(object sender, EventArgs e)
        {
            MySqlCommand id_ceken = new MySqlCommand();
            id_ceken.Connection = baglanti;
            try
            {
                if (baglanti.State == ConnectionState.Closed) { baglanti_check(); }
               

                 komut =("insert into aday(tc_no,ad,soyad,ogrenim_durum,saglik_raporu,adli_belge,ehliyet_turu,kayit_tarihi,personel_id,arac_id,sube_id) " +
                 "values (@txtTc,@txtAd,@txtSoyad,@ogrenim,@saglikraporu,@adlibelge,@ehliyet_tur,@tarih,@personelListe,@aracListe,@subeListe)");
                kmt = new MySqlCommand(komut, baglanti);
                kmt.Parameters.AddWithValue("@txtTc", tcText.Text);
                 kmt.Parameters.AddWithValue("@txtAd", txtAd.Text);
                 kmt.Parameters.AddWithValue("@txtSoyad", txtSoyad.Text);
                 kmt.Parameters.AddWithValue("@ogrenim", ogrenim.Text);
                 string rapor = "";
                 if (radioButton1.Checked)
                     rapor = radioButton1.Text;
                 else if (radioButton2.Checked)
                     rapor = radioButton2.Text;
                 kmt.Parameters.AddWithValue("@saglikraporu", rapor);

                 string belge = "";
                 if (radioButton4.Checked)
                     belge = radioButton4.Text;
                 else if (radioButton3.Checked)
                     belge = radioButton3.Text;
                 kmt.Parameters.AddWithValue("@adlibelge", belge);
                kmt.Parameters.AddWithValue("@ehliyet_tur", cmbEhliyetSinifi.Text);

                kmt.Parameters.AddWithValue("@tarih", dtKayitTarihi.Value);


                string[] txt= personelListe.Text.Split(' '); 
                int id=0;
                
                id_ceken.CommandText = "SELECT * FROM personel where ad= '"+txt[0]+"'";
                dr = id_ceken.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["personel_id"]);
                }
                kmt.Parameters.AddWithValue("@personelListe", id);
                dr.Close();
                string[] txt2;
                txt2 = aracListe.Text.Split(' ');
                id_ceken.CommandText = "SELECT * FROM arac where plaka= '"+txt2[0]+"'";
                dr = id_ceken.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["arac_id"]);


                }
                kmt.Parameters.AddWithValue("@aracListe", id);
                dr.Close();

                string txt3;
                txt3 = subeListe.Text;
                id_ceken.CommandText = "SELECT * FROM sube where ad= '" + txt3+"'";
                dr = id_ceken.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["sube_id"]);


                }
                kmt.Parameters.AddWithValue("@subeListe",id);
                dr.Close();
                MySqlCommand kmt2 = new MySqlCommand();
                komut2 = ("insert into sinavlar(tc_no,yazili_tarihi,drks_tarihi) values(@tcText,@yaziliText,@drksText)");
                kmt2 = new MySqlCommand(komut2, baglanti);
                kmt2.Parameters.AddWithValue("@tcText", tcText.Text);
                kmt2.Parameters.AddWithValue("@yaziliText",yaziliListe.Text);
                kmt2.Parameters.AddWithValue("@drksText", drksListe.Text);

                //ucret kısmı için tabloda ilk alanı oluşturuyoruz.


                MySqlCommand kmt3 = new MySqlCommand();
                string komut3;

                komut3 = ("insert into ucret(tc_no) values(@tcText)");
                kmt3 = new MySqlCommand(komut3, baglanti);
               kmt3.Parameters.AddWithValue("@tcText", tcText.Text);

                string komut5 = ("UPDATE aday SET ucret_id=(select odeme_id from ucret where tc_no='" + tcText.Text + "') where tc_no=" + tcText.Text + "");
                kmt5 = new MySqlCommand(komut5, baglanti);
                
                

                //aday tablosuna foreign key olan sinav id ekliyoruz..
                string komut4 = ("UPDATE aday SET sinav_id=(select not_id from sinavlar where tc_no='" + tcText.Text + "') where tc_no=" + tcText.Text + "");
                kmt4 = new MySqlCommand(komut4, baglanti);
                





                kmt.ExecuteNonQuery();
                kmt2.ExecuteNonQuery();
                kmt3.ExecuteNonQuery();
                kmt4.ExecuteNonQuery();
                kmt5.ExecuteNonQuery();

                foreach (Control item in this.Controls)

                {

                    if (item is TextBox)

                    {

                        TextBox tbox = (TextBox)item;
                        
                        tbox.Clear();

                    }
                    if (item is ComboBox)

                    {

                        
                        ComboBox box = (ComboBox)item;
                        box.Text = " ";
                        

                    }

                }

                
                











                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception x)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu."+x);
            }

        }

        private void chcVar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string arama;
                arama = aramaText.Text;
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }

                kmt.CommandText = "SELECT * FROM nufus where tc_no=" + arama;
                kmt.Connection = baglanti;
                dr = kmt.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        tcText.Text = Convert.ToString(dr["tc_no"]);
                        txtAd.Text = Convert.ToString(dr["ad"]);
                        txtSoyad.Text = Convert.ToString(dr["soyad"]);
                        txtTelefon.Text = Convert.ToString(dr["tel_no"]);


                    }
                    button1.Enabled = false;
                    aramaText.Enabled = false;
                    dr.Close();
                }
                else
                {

                    MessageBox.Show("Geçerli Bir Tc Giriniz!!");
                    dr.Close();

                }

            } catch{
                MessageBox.Show("Geçerli Bir Giriş Yapınız");
            }
            }
       




        private void aramaText_TextChanged(object sender, EventArgs e)
        {



        }

        private void aramaText_Click(object sender, EventArgs e)
        {

        }

        private void aramaText_MouseClick(object sender, MouseEventArgs e)
        {
            aramaText.Text = "";
        }
    }
}
