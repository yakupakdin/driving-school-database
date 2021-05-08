using SurucuKursuOtomasyonSistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SürücüKursuOtomasyonSistemi
{
    public partial class Form2 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form2()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Color SelectThemeColor()
        {//renk seçiminin olduğu metot
            int index = random.Next(Renkler.ColorList.Count);//rastgele sayı üretiliyor
            while (tempIndex == index)
            {
                index = random.Next(Renkler.ColorList.Count);
            }
            tempIndex = index;
            string color = Renkler.ColorList[index];//rastgele seçilen sayıya göre renk seçiliyor
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {//rastgele seçilen rengin uygulandığı metot
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    pnlTitle.BackColor = color;
                    Renkler.PrimaryColor = color;
                    Renkler.SecondaryColor = Renkler.ChangeColorBrightness(color, -0.3);

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {//pencere açma metodu
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlAnasayfa.Controls.Add(childForm);
            this.pnlAnasayfa.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnAdayKayit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SurucuKursuOtomasyonSistemi.Formlar.KisiselBilgilerFormu(), sender);
            
        }
        private void btnKisiselBilgi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SurucuKursuOtomasyonSistemi.Formlar.AdayKayıtForm(), sender);


        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SurucuKursuOtomasyonSistemi.Formlar.btnOdemeYap(), sender);
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SurucuKursuOtomasyonSistemi.Formlar.btnKaydet(), sender);
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SurucuKursuOtomasyonSistemi.Formlar.PersonelKayitForm(), sender);
        }


        private void label1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }


        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "ANASAYFA";
            pnlTitle.BackColor = Color.FromArgb(0, 150, 136);
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;

        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlAnasayfa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tam Ekran Modu Kapalıdır");
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SurucuKursuOtomasyonSistemi.Formlar.AraçKaydetForm(), sender);
        }

        private void btnSubeKayit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SurucuKursuOtomasyonSistemi.Formlar.SubeKaydetForm(), sender);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SurucuKursuOtomasyonSistemi.Formlar.ArşivFormu(), sender);
        }
        dtbs _vt = new dtbs();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (_vt.baglanti_check() == "true") 
            {
                label2.Text = "Veritabanına Bağlı..";
            }
            else 
            {
                label2.Text = "Veritabanına Bağlı Değil!!!..";
                MessageBox.Show(_vt.baglanti_check());
            }
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAnasayfa_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnKisiselBilgi_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}


