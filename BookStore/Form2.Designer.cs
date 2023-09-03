namespace BookStore
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.mskIadeTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mskOduncTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnKayitGuncelle = new System.Windows.Forms.Button();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.mskYayinTarihi = new System.Windows.Forms.MaskedTextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtKayitId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "KategoriList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "KitapList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "MusteriList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(502, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "KayıtList";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(276, 470);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(120, 34);
            this.btnKategoriGuncelle.TabIndex = 5;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(176, 374);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(220, 22);
            this.txtKategoriId.TabIndex = 6;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(176, 419);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(220, 22);
            this.txtKategoriAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "KategoriId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kategori Adi";
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(176, 470);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(81, 34);
            this.btnKategoriSil.TabIndex = 12;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(964, 84);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(166, 22);
            this.txtAd.TabIndex = 15;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(964, 134);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(166, 22);
            this.txtSoyad.TabIndex = 17;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(964, 234);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(166, 22);
            this.txtTelefon.TabIndex = 20;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(964, 184);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(166, 22);
            this.txtEposta.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(894, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(894, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Eposta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(894, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(904, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ad";
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(910, 290);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(81, 34);
            this.btnMusteriSil.TabIndex = 45;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(1010, 290);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(120, 34);
            this.btnMusteriGuncelle.TabIndex = 44;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(1303, 91);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(166, 24);
            this.cmbMusteri.TabIndex = 48;
            // 
            // cmbKitap
            // 
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(1303, 142);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(166, 24);
            this.cmbKitap.TabIndex = 49;
            // 
            // mskIadeTarihi
            // 
            this.mskIadeTarihi.Location = new System.Drawing.Point(1303, 242);
            this.mskIadeTarihi.Mask = "00/00/0000";
            this.mskIadeTarihi.Name = "mskIadeTarihi";
            this.mskIadeTarihi.Size = new System.Drawing.Size(166, 22);
            this.mskIadeTarihi.TabIndex = 51;
            this.mskIadeTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mskOduncTarihi
            // 
            this.mskOduncTarihi.Location = new System.Drawing.Point(1303, 193);
            this.mskOduncTarihi.Mask = "00/00/0000";
            this.mskOduncTarihi.Name = "mskOduncTarihi";
            this.mskOduncTarihi.Size = new System.Drawing.Size(166, 22);
            this.mskOduncTarihi.TabIndex = 50;
            this.mskOduncTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1218, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "İade Tarihi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1212, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 55;
            this.label13.Text = "Ödünç tarihi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1245, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 54;
            this.label14.Text = "Kitap";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1232, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "Müşteri";
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(1249, 301);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(81, 34);
            this.btnKayitSil.TabIndex = 58;
            this.btnKayitSil.Text = "Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // btnKayitGuncelle
            // 
            this.btnKayitGuncelle.Location = new System.Drawing.Point(1349, 301);
            this.btnKayitGuncelle.Name = "btnKayitGuncelle";
            this.btnKayitGuncelle.Size = new System.Drawing.Size(120, 34);
            this.btnKayitGuncelle.TabIndex = 57;
            this.btnKayitGuncelle.Text = "Güncelle";
            this.btnKayitGuncelle.UseVisualStyleBackColor = true;
            this.btnKayitGuncelle.Click += new System.EventHandler(this.btnKayitGuncelle_Click);
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(964, 42);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(166, 22);
            this.txtMusteriId.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(867, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 59;
            this.label16.Text = "MusteriId";
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(501, 634);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(81, 34);
            this.btnKitapSil.TabIndex = 72;
            this.btnKitapSil.Text = "Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Location = new System.Drawing.Point(601, 634);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(120, 34);
            this.btnKitapGuncelle.TabIndex = 71;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // mskYayinTarihi
            // 
            this.mskYayinTarihi.Location = new System.Drawing.Point(555, 477);
            this.mskYayinTarihi.Mask = "00/00/0000";
            this.mskYayinTarihi.Name = "mskYayinTarihi";
            this.mskYayinTarihi.Size = new System.Drawing.Size(166, 22);
            this.mskYayinTarihi.TabIndex = 67;
            this.mskYayinTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 16;
            this.cmbKategori.Location = new System.Drawing.Point(555, 578);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(166, 24);
            this.cmbKategori.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 580);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "KategoriId";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(555, 383);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(166, 22);
            this.txtBaslik.TabIndex = 63;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(555, 430);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(166, 22);
            this.txtYazar.TabIndex = 65;
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.Location = new System.Drawing.Point(555, 524);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(166, 22);
            this.txtStokSayisi.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "StokSayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "YayinTarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Yazar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "Başlık";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Location = new System.Drawing.Point(555, 336);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(166, 22);
            this.txtKitapId.TabIndex = 74;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(446, 339);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 73;
            this.label17.Text = "KitapId";
            // 
            // txtKayitId
            // 
            this.txtKayitId.Location = new System.Drawing.Point(1303, 42);
            this.txtKayitId.Name = "txtKayitId";
            this.txtKayitId.Size = new System.Drawing.Size(166, 22);
            this.txtKayitId.TabIndex = 76;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1235, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 75;
            this.label18.Text = "KayıtId";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(897, 400);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(288, 52);
            this.btnTemizle.TabIndex = 77;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtKayitId);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtKitapId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.btnKitapGuncelle);
            this.Controls.Add(this.mskYayinTarihi);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtStokSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMusteriId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnKayitGuncelle);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.mskIadeTarihi);
            this.Controls.Add(this.mskOduncTarihi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.txtKategoriId);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.MaskedTextBox mskIadeTarihi;
        private System.Windows.Forms.MaskedTextBox mskOduncTarihi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnKayitGuncelle;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.MaskedTextBox mskYayinTarihi;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtKayitId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnTemizle;
    }
}