namespace OkulApp
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtNO = new System.Windows.Forms.TextBox();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(89, 70);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(89, 108);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(89, 147);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(44, 13);
            this.lblNumara.TabIndex = 2;
            this.lblNumara.Text = "Numara";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(60, 193);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(73, 13);
            this.lblSinif.TabIndex = 3;
            this.lblSinif.Text = "Sınıf Seçiniz : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(139, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(139, 105);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(139, 144);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(148, 230);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "  Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(257, 303);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 9;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(75, 308);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(52, 13);
            this.lblNo.TabIndex = 10;
            this.lblNo.Text = "No Giriniz";
            // 
            // txtNO
            // 
            this.txtNO.Location = new System.Drawing.Point(139, 305);
            this.txtNO.Name = "txtNO";
            this.txtNO.Size = new System.Drawing.Size(100, 20);
            this.txtNO.TabIndex = 11;
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(139, 190);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(100, 21);
            this.cmbSinif.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.txtNO);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSinif);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNO;
        private System.Windows.Forms.ComboBox cmbSinif;
    }
}

