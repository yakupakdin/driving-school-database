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
    public partial class btnOdemeYap : Form
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
        MySqlDataReader dr2;
        string komut;


        public btnOdemeYap()
        {
            InitializeComponent();
            txtToplam.GotFocus += txtToplam_GotFocus;
            txtToplam.LostFocus += txtToplam_LostFocus;

        }
        private void txtToplam_GotFocus(object sender, EventArgs e)
        {

        }
        private void txtToplam_LostFocus(object sender, EventArgs e)
        {
            txtKalanBorc.Text = txtToplam.Text;
            txtKalanBorc.Enabled = false;
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

        private void OdemeFormu_Load(object sender, EventArgs e)
        {

            TemaYükle();
        }

        private void tcKontrol_Click(object sender, EventArgs e)
        {
            TemaYükle();
            try
            {
                string arama;
                arama = txtTc.Text;
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }

                kmt2.CommandText = "Select * From nufus where tc_no='" + arama + "'";
                kmt2.Connection = baglanti;
                dr2 = kmt2.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        txtAd.Text = Convert.ToString(dr2["ad"]) + " " + Convert.ToString(dr2["soyad"]);
                    }
                    dr2.Close();

                }

                kmt.CommandText = "SELECT * FROM ucret where tc_no='" + arama + "'";
                kmt.Connection = baglanti;
                dr = kmt.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtTc.Text = "";
                        txtTc.Text = Convert.ToString(dr["tc_no"]);
                        dateSon.Text = Convert.ToString(dr["odeme_tarihi"]);
                        txtToplam.Text = Convert.ToString(dr["toplam_borc"]);
                        txtKalanBorc.Text = Convert.ToString(dr["kalan_borc"]);
                        if (Convert.ToString(dr["odeme_sekli"]) == "nakit")
                        {
                            nakit.Checked = true;
                            kKart.Enabled = false;
                        }
                        else if (Convert.ToString(dr["odeme_sekli"]) == "kredi kartı")
                        {
                            kKart.Checked = true;
                            nakit.Enabled = false;

                        }


                    }
                    txtTc.Enabled = false;
                    txtAd.Enabled = false;




                    //kalan borc 0 ise butonu false yapma
                    if (Convert.ToString(dr["kalan_borc"]) == "0")
                    {
                        button1.Enabled = false;
                    }
                    else if (Convert.ToString(dr["kalan_borc"]) != "0")
                    {
                        button1.Enabled = true;
                    }
                    //odeme tarihi text enabled durumu
                    if (Convert.ToString(dr["odeme_tarihi"]) == "")
                    {
                        dateSon.Enabled = true;
                    }
                    else if (Convert.ToString(dr["odeme_tarihi"]) != "")
                    {
                        dateSon.Enabled = false;
                    }

                    //toplam borc enabled durumu
                    if (Convert.ToString(dr["toplam_borc"]) == "")
                    {
                        txtToplam.Enabled = true;
                    }
                    else if (Convert.ToString(dr["toplam_borc"]) != "")
                    {
                        txtToplam.Enabled = false;
                    }
                    //kalan borc enabled durumu
                    if (Convert.ToString(dr["kalan_borc"]) == "")
                    {
                        txtKalanBorc.Enabled = true;
                    }
                    else if (Convert.ToString(dr["kalan_borc"]) != "")
                    {
                        txtKalanBorc.Enabled = false;
                    }

                    dr.Close();

                }
                else
                {

                    MessageBox.Show("Geçerli Bir Tc Giriniz!!");
                    dr.Close();

                }







            }
            catch (Exception x)
            {
                MessageBox.Show("Geçerli Bir Giriş Yapınız" + x);
            }













        }
        private void txtToplamBorc_TextChanged(object sender, EventArgs e)
        {

        }







        private void button1_Click(object sender, EventArgs e)
        {
            string arama;
            arama = txtTc.Text;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }


                komut = "UPDATE ucret SET odeme_tarihi=@odemeTarih,toplam_borc=@txtToplamBorc, kalan_borc=@kalanBorc, odeme_sekli= @odeme_sekli where tc_no='" + arama + "'";
                kmt = new MySqlCommand(komut, baglanti);
                kmt.Parameters.AddWithValue("@odemeTarih", dateSon.Text);
                kmt.Parameters.AddWithValue("@txtToplamBorc", txtToplam.Text);
                int kalan_borc = 0;

                kalan_borc = Convert.ToInt32(txtKalanBorc.Text) - Convert.ToInt32(txtOdemeTutari.Text);
                if (kalan_borc < 0)
                {
                    kalan_borc = 0;
                    kmt.Parameters.AddWithValue("@kalanBorc", kalan_borc);

                    MessageBox.Show("Ana Paradan Büyük Fiyat Girilemez\nAna Paranın Tamamı Ödeniyor.");


                }
                else if (Convert.ToInt32(txtOdemeTutari.Text) >= 0)
                {
                    if (Convert.ToInt32(txtOdemeTutari.Text) == Convert.ToInt32(txtKalanBorc.Text))
                    {
                        kalan_borc = 0;
                        kmt.Parameters.AddWithValue("@kalanBorc", kalan_borc);
                        MessageBox.Show("Borcun Tamamı Ödendi Teşekkür Ederiz..");
                    }
                    else
                    {
                        kmt.Parameters.AddWithValue("@kalanBorc", kalan_borc);
                        MessageBox.Show("Ödeme İşlemi Gerçekleşti.");
                    }


                }





                string odeme_sekli = "";
                if (nakit.Checked == true)
                {
                    odeme_sekli = "nakit";

                }
                else
                {
                    odeme_sekli = "kredi kartı";
                }
                kmt.Parameters.AddWithValue("@odeme_sekli", odeme_sekli);

                kmt.ExecuteNonQuery();

                string komut2 = ("UPDATE aday SET ucret_id=(select odeme_id from ucret where tc_no='" + txtTc.Text + "') where tc_no='" + arama + "'");
                kmt2 = new MySqlCommand(komut2, baglanti);
                kmt2.ExecuteNonQuery();




                MessageBox.Show("Ödeme İşlemi Gerçekleştirildi");
            }

            catch (Exception x)
            {
                MessageBox.Show("hata" + x);
            }
        }

        private void txtKalanBorc_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(txtKalanBorc.Text) == "0")
            {
                txtOdemeTutari.Enabled = false;
            }
            else
            {
                txtOdemeTutari.Enabled = true;
            }
        }

        private void tcKontrol_Click_1(object sender, EventArgs e)
        {

        }
    }
}
