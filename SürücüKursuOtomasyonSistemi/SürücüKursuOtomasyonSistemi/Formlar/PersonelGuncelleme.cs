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
    public partial class PersonelGuncelleme : Form
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

        MySqlDataReader dr;
        public int personel_id;
        public string  tc_no,ad, soyad, gorev, sube_id, arac_id;

        private void PersonelGuncelleme_Load(object sender, EventArgs e)
        {
            txtTc.Text = tc_no;
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtTc.Enabled = false;
            
            txtGorev.Text = gorev;
            comboDoldur(); isimCek();
        }

        public PersonelGuncelleme()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();

        }

        public void comboDoldur()
        {
            string personel_combo;

            if (baglanti.State == ConnectionState.Closed)
            { baglanti_check(); }
            kmt.Connection = baglanti;
            kmt.CommandText = "SELECT * FROM arac   ";
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                personel_combo = Convert.ToString(dr["plaka"]);

                txtPlaka.Items.Add(personel_combo);
            }
            dr.Close();

            string sube_kombo;
            kmt.CommandText = "SELECT * FROM sube   ";
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                sube_kombo = Convert.ToString(dr["ad"]) ;

                txtSube.Items.Add(sube_kombo);
            }
            dr.Close();

            string tel_no;
            kmt.CommandText = "SELECT * FROM nufus where tc_no='"+tc_no+"'";
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                tel_no = Convert.ToString(dr["tel_no"]);
                txtTelefon.Text = tel_no;
                
            }

            dr.Close();
        }
        public void isimCek()
        {
            MySqlCommand id_ceken = new MySqlCommand();
            id_ceken.Connection = baglanti;

            id_ceken.CommandText = "SELECT * FROM arac where arac_id=(select arac_id from personel where personel_id="+personel_id+" )";
            dr = id_ceken.ExecuteReader();
            while (dr.Read())
            {
               txtPlaka.Text = Convert.ToString(dr["plaka"]) ;
            }
            dr.Close();

            id_ceken.CommandText = "SELECT * FROM sube where sube_id=(select sube_id from personel where personel_id=" + personel_id + " )";
            dr = id_ceken.ExecuteReader();
            while (dr.Read())
            {
                txtSube.Text = Convert.ToString(dr["ad"]);
            }
            dr.Close();
            
        }



        public void guncelle()
        {
            MySqlCommand id_ceken = new MySqlCommand();
            id_ceken.Connection = baglanti;
            try
            {
                if (baglanti.State == ConnectionState.Closed) { baglanti_check(); }
                string komut = "";
                int sube_id =0;
                int arac_id = 0;

                id_ceken.CommandText = "SELECT * FROM sube where ad= '" + txtSube.Text + "'";
                dr = id_ceken.ExecuteReader();
                while (dr.Read())
                {
                    sube_id = Convert.ToInt32(dr["sube_id"]);


                }
                dr.Close();


                id_ceken.CommandText = "SELECT * FROM arac where plaka= '" + txtPlaka.Text + "'";
                dr = id_ceken.ExecuteReader();
                while (dr.Read())
                {
                    arac_id = Convert.ToInt32(dr["arac_id"]);


                }
                dr.Close();


                komut = "UPDATE personel SET gorev='"+txtGorev.Text+"',sube_id='"+sube_id+"',arac_id='"+arac_id+"'";
                kmt = new MySqlCommand(komut, baglanti);
                kmt.ExecuteNonQuery();


                string komut2="UPDATE nufus SET tel_no='"+txtTelefon.Text+"' where tc_no='"+txtTc.Text+"'";
                kmt2 = new MySqlCommand(komut2, baglanti);
                kmt2.ExecuteNonQuery();



                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception x)
            {

                MessageBox.Show("Birşeyler Ters Gitti :("+x);
            }





        }
    }
}
