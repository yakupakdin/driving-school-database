
namespace SürücüKursuOtomasyonSistemi.Formlar
{
    partial class KursiyerGuncellemeFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subeListe = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drksListe = new System.Windows.Forms.ComboBox();
            this.yaziliListe = new System.Windows.Forms.ComboBox();
            this.tcText = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.aracListe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.personelListe = new System.Windows.Forms.ComboBox();
            this.ogrenim = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEhliyetSinifi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdayKayit = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subeListe
            // 
            this.subeListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subeListe.FormattingEnabled = true;
            this.subeListe.Location = new System.Drawing.Point(218, 310);
            this.subeListe.Name = "subeListe";
            this.subeListe.Size = new System.Drawing.Size(127, 21);
            this.subeListe.TabIndex = 101;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(70, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Yok";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.drksListe);
            this.groupBox3.Controls.Add(this.yaziliListe);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(378, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 80);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Tarihleri";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Direksiyon Tarihi:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Yazılı Sınav Tarihi:";
            // 
            // drksListe
            // 
            this.drksListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drksListe.FormattingEnabled = true;
            this.drksListe.Items.AddRange(new object[] {
            "20.06.2021 PAZAR",
            "30.06.2021 ÇARŞAMBA",
            "10.07.2021 CUMARTESİ",
            "20.07.2021 SALI ",
            "30.07.2021 CUMA",
            "10.08.2021 SALI",
            "20.08.2021 CUMA",
            "30.08.2021 PAZARTESİ",
            "10.09.2021 CUMA",
            "20.09.2021 PAZARTESİ"});
            this.drksListe.Location = new System.Drawing.Point(119, 45);
            this.drksListe.Name = "drksListe";
            this.drksListe.Size = new System.Drawing.Size(132, 21);
            this.drksListe.TabIndex = 75;
            // 
            // yaziliListe
            // 
            this.yaziliListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yaziliListe.FormattingEnabled = true;
            this.yaziliListe.Items.AddRange(new object[] {
            "30.05.2021 PAZAR",
            "10.06.2021 PERŞEMBE",
            "20.06.2021 PAZAR",
            "30.06.2021 ÇARŞAMBA",
            "10.07.2021 CUMARTESİ",
            "20.07.2021 SALI ",
            "30.07.2021 CUMA",
            "10.08.2021 SALI",
            "20.08.2021 CUMA",
            "30.08.2021 PAZARTESİ"});
            this.yaziliListe.Location = new System.Drawing.Point(119, 18);
            this.yaziliListe.Name = "yaziliListe";
            this.yaziliListe.Size = new System.Drawing.Size(132, 21);
            this.yaziliListe.TabIndex = 74;
            // 
            // tcText
            // 
            this.tcText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcText.Location = new System.Drawing.Point(218, 101);
            this.tcText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcText.MaxLength = 11;
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(127, 20);
            this.tcText.TabIndex = 104;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton4.Location = new System.Drawing.Point(6, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(41, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Var";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(96, 310);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Şube Adı:";
            // 
            // aracListe
            // 
            this.aracListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aracListe.FormattingEnabled = true;
            this.aracListe.Location = new System.Drawing.Point(218, 279);
            this.aracListe.Name = "aracListe";
            this.aracListe.Size = new System.Drawing.Size(127, 21);
            this.aracListe.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(95, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "Arac Plaka";
            // 
            // personelListe
            // 
            this.personelListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.personelListe.FormattingEnabled = true;
            this.personelListe.Location = new System.Drawing.Point(218, 243);
            this.personelListe.Name = "personelListe";
            this.personelListe.Size = new System.Drawing.Size(127, 21);
            this.personelListe.TabIndex = 97;
            // 
            // ogrenim
            // 
            this.ogrenim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ogrenim.FormattingEnabled = true;
            this.ogrenim.Items.AddRange(new object[] {
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Önlisans",
            "Lisans"});
            this.ogrenim.Location = new System.Drawing.Point(218, 209);
            this.ogrenim.Name = "ogrenim";
            this.ogrenim.Size = new System.Drawing.Size(127, 21);
            this.ogrenim.TabIndex = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(380, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 58);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adli Sicil Belgesi:";
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(81, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yok";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Var";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(506, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 58);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sağlık Raporu:";
            // 
            // cmbEhliyetSinifi
            // 
            this.cmbEhliyetSinifi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEhliyetSinifi.FormattingEnabled = true;
            this.cmbEhliyetSinifi.Items.AddRange(new object[] {
            "M",
            "A1",
            "A2",
            "A",
            "B1",
            "B",
            "BE",
            "C1",
            "C1E",
            "C",
            "CE",
            "D1",
            "D1E",
            "D",
            "DE",
            "F",
            "G"});
            this.cmbEhliyetSinifi.Location = new System.Drawing.Point(464, 330);
            this.cmbEhliyetSinifi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEhliyetSinifi.Name = "cmbEhliyetSinifi";
            this.cmbEhliyetSinifi.Size = new System.Drawing.Size(172, 21);
            this.cmbEhliyetSinifi.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(376, 332);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 93;
            this.label13.Text = "Ehliyet Sınıfı : ";
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtKayitTarihi.Location = new System.Drawing.Point(464, 290);
            this.dtKayitTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(172, 20);
            this.dtKayitTarihi.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(376, 293);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 91;
            this.label10.Text = "Kayıt Tarihi : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(96, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Öğretmen Adı:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(96, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Öğrenim Durumu : ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoyad.Location = new System.Drawing.Point(218, 171);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(127, 20);
            this.txtSoyad.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(95, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Soyadınız :";
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAd.Location = new System.Drawing.Point(218, 137);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(127, 20);
            this.txtAd.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(95, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Adınız : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(95, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "TC Kimlik :";
            // 
            // btnAdayKayit
            // 
            this.btnAdayKayit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdayKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdayKayit.FlatAppearance.BorderSize = 0;
            this.btnAdayKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdayKayit.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btnAdayKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdayKayit.Location = new System.Drawing.Point(84, 374);
            this.btnAdayKayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdayKayit.Name = "btnAdayKayit";
            this.btnAdayKayit.Size = new System.Drawing.Size(546, 32);
            this.btnAdayKayit.TabIndex = 81;
            this.btnAdayKayit.Text = "GÜNCELLE";
            this.btnAdayKayit.UseVisualStyleBackColor = true;
            this.btnAdayKayit.Click += new System.EventHandler(this.btnAdayKayit_Click);
            // 
            // KursiyerGuncellemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.subeListe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tcText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aracListe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.personelListe);
            this.Controls.Add(this.ogrenim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbEhliyetSinifi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtKayitTarihi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdayKayit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KursiyerGuncellemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KursiyerGuncellemeFormu";
            this.Load += new System.EventHandler(this.KursiyerGuncellemeFormu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subeListe;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drksListe;
        private System.Windows.Forms.ComboBox yaziliListe;
        private System.Windows.Forms.TextBox tcText;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox aracListe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox personelListe;
        private System.Windows.Forms.ComboBox ogrenim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEhliyetSinifi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtKayitTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdayKayit;
    }
}