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
    public partial class btnKaydet : Form
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
        string komut;


        public btnKaydet()
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

        private void NotGirişiForm_Load(object sender, EventArgs e)
        {
            TemaYükle();
        }

        private void notAra_Click(object sender, EventArgs e)
        {
            try
            {
                string arama;
                arama = txtTc.Text;
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }

                kmt.CommandText = "SELECT * FROM sinavlar where tc_no=" + arama;
                kmt.Connection = baglanti;
                dr = kmt.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        yaziliText.Text = Convert.ToString(dr["yazili_tarihi"]);
                        drksText.Text = Convert.ToString(dr["drks_tarihi"]);
                        if(dr["yazili_not"]!=null  ) { txtYnot.Text = Convert.ToString(dr["yazili_not"]); }
                        if (dr["drks_durum"] != null ) { drksDurum.Text = Convert.ToString(dr["drks_durum"]); }


                       

                    }
                    notAra.Enabled = false;
                    yaziliText.Enabled = false;
                    drksText.Enabled = false;
                    txtTc.Enabled = false;
                   


                    



                    dr.Close();
                }
               



                else
                {

                    MessageBox.Show("Geçerli Bir Tc Giriniz!!");
                    dr.Close();

                }

            }
            catch
            {
                MessageBox.Show("Geçerli Bir Giriş Yapınız");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string arama;
                arama = txtTc.Text;
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }
                komut = ("UPDATE sinavlar SET yazili_not='" + txtYnot.Text + "',drks_durum='" + drksDurum.Text + "' where tc_no='" + arama + "'");
                kmt = new MySqlCommand(komut, baglanti);
                kmt.ExecuteNonQuery();

                

                MessageBox.Show("Sınav Notu Güncelleme İşlemi Gerçekleşti.");
            }
            catch (Exception x)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + x);
            }
        }
    }
}
