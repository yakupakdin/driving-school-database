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

    public partial class AraçKaydetForm : Form
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
        MySqlDataReader dr;
        
        MySqlDataReader dr3;
        string komut;
        public AraçKaydetForm()
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

        private void AraçKaydetForm_Load(object sender, EventArgs e)
        {
            TemaYükle();

            string subelers;

            if (baglanti.State == ConnectionState.Closed)
            { baglanti_check(); }

            kmt.Connection = baglanti;
            kmt.CommandText = "SELECT * FROM sube   ";

            dr = kmt.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    subelers = Convert.ToString(dr["ad"]);

                    subeler.Items.Add(subelers);
                }
                dr.Close();
            }
            


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }


                komut = "insert into arac(plaka,arac_tipi,arac_marka,arac_model,vites_turu,sube_id) " +
                "values (@plaka,@arac_tipi,@arac_marka,@arac_model,@vites_turu,@sube_id)";
                kmt = new MySqlCommand(komut, baglanti);
                kmt.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                kmt.Parameters.AddWithValue("@arac_tipi", txtTip.Text);
                kmt.Parameters.AddWithValue("@arac_marka", txtMarka.Text);
                kmt.Parameters.AddWithValue("@arac_model", txtModel.Text);
                string tur="";
                if (oto.Checked == true)
                {
                    tur = "otomatik";

                }
                else if (man.Checked ==true)
                {
                    tur = "manuel";

                }
                kmt.Parameters.AddWithValue("@vites_turu", tur);
                int sube_id_ceken=0;
                kmt3.CommandText = "SELECT * FROM sube where ad='"+subeler.Text+"'";
                kmt3.Connection = baglanti;
                dr3 = kmt3.ExecuteReader();
                if (dr3.HasRows)
                { 
                while (dr3.Read())
                {
                    sube_id_ceken = Convert.ToInt32(dr3["sube_id"]);

                   
                }
                    dr3.Close();
                }
                

                kmt.Parameters.AddWithValue("@sube_id", sube_id_ceken);


                kmt.ExecuteNonQuery();

                MessageBox.Show("Kayıt Gerçekleştirildi");




            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string arama;
                arama = txtPlaka.Text;

                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }

                kmt.CommandText = "SELECT * FROM arac where plaka='" + arama +"'";
                kmt.Connection = baglanti;

                dr = kmt.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if ((dr["sube_id"] != null)) { subeler.Text = Convert.ToString(dr["sube_id"]); subeler.Enabled = false; }
                        if ((dr["arac_tipi"] != null)) { txtTip.Text = Convert.ToString(dr["arac_tipi"]); txtTip.Enabled = false; }
                        if ((dr["arac_marka"] != null)) { txtMarka.Text = Convert.ToString(dr["arac_marka"]); txtMarka.Enabled = false; }
                        if ((dr["arac_model"] != null)) { txtModel.Text = Convert.ToString(dr["arac_model"]); txtModel.Enabled = false; btnKaydet.Enabled = false; }

                        

                        if (Convert.ToString(dr["vites_turu"]) == "otomatik")
                        {
                            oto.Checked = true;
                            
                            man.Enabled = false;
                        }
                        else if (Convert.ToString(dr["vites_turu"]) == "manuel")
                        {
                            man.Checked = true;
                            oto.Enabled = false;
                        }


                        
                    }
                    dr.Close();

                }
                




                else
                {
                    dr.Close();
                    subeler.Enabled = true;
                    txtTip.Enabled = true;
                    txtMarka.Enabled = true;
                     txtModel.Enabled = true;
                    oto.Enabled = true;
                    man.Enabled = true;
                    btnKaydet.Enabled = true;
                    oto.Checked = false;
                    man.Checked = false;
                    subeler.Text = "";
                    txtTip.Text = "";
                    txtMarka.Text="";
                    txtModel.Text="";

                    //if (subeler.Text=="")
                    //{
                    //    string sube_kombo;
                    //    kmt2.CommandText = "SELECT * FROM sube   ";
                    //    kmt2.Connection = baglanti;
                    //    dr2 = kmt2.ExecuteReader();
                    //    while (dr2.Read())
                    //    {
                    //        sube_kombo = Convert.ToString(dr2["ad"]);

                    //        subeler.Items.Add(sube_kombo);
                    //    }
                    //}
                    
                    dr.Close();
                    //dr2.Close();




                }
                
            }
            catch(Exception x)
            {
                MessageBox.Show("Geçerli Bir Giriş Yapınız"+x);
            }
            

        }
    }
}
