namespace Karar_Yapilari_Egzersiz_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAdedi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIndirimOrani = new System.Windows.Forms.Label();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.lblIndirimsizToplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satın Aldığınız Kitap Sayısı:";
            // 
            // txtKitapAdedi
            // 
            this.txtKitapAdedi.Location = new System.Drawing.Point(207, 46);
            this.txtKitapAdedi.Name = "txtKitapAdedi";
            this.txtKitapAdedi.Size = new System.Drawing.Size(100, 22);
            this.txtKitapAdedi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ücret Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIndirimOrani
            // 
            this.lblIndirimOrani.AutoSize = true;
            this.lblIndirimOrani.Location = new System.Drawing.Point(34, 170);
            this.lblIndirimOrani.Name = "lblIndirimOrani";
            this.lblIndirimOrani.Size = new System.Drawing.Size(0, 16);
            this.lblIndirimOrani.TabIndex = 3;
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Location = new System.Drawing.Point(34, 199);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(0, 16);
            this.lblOdenecekTutar.TabIndex = 4;
            // 
            // lblIndirimsizToplam
            // 
            this.lblIndirimsizToplam.AutoSize = true;
            this.lblIndirimsizToplam.Location = new System.Drawing.Point(34, 141);
            this.lblIndirimsizToplam.Name = "lblIndirimsizToplam";
            this.lblIndirimsizToplam.Size = new System.Drawing.Size(0, 16);
            this.lblIndirimsizToplam.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 331);
            this.Controls.Add(this.lblIndirimsizToplam);
            this.Controls.Add(this.lblOdenecekTutar);
            this.Controls.Add(this.lblIndirimOrani);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKitapAdedi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAdedi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIndirimOrani;
        private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Label lblIndirimsizToplam;
    }
}

