﻿namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(195, 138);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(192, 36);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(195, 222);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(192, 36);
            this.txtSifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(195, 96);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(192, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(195, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(192, 36);
            this.txtAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon:";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(195, 180);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(192, 36);
            this.mskTelefon.TabIndex = 4;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(195, 264);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(192, 36);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cinsiyet:";
            // 
            // btnKayitYap
            // 
            this.btnKayitYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKayitYap.Location = new System.Drawing.Point(195, 324);
            this.btnKayitYap.Name = "btnKayitYap";
            this.btnKayitYap.Size = new System.Drawing.Size(192, 42);
            this.btnKayitYap.TabIndex = 17;
            this.btnKayitYap.Text = "Kayıt Yap";
            this.btnKayitYap.UseVisualStyleBackColor = false;
            this.btnKayitYap.Click += new System.EventHandler(this.btnKayitYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(457, 416);
            this.Controls.Add(this.btnKayitYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.txtSifre);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayitYap;
    }
}