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
   


    public partial class KursiyerGuncellemeFormu : Form
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

        MySqlDataReader dr;
        public string tc, ad, soyad, ogrenimDurumu, saglikRapor, adliBelge, ehliyetTuru;

        private void btnAdayKayit_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        public int perId,aracId,subeId,sınavId,ucretId;
        private void KursiyerGuncellemeFormu_Load(object sender, EventArgs e)
        {
            tcText.Text = tc;
            tcText.Enabled = false;

            txtAd.Text = ad;
            txtAd.Enabled = false;
            txtSoyad.Text = soyad;
            txtSoyad.Enabled = false;
            ogrenim.Text = ogrenimDurumu;
            cmbEhliyetSinifi.Text = ehliyetTuru;
            if (saglikRapor == radioButton1.Text)
            radioButton1.Checked = true;
            else if (saglikRapor == radioButton2.Text)
                radioButton2.Checked = true;
            if (adliBelge == radioButton4.Text)
                radioButton4.Checked = true;
            else if (adliBelge == radioButton3.Text)
                radioButton3.Checked = true;
            comboDoldur();
            isimCek();




           

        }

        public KursiyerGuncellemeFormu()
        {
            InitializeComponent();
        }
        public void comboDoldur()
        {
            string personel_combo;

            if (baglanti.State == ConnectionState.Closed)
            { baglanti_check(); }
            kmt.Connection = baglanti;
            kmt.CommandText = "SELECT * FROM personel   ";
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                personel_combo = Convert.ToString(dr["ad"]) + " " + Convert.ToString(dr["soyad"]);

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
        public void isimCek()
        {
            MySqlCommand id_ceken = new MySqlCommand();
            id_ceken.Connection = baglanti;

            id_ceken.CommandText = "SELECT * FROM personel where personel_id= " + perId ;
            dr = id_ceken.ExecuteReader();
            while (dr.Read())
            {
                personelListe.Text = Convert.ToString(dr["ad"]) + " " + Convert.ToString(dr["soyad"]);
            }
            dr.Close();

            id_ceken.CommandText = "SELECT * FROM arac where arac_id= " + aracId;
            dr = id_ceken.ExecuteReader();
            while (dr.Read())
            {
                aracListe.Text = Convert.ToString(dr["plaka"]);
            }
            dr.Close();
            id_ceken.CommandText = "SELECT * FROM sube where sube_id= " + subeId;
            dr = id_ceken.ExecuteReader();
            while (dr.Read())
            {
                subeListe.Text = Convert.ToString(dr["ad"]);
            }
            dr.Close();
            id_ceken.CommandText = "SELECT * FROM sinavlar where not_id= " + sınavId;
            dr = id_ceken.ExecuteReader();
            while (dr.Read())
            {
                yaziliListe.Text = Convert.ToString(dr["yazili_tarihi"]);
                drksListe.Text = Convert.ToString(dr["drks_tarihi"]);
            }
            dr.Close();
        }
        public void guncelle()
        {
            MySqlCommand id_ceken = new MySqlCommand();
            id_ceken.Connection = baglanti;
            string komut="";
            string komut2 = "";
            try
            {
                if (baglanti.State == ConnectionState.Closed) { baglanti_check(); }

                string rapor = "";
                if (radioButton1.Checked == true)
                    rapor = "var";
                else if (radioButton2.Checked == true)
                    rapor = "yok";


                string belge = "";
                if (radioButton4.Checked==true)
                    belge = "var";
                else if (radioButton3.Checked==true)
                    belge = "yok";

                string[] txt = personelListe.Text.Split(' ');
                int id = 0;
                int id1 = 0;
                
                int id3 = 0;
                id_ceken.CommandText = "SELECT * FROM personel where ad= '" + txt[0] + "'";
                dr = id_ceken.ExecuteReader();

                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["personel_id"]);
                }

                dr.Close();

                string[] txt2;
                txt2 = aracListe.Text.Split(' ');
                id_ceken.CommandText = "SELECT * FROM arac where plaka= '" + txt2[0] + "'";
                dr = id_ceken.ExecuteReader();
                while (dr.Read())
                {
                    id1 = Convert.ToInt32(dr["arac_id"]);


                }
                dr.Close();
                string txt3;
                txt3 = subeListe.Text;
                id_ceken.CommandText = "SELECT * FROM sube where ad= '" + txt3 + "'";
                dr = id_ceken.ExecuteReader();
                while (dr.Read())
                {
                    id3 = Convert.ToInt32(dr["sube_id"]);


                }
              
                dr.Close();

                string tarih =Convert.ToString(dtKayitTarihi.Value);
                komut = ("UPDATE aday SET ogrenim_durum='" + ogrenim.Text + "',saglik_raporu='" + rapor + "',adli_belge='" + belge + "',ehliyet_turu='" + cmbEhliyetSinifi.Text + "',kayit_tarihi='" + tarih + "',personel_id=" +id+ ", arac_id="  +id1+  ",sube_id="  +id3+ "  where tc_no="+tcText.Text+"") ;
            
                kmt = new MySqlCommand(komut, baglanti);
                kmt.ExecuteNonQuery();



                MySqlCommand kmt2 = new MySqlCommand();
                komut2 = ("Update  sinavlar set tc_no='" + tcText.Text + "',yazili_tarihi='" + yaziliListe.Text + "',drks_tarihi='" + drksListe.Text + "' where tc_no = '"+tcText.Text+"'");
                kmt2 = new MySqlCommand(komut2, baglanti);
                
               
                kmt2.ExecuteNonQuery();

                MessageBox.Show("Kursiyer Güncelleme İşlemi Gerçekleşti.");
            }
            catch (Exception x)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + x);
            }


        }
    }
}
