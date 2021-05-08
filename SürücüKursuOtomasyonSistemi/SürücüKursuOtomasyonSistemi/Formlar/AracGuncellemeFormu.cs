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
    public partial class AracGuncellemeFormu : Form
    {
        public string plaka, arac_tipi, arac_marka, arac_model, vitesTuru;
        public int subeId;
        public static string ConnStr = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
        public MySqlConnection baglanti = new MySqlConnection(ConnStr);
        string komut;
        MySqlCommand kmt = new MySqlCommand();
        MySqlCommand kmt2 = new MySqlCommand();
        private MySqlDataReader dr;
        private MySqlDataReader dr3;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void subeler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {

        }

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
        
        private void AracGuncellemeFormu_Load(object sender, EventArgs e)
        {
            baglanti_check();
            txtMarka.Text = arac_marka;
            txtModel.Text = arac_model;
            txtPlaka.Text = plaka;
            txtTip.Text = arac_tipi;
            if (vitesTuru == "otomatik")
                oto.Checked = true;
            else if (vitesTuru == "manuel")
                man.Checked = true;

            MySqlCommand id_ceken = new MySqlCommand();
            id_ceken.Connection = baglanti;

            id_ceken.CommandText = "SELECT * FROM sube where sube_id= " + subeId;
            dr = id_ceken.ExecuteReader();
            while (dr.Read())
            {
                subeler.Text= Convert.ToString(dr["ad"]);
            }
            dr.Close();

            string sube_kombo;
            kmt.Connection = baglanti;
            kmt.CommandText = "SELECT * FROM sube   ";
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                sube_kombo = Convert.ToString(dr["ad"]);

                subeler.Items.Add(sube_kombo);
            }
            dr.Close();


        }
        public void guncelle()
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }
                string tur = "";

                if (oto.Checked == true)
                {
                    tur = "otomatik";

                }
                else if (man.Checked == true)
                {
                    tur = "manuel";
                }


                    int sube_id_ceken = 0;
                    kmt2.CommandText = "SELECT * FROM sube where ad='" + subeler.Text + "'";
                    kmt2.Connection = baglanti;
                    dr3 = kmt2.ExecuteReader();
                    if (dr3.HasRows)
                    {
                        while (dr3.Read())
                        {
                            sube_id_ceken = Convert.ToInt32(dr3["sube_id"]);


                        }
                        dr3.Close();
                    }
                

                    komut = ("UPDATE arac SET plaka='"+txtPlaka.Text+ "',arac_tipi='"+txtTip.Text+"',arac_marka='"+ txtMarka.Text + "',arac_model='"+ txtModel.Text + "',vites_turu='"+ tur + "',sube_id="+ sube_id_ceken + " where plaka='"+plaka+"'");
                kmt = new MySqlCommand(komut, baglanti);
                kmt.ExecuteNonQuery();

                MessageBox.Show("Güncelleme İşlemi Gerçekleşti" );
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata);
            }

        }

        public AracGuncellemeFormu()
        {
            InitializeComponent();
        }
    }
}
