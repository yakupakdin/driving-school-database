using MySql.Data.MySqlClient;
using SürücüKursuOtomasyonSistemi.Formlar;
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
    public partial class ArşivFormu : Form
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
        MySqlCommand kmt5 = new MySqlCommand();
        MySqlCommand bosaltici = new MySqlCommand();

        MySqlDataAdapter da = new MySqlDataAdapter();
        string formAdi = "";

        public ArşivFormu()
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

        private void ArşivFormu_Load(object sender, EventArgs e)
        {
            TemaYükle();
            if (baglanti.State == ConnectionState.Closed)
            { baglanti_check(); }
            kmt.Connection = baglanti;

        }

        private void btnKursiyerList_Click(object sender, EventArgs e)
        {
            formAdi = "kursiyer";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from aday";

            DataTable tablo = new DataTable();
            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnPersonelList_Click(object sender, EventArgs e)
        {
            formAdi = "personel";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from personel";
            DataTable tablo = new DataTable();

            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void btnAraçList_Click(object sender, EventArgs e)
        {
            formAdi = "arac";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from arac";
            DataTable tablo = new DataTable();

            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnSubeList_Click(object sender, EventArgs e)
        {
            formAdi = "sube";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from sube";
            DataTable tablo = new DataTable();
            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnOdemeList_Click(object sender, EventArgs e)
        {
            formAdi = "odeme";
            DataTable tablo = new DataTable();
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from ucret";
            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        public void DataGridViewAyar(DataGridView da)
        {
            da.RowHeadersVisible = false;
            da.BorderStyle = BorderStyle.None;
            da.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 65);
            da.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            da.DefaultCellStyle.SelectionBackColor = Color.White;
            da.DefaultCellStyle.SelectionForeColor = Color.Black;
            da.EnableHeadersVisualStyles = false;
            da.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            da.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 65);
            da.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            da.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            switch (formAdi)
            {
                case "kursiyer":
                    KursiyerGuncellemeFormu f = new KursiyerGuncellemeFormu();
               
                    f.tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    f.ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    f.soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    f.ogrenimDurumu = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    f.saglikRapor = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    f.adliBelge = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    f.ehliyetTuru = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    if (dataGridView1.CurrentRow.Cells[9].Value.ToString()!="")
                    {
                        f.perId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value.ToString());
                    }
                    

                    if (dataGridView1.CurrentRow.Cells[10].Value.ToString()!="")
                    {
                        f.aracId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[10].Value.ToString());
                    }
                    

                    if (dataGridView1.CurrentRow.Cells[11].Value.ToString()!="")
                    {
                        f.subeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value.ToString());
                    }
                    


                    if (dataGridView1.CurrentRow.Cells[12].Value.ToString()!="")
                    {
                        f.sınavId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value.ToString());
                    }

                    f.Show();

                    break;
                case "personel":
                    PersonelGuncelleme f4 = new PersonelGuncelleme();
                    f4.personel_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    f4.tc_no = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    f4.ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    f4.soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    f4.gorev= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    f4.Show();


                    break;
                case "sube":
                    SubeGuncellemeFormu f3 = new SubeGuncellemeFormu();
                    f3.subeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    f3.ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    f3.telNo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    f3.adres = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    f3.Show();
                    break;
                case "arac":
                    AracGuncellemeFormu f1 = new AracGuncellemeFormu();
                    f1.plaka = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    f1.arac_tipi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    f1.arac_marka = dataGridView1.CurrentRow.Cells[3].Value.ToString(); ;
                    f1.arac_model = dataGridView1.CurrentRow.Cells[4].Value.ToString(); ;
                    f1.vitesTuru = dataGridView1.CurrentRow.Cells[5].Value.ToString(); ;
                    f1.subeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    f1.Show();
                    break;
                case "odeme":
                    OdemeGuncellemeForm f2 = new OdemeGuncellemeForm();
                    f2.tc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    f2.sonOdeme = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    f2.tBorc = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    f2.OncekiBorc = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    f2.odemeSekli = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    f2.Show();
                    break;
                case "sinavlar":
                    MessageBox.Show("Notlarda güncelleme yapmak için lütfen NOT GİRİŞİ'ni kullanın.");
                    break;
                case "nufus":
                   NufusGuncellemeFormu f5 = new NufusGuncellemeFormu();
                    
                    f5.tc_no = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    f5.seri_no = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    f5.ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    f5.soyad = dataGridView1.CurrentRow.Cells[3].Value.ToString();  
                    f5.baba_adi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    f5.anne_adi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    f5.dogum_yeri = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    f5.dogum_tarihi = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    f5.tel_no = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    f5.cinsiyet = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    f5.medeni_hal = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    f5.kan_grubu = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    f5.Show();


                    break;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int numara = 0;

            switch (formAdi)
            { 
                case "kursiyer":
                     numara = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    aday_silici(numara);
                    break;
                case "personel":
                     numara = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    personel_silici(numara);
                    break;
                case "sube":
                     numara = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    sube_silici(numara);
                    break;
                case "arac":
                     numara = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    arac_silici(numara);
                    break;
                case "odeme":
                    MessageBox.Show("Toplam borcu sıfırlamak için lütfen güncelleme bölümünden tüm ücreti ödeyiniz.");
                    break;
                case "sinavlar":
                    MessageBox.Show("Notlarda silme işlemi yapabilmek için kursiyeri silmeniz gerekmektedir.");
                    break;
                case "nufus":
                    
                    string tc = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                    nufus_silici(tc);
                    break;
            }
                    


        }

        public void nufus_silici(string x)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                { baglanti_check(); }          
               

                
                

                string komut = "DELETE FROM nufus WHERE tc_no=@numara";
                    kmt = new MySqlCommand(komut, baglanti);
                    kmt.Parameters.AddWithValue("@numara", x);
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Sistemden Silinmiştir.");

                formAdi = "nufus";
                DataGridViewAyar(dataGridView1);
                string sqlsorgusu = "Select * from nufus";

                DataTable tablo = new DataTable();
                kmt.CommandText = sqlsorgusu;
                da.SelectCommand = kmt;
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;


            }
            catch (Exception )
            {
                MessageBox.Show("Nüfustan Silebilmek İçin İlgili Tc'yi Kayıtlı Olduğu Bölümden Siliniz");

                
            }
           



        }


        public void arac_silici(int x)
        {
            string komut = "";

            komut = ("UPDATE aday SET arac_id=NULL where arac_id='" + x + "'");
            kmt2 = new MySqlCommand(komut, baglanti);
            kmt2.ExecuteNonQuery();


            komut = ("UPDATE personel SET arac_id=NULL where arac_id='" + x + "'");
            kmt3 = new MySqlCommand(komut, baglanti);
            kmt3.ExecuteNonQuery();




            komut = "DELETE FROM arac WHERE arac_id=@numara";
            kmt = new MySqlCommand(komut, baglanti);
            kmt.Parameters.AddWithValue("@numara", x);
            kmt.ExecuteNonQuery();

            MessageBox.Show("Araç Kayıtlardan Silindi");
            formAdi = "arac";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from arac";
            DataTable tablo = new DataTable();

            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;


        }
        public void aday_silici(int x)


        {
            MySqlDataReader dr;
            if (baglanti.State == ConnectionState.Closed)
            { baglanti_check(); }

            kmt.Connection = baglanti;
            kmt.CommandText = "SELECT * FROM aday where aday_id="+x;
            string ucret_silen="",sinav_silen="" /*sube_silen = "",arac_silen="",personel_silen=""*/;
            
            dr = kmt.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ucret_silen = Convert.ToString(dr["ucret_id"]);
                    sinav_silen = Convert.ToString(dr["sinav_id"]);

                    //sube_silen = Convert.ToString(dr["sube_id"]);
                    //arac_silen = Convert.ToString(dr["arac_id"]);
                    //personel_silen = Convert.ToString(dr["personel_id"]);


                }
                dr.Close();
            }
            

            string update = "UPDATE aday SET personel_id=NULL,arac_id=NULL,sube_id=NULL,sinav_id=NULL,ucret_id=NULL";
            bosaltici = new MySqlCommand(update, baglanti);
            bosaltici.ExecuteNonQuery();


            string komut2 = "DELETE FROM sinavlar WHERE not_id="+sinav_silen;//sinavlardaki tcyi silen
            kmt4 = new MySqlCommand(komut2, baglanti);     
            kmt4.ExecuteNonQuery();

            string komut3 = "DELETE FROM ucret WHERE odeme_id=" + ucret_silen;//sinavlardaki tcyi silen
            kmt5 = new MySqlCommand(komut3, baglanti);
            kmt5.ExecuteNonQuery();


            string komut = "";
            komut = "DELETE FROM aday WHERE aday_id=@numara";//aday silen
            kmt = new MySqlCommand(komut, baglanti);
            kmt.Parameters.AddWithValue("@numara", x);
            kmt.ExecuteNonQuery();








            MessageBox.Show("Kursiyer Kayıtlardan Silindi");

            formAdi = "kursiyer";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from aday";

            DataTable tablo = new DataTable();
            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;


        }
        public void personel_silici(int x)
        {
            string komut = "";

            komut = ("UPDATE aday SET personel_id=NULL where personel_id='" + x + "'");
            kmt3 = new MySqlCommand(komut, baglanti);
            kmt3.ExecuteNonQuery();

            komut = "DELETE FROM personel WHERE personel_id=@numara";
            kmt = new MySqlCommand(komut, baglanti);
            kmt.Parameters.AddWithValue("@numara", x);
            kmt.ExecuteNonQuery();


            MessageBox.Show("Personel Kayıtlardan Silindi");

            formAdi = "personel";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from personel";

            DataTable tablo = new DataTable();
            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
        public void sube_silici(int x)
        {
            string komut = "";

            komut = ("UPDATE aday SET sube_id=NULL where sube_id='" + x + "'");
            kmt3 = new MySqlCommand(komut, baglanti);
            kmt3.ExecuteNonQuery();
            komut = ("UPDATE personel SET sube_id=NULL where sube_id='" + x + "'");
            kmt3 = new MySqlCommand(komut, baglanti);
            kmt3.ExecuteNonQuery();
             komut = ("UPDATE arac SET sube_id=NULL where sube_id='" + x + "'");
            kmt3 = new MySqlCommand(komut, baglanti);
            kmt3.ExecuteNonQuery();


            komut = "DELETE FROM sube WHERE sube_id=@numara";
            kmt = new MySqlCommand(komut, baglanti);
            kmt.Parameters.AddWithValue("@numara", x);
            kmt.ExecuteNonQuery();


            MessageBox.Show("Şube Kayıtlardan Silindi");

            formAdi = "sube";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from sube";

            DataTable tablo = new DataTable();
            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAdi = "sinavlar";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from sinavlar";

            DataTable tablo = new DataTable();
            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formAdi = "nufus";
            DataGridViewAyar(dataGridView1);
            string sqlsorgusu = "Select * from nufus";

            DataTable tablo = new DataTable();
            kmt.CommandText = sqlsorgusu;
            da.SelectCommand = kmt;
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
