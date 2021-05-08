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
    public partial class OdemeGuncellemeForm : Form
    {
        public string tc, sonOdeme,odemeSekli;
        public int tBorc, OncekiBorc, OdemeT=0;
        public static string ConnStr = ConfigurationManager.ConnectionStrings["MySQL"].ToString();
        public MySqlConnection baglanti = new MySqlConnection(ConnStr);
        string komut;
        MySqlCommand kmt = new MySqlCommand();
        int borc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            borc = Convert.ToInt32(txtToplamBorc.Text);
           
            if(tBorc<=borc)
            {
                oncekiBorc.Enabled = true;
                txtOdemeTutari.Enabled = true;
                if (tBorc==borc)
                {
                   
                    oncekiBorc.Text = OncekiBorc.ToString();
                }
                else
                {
                    OncekiBorc = (Convert.ToInt32(txtToplamBorc.Text) - tBorc);
                    oncekiBorc.Text = OncekiBorc.ToString();
                }
                
                
            }
            else
            {
                MessageBox.Show("Eski borçdan küçük bir borç girilemez.");
            }
            
            
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

        private void OdemeGuncellemeForm_Load(object sender, EventArgs e)
        {
            txtTc.Text = tc;
            odemeTarih.Text = sonOdeme;
            txtToplamBorc.Text = tBorc.ToString();
            oncekiBorc.Text = OncekiBorc.ToString();
            txtOdemeTutari.Text = OdemeT.ToString();
            
            if (odemeSekli == "nakit") 
                nakit.Checked=true;
            else if (odemeSekli == "kredi kartı")
                kKart.Checked = true;
        }

        public OdemeGuncellemeForm()
        {
            InitializeComponent();
        }
        public void guncelle()
        {

            try
            {
               
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }

                if (nakit.Checked)
                    odemeSekli = "nakit";
                else if (kKart.Checked)
                    odemeSekli = "kredi kart";
                
                    OdemeT = Convert.ToInt32(txtOdemeTutari.Text);

                    if (OdemeT <= OncekiBorc)
                    {
                        if (OdemeT < 0)
                        {
                            MessageBox.Show("Lütfen Geçerli Bir Ödeme Tutarı Giriniz.");
                        }
                        else
                        {
                            int kBorc = 0;
                            kBorc = OncekiBorc - OdemeT; 
                            komut = ("UPDATE ucret SET tc_no='" + txtTc.Text + "' ,odeme_tarihi='" + odemeTarih.Text + "',toplam_borc='" + txtToplamBorc.Text + "', kalan_borc=" + kBorc + " , odeme_sekli='" + odemeSekli + "' where tc_no='" + txtTc.Text + "'");
                            kmt = new MySqlCommand(komut, baglanti);
                            kmt.ExecuteNonQuery();
                            MessageBox.Show("Güncelleme işlemi başarılı.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Odeme tutarı kalan borcdan büyük olamaz.");
                    }
                
              


            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata);
            }

        }
       
    }
}

