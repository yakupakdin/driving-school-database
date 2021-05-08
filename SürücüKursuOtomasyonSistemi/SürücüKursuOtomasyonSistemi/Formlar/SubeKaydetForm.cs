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
    public partial class SubeKaydetForm : Form
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
        public SubeKaydetForm()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubeKaydetForm_Load(object sender, EventArgs e)
        {
            TemaYükle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                string arama;
                arama = txtSubeNumarasi.Text;
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }

                kmt.CommandText = "SELECT * FROM sube where sube_id=" + arama;
                kmt.Connection = baglanti;
                dr = kmt.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        if ((dr["ad"] != null)) { txtSubeAdi.Text = Convert.ToString(dr["ad"]); txtSubeAdi.Enabled = false; }
                        if ((dr["tel_no"] != null)) { txtTelefon.Text = Convert.ToString(dr["tel_no"]); txtTelefon.Enabled = false; }
                        if ((dr["adres"] != null)) { txtAdres.Text = Convert.ToString(dr["adres"]); txtAdres.Enabled = false; btnKaydet.Enabled = false; }
                    }


                    dr.Close();
                }




                else
                {
                    MessageBox.Show("Şube Yok Kayıt İçin Devam Ediniz..");
                    
                    txtSubeAdi.Enabled = true;
                    txtTelefon.Enabled = true;
                    txtAdres.Enabled = true;
                    btnKaydet.Enabled = true;
                    txtSubeAdi.Text = "";
                    txtTelefon.Text = "";
                    txtAdres.Text = "";




                }

            }
            catch
            {
                MessageBox.Show("Geçerli Bir Giriş Yapınız");
            }dr.Close();
        }
            
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }


                komut = "insert into sube(sube_id,ad,tel_no,adres) " +
                "values (@id,@ad,@tel_no,@adres)";
                kmt = new MySqlCommand(komut, baglanti);
                kmt.Parameters.AddWithValue("@id",txtSubeNumarasi.Text);
                kmt.Parameters.AddWithValue("@ad",txtSubeAdi.Text);
                kmt.Parameters.AddWithValue("@tel_no",txtTelefon.Text);
                kmt.Parameters.AddWithValue("@adres",txtAdres.Text);
                kmt.ExecuteNonQuery();
                
                    MessageBox.Show("Kayıt Gerçekleştirildi");

                
                

            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            





        }
    }
}

