
namespace SurucuKursuOtomasyonSistemi.Formlar
{
    partial class btnOdemeYap
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
            this.dateSon = new System.Windows.Forms.DateTimePicker();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.kKart = new System.Windows.Forms.RadioButton();
            this.nakit = new System.Windows.Forms.RadioButton();
            this.tcKontrol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdemeTutari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateSon
            // 
            this.dateSon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateSon.Location = new System.Drawing.Point(216, 126);
            this.dateSon.Name = "dateSon";
            this.dateSon.Size = new System.Drawing.Size(171, 20);
            this.dateSon.TabIndex = 95;
            // 
            // txtTc
            // 
            this.txtTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTc.Location = new System.Drawing.Point(216, 77);
            this.txtTc.MaxLength = 11;
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(171, 20);
            this.txtTc.TabIndex = 94;
            this.txtTc.TabStop = false;
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAd.Location = new System.Drawing.Point(216, 103);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.MaxLength = 11;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(171, 20);
            this.txtAd.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Ad Soyad";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Kalan Borç:";
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKalanBorc.Location = new System.Drawing.Point(216, 179);
            this.txtKalanBorc.Margin = new System.Windows.Forms.Padding(2);
            this.txtKalanBorc.MaxLength = 5;
            this.txtKalanBorc.Multiline = true;
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.Size = new System.Drawing.Size(171, 20);
            this.txtKalanBorc.TabIndex = 90;
            // 
            // kKart
            // 
            this.kKart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kKart.AutoSize = true;
            this.kKart.Location = new System.Drawing.Point(315, 244);
            this.kKart.Name = "kKart";
            this.kKart.Size = new System.Drawing.Size(73, 17);
            this.kKart.TabIndex = 89;
            this.kKart.TabStop = true;
            this.kKart.Text = "Kredi Kartı";
            this.kKart.UseVisualStyleBackColor = true;
            // 
            // nakit
            // 
            this.nakit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nakit.AutoSize = true;
            this.nakit.Location = new System.Drawing.Point(220, 244);
            this.nakit.Name = "nakit";
            this.nakit.Size = new System.Drawing.Size(50, 17);
            this.nakit.TabIndex = 88;
            this.nakit.TabStop = true;
            this.nakit.Text = "Nakit";
            this.nakit.UseVisualStyleBackColor = true;
            // 
            // tcKontrol
            // 
            this.tcKontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcKontrol.FlatAppearance.BorderSize = 0;
            this.tcKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcKontrol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tcKontrol.Location = new System.Drawing.Point(410, 85);
            this.tcKontrol.Margin = new System.Windows.Forms.Padding(2);
            this.tcKontrol.Name = "tcKontrol";
            this.tcKontrol.Size = new System.Drawing.Size(118, 20);
            this.tcKontrol.TabIndex = 87;
            this.tcKontrol.Text = "Tc Kontrol";
            this.tcKontrol.UseVisualStyleBackColor = true;
            this.tcKontrol.Click += new System.EventHandler(this.tcKontrol_Click);
            // S
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(105, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(423, 32);
            this.button1.TabIndex = 86;
            this.button1.Text = "ÖDEME YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Ödeme Şekli : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Ödeme Tutarı :";
            // 
            // txtOdemeTutari
            // 
            this.txtOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOdemeTutari.Location = new System.Drawing.Point(216, 210);
            this.txtOdemeTutari.Margin = new System.Windows.Forms.Padding(2);
            this.txtOdemeTutari.MaxLength = 5;
            this.txtOdemeTutari.Name = "txtOdemeTutari";
            this.txtOdemeTutari.Size = new System.Drawing.Size(171, 20);
            this.txtOdemeTutari.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Ana Fiyat:";
            // 
            // txtToplam
            // 
            this.txtToplam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtToplam.Location = new System.Drawing.Point(216, 151);
            this.txtToplam.Margin = new System.Windows.Forms.Padding(2);
            this.txtToplam.MaxLength = 5;
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(171, 20);
            this.txtToplam.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Son Ödeme Tarihi : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Tc Kimlik : ";
            // 
            // btnOdemeYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(631, 399);
            this.Controls.Add(this.dateSon);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKalanBorc);
            this.Controls.Add(this.kKart);
            this.Controls.Add(this.nakit);
            this.Controls.Add(this.tcKontrol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOdemeTutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "btnOdemeYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Ekranı";
            this.Load += new System.EventHandler(this.OdemeFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateSon;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.RadioButton kKart;
        private System.Windows.Forms.RadioButton nakit;
        private System.Windows.Forms.Button tcKontrol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdemeTutari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}