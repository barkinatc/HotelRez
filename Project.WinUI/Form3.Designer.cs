namespace Project.WinUI
{
    partial class Form3
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnMusteri = new System.Windows.Forms.Button();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtSoyIsim = new System.Windows.Forms.TextBox();
			this.txtIsim = new System.Windows.Forms.TextBox();
			this.btnAktif = new System.Windows.Forms.Button();
			this.btnPasif = new System.Windows.Forms.Button();
			this.btnMusteriSil = new System.Windows.Forms.Button();
			this.btnHepsi = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnYemekEkle = new System.Windows.Forms.Button();
			this.txtYemekIsim = new System.Windows.Forms.TextBox();
			this.txtYemekFiyat = new System.Windows.Forms.TextBox();
			this.cmbYemek = new System.Windows.Forms.ComboBox();
			this.txtRoomTipiIsim = new System.Windows.Forms.TextBox();
			this.txtRoomTipiAciklama = new System.Windows.Forms.TextBox();
			this.txtRoomTipiFiyat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lstMusteri = new System.Windows.Forms.ListBox();
			this.cmbRoomTip = new System.Windows.Forms.ComboBox();
			this.txtKapasite = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtRoomAcıklama = new System.Windows.Forms.TextBox();
			this.txtRoomKapasite = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnOdaEkle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(56, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 22);
			this.label4.TabIndex = 28;
			this.label4.Text = "TelNo:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(56, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 22);
			this.label1.TabIndex = 29;
			this.label1.Text = "Soyİsim:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(56, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 22);
			this.label2.TabIndex = 30;
			this.label2.Text = "İsim:";
			// 
			// btnMusteri
			// 
			this.btnMusteri.Location = new System.Drawing.Point(103, 165);
			this.btnMusteri.Name = "btnMusteri";
			this.btnMusteri.Size = new System.Drawing.Size(88, 23);
			this.btnMusteri.TabIndex = 27;
			this.btnMusteri.Text = "Müşteri Ekle";
			this.btnMusteri.UseVisualStyleBackColor = true;
			this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(123, 107);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(100, 20);
			this.txtTel.TabIndex = 26;
			// 
			// txtSoyIsim
			// 
			this.txtSoyIsim.Location = new System.Drawing.Point(123, 68);
			this.txtSoyIsim.Name = "txtSoyIsim";
			this.txtSoyIsim.Size = new System.Drawing.Size(100, 20);
			this.txtSoyIsim.TabIndex = 24;
			// 
			// txtIsim
			// 
			this.txtIsim.Location = new System.Drawing.Point(123, 27);
			this.txtIsim.Name = "txtIsim";
			this.txtIsim.Size = new System.Drawing.Size(100, 20);
			this.txtIsim.TabIndex = 25;
			// 
			// btnAktif
			// 
			this.btnAktif.Location = new System.Drawing.Point(134, 586);
			this.btnAktif.Name = "btnAktif";
			this.btnAktif.Size = new System.Drawing.Size(75, 23);
			this.btnAktif.TabIndex = 19;
			this.btnAktif.Text = "Aktif";
			this.btnAktif.UseVisualStyleBackColor = true;
			this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
			// 
			// btnPasif
			// 
			this.btnPasif.Location = new System.Drawing.Point(228, 586);
			this.btnPasif.Name = "btnPasif";
			this.btnPasif.Size = new System.Drawing.Size(75, 23);
			this.btnPasif.TabIndex = 20;
			this.btnPasif.Text = "Pasif";
			this.btnPasif.UseVisualStyleBackColor = true;
			this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
			// 
			// btnMusteriSil
			// 
			this.btnMusteriSil.Location = new System.Drawing.Point(335, 586);
			this.btnMusteriSil.Name = "btnMusteriSil";
			this.btnMusteriSil.Size = new System.Drawing.Size(75, 23);
			this.btnMusteriSil.TabIndex = 17;
			this.btnMusteriSil.Text = "Sil";
			this.btnMusteriSil.UseVisualStyleBackColor = true;
			this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
			// 
			// btnHepsi
			// 
			this.btnHepsi.Location = new System.Drawing.Point(32, 586);
			this.btnHepsi.Name = "btnHepsi";
			this.btnHepsi.Size = new System.Drawing.Size(75, 23);
			this.btnHepsi.TabIndex = 21;
			this.btnHepsi.Text = "Hepsi";
			this.btnHepsi.UseVisualStyleBackColor = true;
			this.btnHepsi.Click += new System.EventHandler(this.btnHepsi_Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(306, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 21);
			this.label5.TabIndex = 36;
			this.label5.Text = "Yemekler:";
			// 
			// btnYemekEkle
			// 
			this.btnYemekEkle.Location = new System.Drawing.Point(413, 146);
			this.btnYemekEkle.Name = "btnYemekEkle";
			this.btnYemekEkle.Size = new System.Drawing.Size(75, 23);
			this.btnYemekEkle.TabIndex = 34;
			this.btnYemekEkle.Text = "Yemek Ekle";
			this.btnYemekEkle.UseVisualStyleBackColor = true;
			this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
			// 
			// txtYemekIsim
			// 
			this.txtYemekIsim.Location = new System.Drawing.Point(402, 71);
			this.txtYemekIsim.Name = "txtYemekIsim";
			this.txtYemekIsim.Size = new System.Drawing.Size(100, 20);
			this.txtYemekIsim.TabIndex = 37;
			// 
			// txtYemekFiyat
			// 
			this.txtYemekFiyat.Location = new System.Drawing.Point(402, 111);
			this.txtYemekFiyat.Name = "txtYemekFiyat";
			this.txtYemekFiyat.Size = new System.Drawing.Size(100, 20);
			this.txtYemekFiyat.TabIndex = 38;
			// 
			// cmbYemek
			// 
			this.cmbYemek.FormattingEnabled = true;
			this.cmbYemek.Location = new System.Drawing.Point(381, 12);
			this.cmbYemek.Name = "cmbYemek";
			this.cmbYemek.Size = new System.Drawing.Size(121, 21);
			this.cmbYemek.TabIndex = 33;
			// 
			// txtRoomTipiIsim
			// 
			this.txtRoomTipiIsim.Location = new System.Drawing.Point(736, 27);
			this.txtRoomTipiIsim.Name = "txtRoomTipiIsim";
			this.txtRoomTipiIsim.Size = new System.Drawing.Size(100, 20);
			this.txtRoomTipiIsim.TabIndex = 25;
			// 
			// txtRoomTipiAciklama
			// 
			this.txtRoomTipiAciklama.Location = new System.Drawing.Point(736, 68);
			this.txtRoomTipiAciklama.Name = "txtRoomTipiAciklama";
			this.txtRoomTipiAciklama.Size = new System.Drawing.Size(100, 20);
			this.txtRoomTipiAciklama.TabIndex = 24;
			// 
			// txtRoomTipiFiyat
			// 
			this.txtRoomTipiFiyat.Location = new System.Drawing.Point(736, 107);
			this.txtRoomTipiFiyat.Name = "txtRoomTipiFiyat";
			this.txtRoomTipiFiyat.Size = new System.Drawing.Size(100, 20);
			this.txtRoomTipiFiyat.TabIndex = 26;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(619, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 22);
			this.label3.TabIndex = 30;
			this.label3.Text = "RoomTipi:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(619, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 22);
			this.label6.TabIndex = 29;
			this.label6.Text = "Açıklama:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(638, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 22);
			this.label7.TabIndex = 28;
			this.label7.Text = "Fiyatı:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(736, 179);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 24);
			this.button1.TabIndex = 39;
			this.button1.Text = "Room Tip Ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lstMusteri
			// 
			this.lstMusteri.FormattingEnabled = true;
			this.lstMusteri.Location = new System.Drawing.Point(32, 445);
			this.lstMusteri.Name = "lstMusteri";
			this.lstMusteri.Size = new System.Drawing.Size(247, 95);
			this.lstMusteri.TabIndex = 40;
			this.lstMusteri.Click += new System.EventHandler(this.lstMusteri_Click);
			// 
			// cmbRoomTip
			// 
			this.cmbRoomTip.FormattingEnabled = true;
			this.cmbRoomTip.Location = new System.Drawing.Point(874, 12);
			this.cmbRoomTip.Name = "cmbRoomTip";
			this.cmbRoomTip.Size = new System.Drawing.Size(121, 21);
			this.cmbRoomTip.TabIndex = 33;
			// 
			// txtKapasite
			// 
			this.txtKapasite.Location = new System.Drawing.Point(736, 146);
			this.txtKapasite.Name = "txtKapasite";
			this.txtKapasite.Size = new System.Drawing.Size(100, 20);
			this.txtKapasite.TabIndex = 41;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(638, 147);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 22);
			this.label8.TabIndex = 28;
			this.label8.Text = "Kapasite";
			// 
			// txtRoomAcıklama
			// 
			this.txtRoomAcıklama.Location = new System.Drawing.Point(969, 234);
			this.txtRoomAcıklama.Name = "txtRoomAcıklama";
			this.txtRoomAcıklama.Size = new System.Drawing.Size(100, 20);
			this.txtRoomAcıklama.TabIndex = 24;
			// 
			// txtRoomKapasite
			// 
			this.txtRoomKapasite.Location = new System.Drawing.Point(969, 273);
			this.txtRoomKapasite.Name = "txtRoomKapasite";
			this.txtRoomKapasite.Size = new System.Drawing.Size(100, 20);
			this.txtRoomKapasite.TabIndex = 26;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(852, 236);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(92, 22);
			this.label10.TabIndex = 29;
			this.label10.Text = "Açıklama:";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label11.Location = new System.Drawing.Point(871, 271);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(92, 22);
			this.label11.TabIndex = 28;
			this.label11.Text = "Kapasite:";
			// 
			// btnOdaEkle
			// 
			this.btnOdaEkle.Location = new System.Drawing.Point(982, 313);
			this.btnOdaEkle.Name = "btnOdaEkle";
			this.btnOdaEkle.Size = new System.Drawing.Size(75, 23);
			this.btnOdaEkle.TabIndex = 42;
			this.btnOdaEkle.Text = "Oda Ekle";
			this.btnOdaEkle.UseVisualStyleBackColor = true;
			this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 236);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(798, 150);
			this.dataGridView1.TabIndex = 43;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1412, 635);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnOdaEkle);
			this.Controls.Add(this.txtKapasite);
			this.Controls.Add(this.lstMusteri);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtYemekFiyat);
			this.Controls.Add(this.txtYemekIsim);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnYemekEkle);
			this.Controls.Add(this.cmbRoomTip);
			this.Controls.Add(this.cmbYemek);
			this.Controls.Add(this.btnHepsi);
			this.Controls.Add(this.btnMusteriSil);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnPasif);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAktif);
			this.Controls.Add(this.txtRoomKapasite);
			this.Controls.Add(this.txtRoomTipiFiyat);
			this.Controls.Add(this.btnMusteri);
			this.Controls.Add(this.txtRoomAcıklama);
			this.Controls.Add(this.txtRoomTipiAciklama);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtRoomTipiIsim);
			this.Controls.Add(this.txtSoyIsim);
			this.Controls.Add(this.txtIsim);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSoyIsim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnAktif;
        private System.Windows.Forms.Button btnPasif;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnHepsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYemekEkle;
        private System.Windows.Forms.TextBox txtYemekIsim;
        private System.Windows.Forms.TextBox txtYemekFiyat;
        private System.Windows.Forms.ComboBox cmbYemek;
        private System.Windows.Forms.TextBox txtRoomTipiIsim;
        private System.Windows.Forms.TextBox txtRoomTipiAciklama;
        private System.Windows.Forms.TextBox txtRoomTipiFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstMusteri;
        private System.Windows.Forms.ComboBox cmbRoomTip;
		private System.Windows.Forms.TextBox txtKapasite;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtRoomAcıklama;
		private System.Windows.Forms.TextBox txtRoomKapasite;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnOdaEkle;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}