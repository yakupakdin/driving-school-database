
namespace SürücüKursuOtomasyonSistemi.Formlar
{
    partial class OdemeGuncellemeForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.oncekiBorc = new System.Windows.Forms.TextBox();
            this.kKart = new System.Windows.Forms.RadioButton();
            this.nakit = new System.Windows.Forms.RadioButton();
            this.odemeTarih = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdemeTutari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamBorc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Önceki Ödemeden Kalan Borç";
            // 
            // oncekiBorc
            // 
            this.oncekiBorc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oncekiBorc.Enabled = false;
            this.oncekiBorc.Location = new System.Drawing.Point(297, 138);
            this.oncekiBorc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oncekiBorc.Multiline = true;
            this.oncekiBorc.Name = "oncekiBorc";
            this.oncekiBorc.Size = new System.Drawing.Size(171, 20);
            this.oncekiBorc.TabIndex = 34;
            // 
            // kKart
            // 
            this.kKart.AutoSize = true;
            this.kKart.Location = new System.Drawing.Point(394, 229);
            this.kKart.Name = "kKart";
            this.kKart.Size = new System.Drawing.Size(73, 17);
            this.kKart.TabIndex = 33;
            this.kKart.TabStop = true;
            this.kKart.Text = "Kredi Kartı";
            this.kKart.UseVisualStyleBackColor = true;
            // 
            // nakit
            // 
            this.nakit.AutoSize = true;
            this.nakit.Location = new System.Drawing.Point(297, 229);
            this.nakit.Name = "nakit";
            this.nakit.Size = new System.Drawing.Size(50, 17);
            this.nakit.TabIndex = 32;
            this.nakit.TabStop = true;
            this.nakit.Text = "Nakit";
            this.nakit.UseVisualStyleBackColor = true;
            // 
            // odemeTarih
            // 
            this.odemeTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odemeTarih.Location = new System.Drawing.Point(297, 86);
            this.odemeTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.odemeTarih.Name = "odemeTarih";
            this.odemeTarih.Size = new System.Drawing.Size(171, 20);
            this.odemeTarih.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(136, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ödeme Şekli : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ödeme Tutarı :";
            // 
            // txtOdemeTutari
            // 
            this.txtOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOdemeTutari.Enabled = false;
            this.txtOdemeTutari.Location = new System.Drawing.Point(297, 174);
            this.txtOdemeTutari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOdemeTutari.MaxLength = 5;
            this.txtOdemeTutari.Name = "txtOdemeTutari";
            this.txtOdemeTutari.Size = new System.Drawing.Size(171, 20);
            this.txtOdemeTutari.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Toplam Borç : ";
            // 
            // txtToplamBorc
            // 
            this.txtToplamBorc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtToplamBorc.Location = new System.Drawing.Point(297, 110);
            this.txtToplamBorc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.Size = new System.Drawing.Size(171, 20);
            this.txtToplamBorc.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Son Ödeme Tarihi : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tc Kimlik : ";
            // 
            // txtTc
            // 
            this.txtTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTc.Location = new System.Drawing.Point(297, 63);
            this.txtTc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(171, 20);
            this.txtTc.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(472, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 39);
            this.button2.TabIndex = 36;
            this.button2.Text = "Toplam Borç Guncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OdemeGuncellemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oncekiBorc);
            this.Controls.Add(this.kKart);
            this.Controls.Add(this.nakit);
            this.Controls.Add(this.odemeTarih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOdemeTutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToplamBorc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTc);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OdemeGuncellemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuncellemeForm";
            this.Load += new System.EventHandler(this.OdemeGuncellemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oncekiBorc;
        private System.Windows.Forms.RadioButton kKart;
        private System.Windows.Forms.RadioButton nakit;
        private System.Windows.Forms.TextBox odemeTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdemeTutari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamBorc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button button2;
    }
}