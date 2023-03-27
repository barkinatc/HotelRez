namespace Project.WinUI
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
			this.dtGiris = new System.Windows.Forms.DateTimePicker();
			this.dtCikis = new System.Windows.Forms.DateTimePicker();
			this.btnReservation = new System.Windows.Forms.Button();
			this.lstRezervasyon = new System.Windows.Forms.ListBox();
			this.cmbYemek = new System.Windows.Forms.ComboBox();
			this.btnYemekSec = new System.Windows.Forms.Button();
			this.btnSiparis = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnRezAktif = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRezPasif = new System.Windows.Forms.Button();
			this.btnRezHepsi = new System.Windows.Forms.Button();
			this.btnRezFiyat = new System.Windows.Forms.Button();
			this.btnRezOdaEkle = new System.Windows.Forms.Button();
			this.btnOdaBosalt = new System.Windows.Forms.Button();
			this.btnMusteriSec = new System.Windows.Forms.Button();
			this.lstMusteri = new System.Windows.Forms.ListBox();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.lstOda = new System.Windows.Forms.ListBox();
			this.txtMisafirIsim = new System.Windows.Forms.TextBox();
			this.txtMisafirSoyIsim = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnMisafir = new System.Windows.Forms.Button();
			this.lstMisafir = new System.Windows.Forms.ListBox();
			this.btnRezGuestEkle = new System.Windows.Forms.Button();
			this.lblSonuc = new System.Windows.Forms.Label();
			this.btnMisafirCıkar = new System.Windows.Forms.Button();
			this.btnMusteriAktif = new System.Windows.Forms.Button();
			this.btnPasif = new System.Windows.Forms.Button();
			this.btnOdaTemizle = new System.Windows.Forms.Button();
			this.btnKalanlar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtGiris
			// 
			this.dtGiris.Location = new System.Drawing.Point(47, 229);
			this.dtGiris.Name = "dtGiris";
			this.dtGiris.Size = new System.Drawing.Size(200, 20);
			this.dtGiris.TabIndex = 6;
			// 
			// dtCikis
			// 
			this.dtCikis.Location = new System.Drawing.Point(47, 270);
			this.dtCikis.Name = "dtCikis";
			this.dtCikis.Size = new System.Drawing.Size(200, 20);
			this.dtCikis.TabIndex = 7;
			// 
			// btnReservation
			// 
			this.btnReservation.Enabled = false;
			this.btnReservation.Location = new System.Drawing.Point(47, 311);
			this.btnReservation.Name = "btnReservation";
			this.btnReservation.Size = new System.Drawing.Size(106, 23);
			this.btnReservation.TabIndex = 10;
			this.btnReservation.Text = "Rezervasyon Yap";
			this.btnReservation.UseVisualStyleBackColor = true;
			this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
			// 
			// lstRezervasyon
			// 
			this.lstRezervasyon.FormattingEnabled = true;
			this.lstRezervasyon.Location = new System.Drawing.Point(47, 74);
			this.lstRezervasyon.Name = "lstRezervasyon";
			this.lstRezervasyon.Size = new System.Drawing.Size(455, 134);
			this.lstRezervasyon.TabIndex = 11;
			this.lstRezervasyon.Click += new System.EventHandler(this.lstRezervasyon_Click);
			// 
			// cmbYemek
			// 
			this.cmbYemek.FormattingEnabled = true;
			this.cmbYemek.Location = new System.Drawing.Point(933, 33);
			this.cmbYemek.Name = "cmbYemek";
			this.cmbYemek.Size = new System.Drawing.Size(121, 21);
			this.cmbYemek.TabIndex = 12;
			// 
			// btnYemekSec
			// 
			this.btnYemekSec.Location = new System.Drawing.Point(1008, 77);
			this.btnYemekSec.Name = "btnYemekSec";
			this.btnYemekSec.Size = new System.Drawing.Size(75, 23);
			this.btnYemekSec.TabIndex = 13;
			this.btnYemekSec.Text = "Yemek Seç";
			this.btnYemekSec.UseVisualStyleBackColor = true;
			this.btnYemekSec.Click += new System.EventHandler(this.btnYemekSec_Click);
			// 
			// btnSiparis
			// 
			this.btnSiparis.Location = new System.Drawing.Point(897, 77);
			this.btnSiparis.Name = "btnSiparis";
			this.btnSiparis.Size = new System.Drawing.Size(93, 23);
			this.btnSiparis.TabIndex = 14;
			this.btnSiparis.Text = "Sipariş oluştur ";
			this.btnSiparis.UseVisualStyleBackColor = true;
			this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(172, 311);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 23);
			this.btnSil.TabIndex = 15;
			this.btnSil.Text = "Çıkış yap";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(365, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 22);
			this.label3.TabIndex = 16;
			this.label3.Text = "Odalar:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(826, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 21);
			this.label5.TabIndex = 16;
			this.label5.Text = "Yemekler:";
			// 
			// btnRezAktif
			// 
			this.btnRezAktif.Location = new System.Drawing.Point(325, 228);
			this.btnRezAktif.Name = "btnRezAktif";
			this.btnRezAktif.Size = new System.Drawing.Size(75, 23);
			this.btnRezAktif.TabIndex = 22;
			this.btnRezAktif.Text = "Aktif";
			this.btnRezAktif.UseVisualStyleBackColor = true;
			this.btnRezAktif.Click += new System.EventHandler(this.btnRezAktif_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnRezPasif);
			this.groupBox1.Controls.Add(this.btnRezHepsi);
			this.groupBox1.Controls.Add(this.lstRezervasyon);
			this.groupBox1.Controls.Add(this.dtGiris);
			this.groupBox1.Controls.Add(this.btnRezAktif);
			this.groupBox1.Controls.Add(this.dtCikis);
			this.groupBox1.Controls.Add(this.btnReservation);
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Location = new System.Drawing.Point(838, 176);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(551, 455);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rezervasyon";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(322, 316);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 37);
			this.label2.TabIndex = 42;
			this.label2.Text = "label2";
			// 
			// btnRezPasif
			// 
			this.btnRezPasif.Location = new System.Drawing.Point(325, 267);
			this.btnRezPasif.Name = "btnRezPasif";
			this.btnRezPasif.Size = new System.Drawing.Size(75, 23);
			this.btnRezPasif.TabIndex = 24;
			this.btnRezPasif.Text = "Pasif";
			this.btnRezPasif.UseVisualStyleBackColor = true;
			this.btnRezPasif.Click += new System.EventHandler(this.btnRezPasif_Click);
			// 
			// btnRezHepsi
			// 
			this.btnRezHepsi.Location = new System.Drawing.Point(427, 228);
			this.btnRezHepsi.Name = "btnRezHepsi";
			this.btnRezHepsi.Size = new System.Drawing.Size(75, 23);
			this.btnRezHepsi.TabIndex = 23;
			this.btnRezHepsi.Text = "Hepsi";
			this.btnRezHepsi.UseVisualStyleBackColor = true;
			this.btnRezHepsi.Click += new System.EventHandler(this.btnRezHepsi_Click);
			// 
			// btnRezFiyat
			// 
			this.btnRezFiyat.Enabled = false;
			this.btnRezFiyat.Location = new System.Drawing.Point(555, 200);
			this.btnRezFiyat.Name = "btnRezFiyat";
			this.btnRezFiyat.Size = new System.Drawing.Size(103, 24);
			this.btnRezFiyat.TabIndex = 43;
			this.btnRezFiyat.Text = "Oda fiyatı hesapla";
			this.btnRezFiyat.UseVisualStyleBackColor = true;
			this.btnRezFiyat.Click += new System.EventHandler(this.btnRezFiyat_Click);
			// 
			// btnRezOdaEkle
			// 
			this.btnRezOdaEkle.Enabled = false;
			this.btnRezOdaEkle.Location = new System.Drawing.Point(444, 200);
			this.btnRezOdaEkle.Name = "btnRezOdaEkle";
			this.btnRezOdaEkle.Size = new System.Drawing.Size(87, 26);
			this.btnRezOdaEkle.TabIndex = 41;
			this.btnRezOdaEkle.Text = "Rez e oda ekle";
			this.btnRezOdaEkle.UseVisualStyleBackColor = true;
			this.btnRezOdaEkle.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnOdaBosalt
			// 
			this.btnOdaBosalt.Location = new System.Drawing.Point(700, 33);
			this.btnOdaBosalt.Name = "btnOdaBosalt";
			this.btnOdaBosalt.Size = new System.Drawing.Size(75, 23);
			this.btnOdaBosalt.TabIndex = 25;
			this.btnOdaBosalt.Text = "Oda Boşalt";
			this.btnOdaBosalt.UseVisualStyleBackColor = true;
			this.btnOdaBosalt.Click += new System.EventHandler(this.btnOdaBosalt_Click);
			// 
			// btnMusteriSec
			// 
			this.btnMusteriSec.Location = new System.Drawing.Point(25, 176);
			this.btnMusteriSec.Name = "btnMusteriSec";
			this.btnMusteriSec.Size = new System.Drawing.Size(75, 23);
			this.btnMusteriSec.TabIndex = 9;
			this.btnMusteriSec.Text = "Müşteri Seç";
			this.btnMusteriSec.UseVisualStyleBackColor = true;
			this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
			// 
			// lstMusteri
			// 
			this.lstMusteri.FormattingEnabled = true;
			this.lstMusteri.Location = new System.Drawing.Point(12, 34);
			this.lstMusteri.Name = "lstMusteri";
			this.lstMusteri.Size = new System.Drawing.Size(279, 134);
			this.lstMusteri.TabIndex = 8;
			this.lstMusteri.Click += new System.EventHandler(this.lstMusteri_Click);
			// 
			// btnAdmin
			// 
			this.btnAdmin.Location = new System.Drawing.Point(1265, 12);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(110, 30);
			this.btnAdmin.TabIndex = 39;
			this.btnAdmin.Text = "Admin Paneli";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// lstOda
			// 
			this.lstOda.FormattingEnabled = true;
			this.lstOda.Location = new System.Drawing.Point(441, 33);
			this.lstOda.Name = "lstOda";
			this.lstOda.Size = new System.Drawing.Size(236, 134);
			this.lstOda.TabIndex = 40;
			this.lstOda.Click += new System.EventHandler(this.lstOda_Click);
			// 
			// txtMisafirIsim
			// 
			this.txtMisafirIsim.Location = new System.Drawing.Point(101, 272);
			this.txtMisafirIsim.Name = "txtMisafirIsim";
			this.txtMisafirIsim.Size = new System.Drawing.Size(100, 20);
			this.txtMisafirIsim.TabIndex = 32;
			// 
			// txtMisafirSoyIsim
			// 
			this.txtMisafirSoyIsim.Location = new System.Drawing.Point(101, 313);
			this.txtMisafirSoyIsim.Name = "txtMisafirSoyIsim";
			this.txtMisafirSoyIsim.Size = new System.Drawing.Size(100, 20);
			this.txtMisafirSoyIsim.TabIndex = 31;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(101, 352);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 33;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(22, 276);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 22);
			this.label1.TabIndex = 36;
			this.label1.Text = "İsim:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(22, 316);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 22);
			this.label6.TabIndex = 35;
			this.label6.Text = "Soyİsim:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(12, 350);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 22);
			this.label7.TabIndex = 34;
			this.label7.Text = "RoomNo";
			// 
			// btnMisafir
			// 
			this.btnMisafir.Location = new System.Drawing.Point(101, 409);
			this.btnMisafir.Name = "btnMisafir";
			this.btnMisafir.Size = new System.Drawing.Size(75, 23);
			this.btnMisafir.TabIndex = 37;
			this.btnMisafir.Text = "Misafir Ekle";
			this.btnMisafir.UseVisualStyleBackColor = true;
			this.btnMisafir.Click += new System.EventHandler(this.btnMisafir_Click);
			// 
			// lstMisafir
			// 
			this.lstMisafir.FormattingEnabled = true;
			this.lstMisafir.Location = new System.Drawing.Point(2, 463);
			this.lstMisafir.Name = "lstMisafir";
			this.lstMisafir.Size = new System.Drawing.Size(289, 134);
			this.lstMisafir.TabIndex = 38;
			this.lstMisafir.Click += new System.EventHandler(this.lstMisafir_Click);
			// 
			// btnRezGuestEkle
			// 
			this.btnRezGuestEkle.Enabled = false;
			this.btnRezGuestEkle.Location = new System.Drawing.Point(2, 603);
			this.btnRezGuestEkle.Name = "btnRezGuestEkle";
			this.btnRezGuestEkle.Size = new System.Drawing.Size(104, 23);
			this.btnRezGuestEkle.TabIndex = 41;
			this.btnRezGuestEkle.Text = "Odaya guest ekle";
			this.btnRezGuestEkle.UseVisualStyleBackColor = true;
			this.btnRezGuestEkle.Click += new System.EventHandler(this.btnRezGuestEkle_Click);
			// 
			// lblSonuc
			// 
			this.lblSonuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSonuc.Location = new System.Drawing.Point(441, 170);
			this.lblSonuc.Name = "lblSonuc";
			this.lblSonuc.Size = new System.Drawing.Size(236, 17);
			this.lblSonuc.TabIndex = 42;
			// 
			// btnMisafirCıkar
			// 
			this.btnMisafirCıkar.Enabled = false;
			this.btnMisafirCıkar.Location = new System.Drawing.Point(121, 602);
			this.btnMisafirCıkar.Name = "btnMisafirCıkar";
			this.btnMisafirCıkar.Size = new System.Drawing.Size(117, 24);
			this.btnMisafirCıkar.TabIndex = 43;
			this.btnMisafirCıkar.Text = "Odadan guest çıkart";
			this.btnMisafirCıkar.UseVisualStyleBackColor = true;
			this.btnMisafirCıkar.Click += new System.EventHandler(this.btnMisafirCıkar_Click);
			// 
			// btnMusteriAktif
			// 
			this.btnMusteriAktif.Location = new System.Drawing.Point(106, 176);
			this.btnMusteriAktif.Name = "btnMusteriAktif";
			this.btnMusteriAktif.Size = new System.Drawing.Size(75, 23);
			this.btnMusteriAktif.TabIndex = 44;
			this.btnMusteriAktif.Text = "Aktifler";
			this.btnMusteriAktif.UseVisualStyleBackColor = true;
			this.btnMusteriAktif.Click += new System.EventHandler(this.btnMusteriAktif_Click);
			// 
			// btnPasif
			// 
			this.btnPasif.Location = new System.Drawing.Point(187, 176);
			this.btnPasif.Name = "btnPasif";
			this.btnPasif.Size = new System.Drawing.Size(75, 23);
			this.btnPasif.TabIndex = 44;
			this.btnPasif.Text = "Pasifler";
			this.btnPasif.UseVisualStyleBackColor = true;
			this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
			// 
			// btnOdaTemizle
			// 
			this.btnOdaTemizle.Location = new System.Drawing.Point(700, 77);
			this.btnOdaTemizle.Name = "btnOdaTemizle";
			this.btnOdaTemizle.Size = new System.Drawing.Size(85, 24);
			this.btnOdaTemizle.TabIndex = 45;
			this.btnOdaTemizle.Text = "Odayı temizle";
			this.btnOdaTemizle.UseVisualStyleBackColor = true;
			this.btnOdaTemizle.Click += new System.EventHandler(this.btnOdaTemizle_Click);
			// 
			// btnKalanlar
			// 
			this.btnKalanlar.Location = new System.Drawing.Point(1265, 48);
			this.btnKalanlar.Name = "btnKalanlar";
			this.btnKalanlar.Size = new System.Drawing.Size(110, 26);
			this.btnKalanlar.TabIndex = 46;
			this.btnKalanlar.Text = "Odada Kalanlar";
			this.btnKalanlar.UseVisualStyleBackColor = true;
			this.btnKalanlar.Click += new System.EventHandler(this.btnKalanlar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1415, 646);
			this.Controls.Add(this.btnKalanlar);
			this.Controls.Add(this.btnOdaTemizle);
			this.Controls.Add(this.btnRezFiyat);
			this.Controls.Add(this.btnPasif);
			this.Controls.Add(this.btnMusteriAktif);
			this.Controls.Add(this.btnMisafirCıkar);
			this.Controls.Add(this.btnRezOdaEkle);
			this.Controls.Add(this.lblSonuc);
			this.Controls.Add(this.btnRezGuestEkle);
			this.Controls.Add(this.lstOda);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.lstMisafir);
			this.Controls.Add(this.btnMisafir);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.txtMisafirSoyIsim);
			this.Controls.Add(this.txtMisafirIsim);
			this.Controls.Add(this.btnMusteriSec);
			this.Controls.Add(this.lstMusteri);
			this.Controls.Add(this.btnOdaBosalt);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSiparis);
			this.Controls.Add(this.btnYemekSec);
			this.Controls.Add(this.cmbYemek);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtGiris;
        private System.Windows.Forms.DateTimePicker dtCikis;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.ListBox lstRezervasyon;
        private System.Windows.Forms.ComboBox cmbYemek;
        private System.Windows.Forms.Button btnYemekSec;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRezAktif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRezPasif;
        private System.Windows.Forms.Button btnRezHepsi;
        private System.Windows.Forms.Button btnOdaBosalt;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.ListBox lstMusteri;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.ListBox lstOda;
        private System.Windows.Forms.Button btnRezOdaEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRezFiyat;
        private System.Windows.Forms.TextBox txtMisafirIsim;
        private System.Windows.Forms.TextBox txtMisafirSoyIsim;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMisafir;
        private System.Windows.Forms.ListBox lstMisafir;
		private System.Windows.Forms.Button btnRezGuestEkle;
		private System.Windows.Forms.Label lblSonuc;
		private System.Windows.Forms.Button btnMisafirCıkar;
        private System.Windows.Forms.Button btnMusteriAktif;
        private System.Windows.Forms.Button btnPasif;
        private System.Windows.Forms.Button btnOdaTemizle;
		private System.Windows.Forms.Button btnKalanlar;
	}
}

