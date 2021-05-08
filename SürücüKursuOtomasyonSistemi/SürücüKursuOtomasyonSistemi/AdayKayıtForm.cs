using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SurucuKursuOtomasyonSistemi.Formlar
{
    public partial class AdayKayıtForm : Form
    {
        public AdayKayıtForm()
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
            label11.ForeColor = Renkler.PrimaryColor;

            }
        private void AdayKayıtForm_Load(object sender, EventArgs e)
            
        {
                TemaYükle();
        }
        
          

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
