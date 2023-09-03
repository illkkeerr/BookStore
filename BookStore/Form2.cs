using BookStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form2 : Form
    {
        Context db = new Context();
        byte tabloNo = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KategoriListele(db);
            KategoriList();

            MusteriList();

            KitapList();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            try
            {
                var deger = db.Categories.Find(int.Parse(txtKategoriId.Text));
                db.Categories.Remove(deger);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("kategori silindi");
                else
                    MessageBox.Show("bir hata oluştu");
                txtKategoriId.Text = txtKategoriAdi.Text = "";

                KategoriListele(db);
                KategoriList();
            }
            catch (Exception)
            {

                hata();
            }

        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var deger = db.Categories.Find(int.Parse(txtKategoriId.Text));
                deger.KategoriAdi = txtKategoriAdi.Text;
                db.Categories.AddOrUpdate(deger);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("güncelleme başarılı");
                else
                    MessageBox.Show("bir hata oluştu");
                txtKategoriId.Text = txtKategoriAdi.Text = "";

                KategoriListele(db);
                KategoriList();
            }
            catch (Exception)
            {

                hata();
            }


        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            try
            {
                var deger = db.Books.Find(int.Parse(txtKitapId.Text));
                db.Books.Remove(deger);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("kitap silindi");
                else
                    MessageBox.Show("bir hata oluştu");
                txtKitapId.Text = txtBaslik.Text = txtYazar.Text = mskYayinTarihi.Text = txtStokSayisi.Text = cmbKategori.Text = "";

                KitapListele(db);
                KitapList();
            }
            catch (Exception)
            {

                hata();
            }


        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var deger = db.Books.Find(int.Parse(txtKitapId.Text));
                deger.Baslik = txtBaslik.Text;
                deger.Yazar = txtYazar.Text;
                deger.YayinTarihi = ParseDate(mskYayinTarihi.Text);
                deger.StokSayisi = int.Parse(txtStokSayisi.Text);
                deger.KategoriId = db.Categories.FirstOrDefault(x => x.KategoriAdi == cmbKategori.Text).KategoriId;
                db.Books.AddOrUpdate(deger);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("kitap güncellendi");
                else
                    MessageBox.Show("bir hata oluştu");
                txtKitapId.Text = txtBaslik.Text = txtYazar.Text = mskYayinTarihi.Text = txtStokSayisi.Text = cmbKategori.Text = "";

                KitapListele(db);
                KitapList();
            }
            catch (Exception)
            {

                hata();
            }

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                var deger = db.Customers.Find(int.Parse(txtMusteriId.Text));
                db.Customers.Remove(deger);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Müşteri silindi");
                else
                    MessageBox.Show("bir hata oluştu");
                txtMusteriId.Text = txtAd.Text = txtSoyad.Text = txtEposta.Text = txtTelefon.Text = "";

                MusteriListele(db);
                MusteriList();
            }
            catch (Exception)
            {

                hata();
            }

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var deger = db.Customers.Find(int.Parse(txtMusteriId.Text));
                deger.Ad = txtAd.Text;
                deger.Soyad = txtSoyad.Text;
                deger.EPosta = txtEposta.Text;
                deger.Telefon = txtTelefon.Text;
                db.Customers.AddOrUpdate(deger);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Müşteri güncellendi");
                else
                    MessageBox.Show("bir hata oluştu");
                txtMusteriId.Text = txtAd.Text = txtSoyad.Text = txtEposta.Text = txtTelefon.Text = "";

                MusteriListele(db);
                MusteriList();
            }
            catch (Exception)
            {

                hata();
            }

        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            try
            {
                var deger = db.BorrowRecords.Find(int.Parse(txtKayitId.Text));
                db.BorrowRecords.Remove(deger);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Ödünç Kaydı silindi");
                else
                    MessageBox.Show("bir hata oluştu");
                txtKayitId.Text = cmbMusteri.Text = cmbKitap.Text = mskIadeTarihi.Text = mskOduncTarihi.Text = "";

                KayitListele(db);
            }
            catch (Exception)
            {

                hata();
            }

        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var deger = db.BorrowRecords.Find(int.Parse(txtKayitId.Text));
                string[] musteri = cmbMusteri.Text.Split(' ');
                string ad = musteri[0];
                string soyad = musteri[1];
                deger.MusteriId = db.Customers.FirstOrDefault(x => x.Ad == ad && x.Soyad == soyad).MusteriId;
                deger.KitapId = db.Books.FirstOrDefault(x => x.Baslik == cmbKitap.Text).KitapId;
                deger.IadeTarihi = ParseDate(mskIadeTarihi.Text);
                deger.OduncTarihi = ParseDate(mskOduncTarihi.Text);
                db.BorrowRecords.AddOrUpdate(deger);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Ödünç kaydı güncellendi");
                else
                    MessageBox.Show("bir hata oluştu");
                txtKayitId.Text = cmbMusteri.Text = cmbKitap.Text = mskIadeTarihi.Text = mskOduncTarihi.Text = "";

                KayitListele(db);
            }
            catch (Exception)
            {

                hata();
            }



        }

        private void KategoriListele(Context db)
        {
            Secim(0);
            tabloNo = 0;
            dataGridView1.DataSource = db.Categories.ToList();
        }

        private void KitapListele(Context db)
        {
            Secim(1);
            tabloNo = 1;
            dataGridView1.DataSource = db.Books
                .Select(x => new { x.KitapId, x.Baslik, x.Yazar, x.YayinTarihi, x.StokSayisi, x.Kategori.KategoriAdi, })
                .ToList();
        }

        private void MusteriListele(Context db)
        {
            Secim(0);
            tabloNo = 2;
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void KayitListele(Context db)
        {
            Secim(1);
            tabloNo = 3;
            dataGridView1.DataSource = db.BorrowRecords
                .Select(x => new { x.KayitId, x.Musteri.Ad, x.Musteri.Soyad, x.Kitap.Baslik, x.OduncTarihi, x.IadeTarihi })
                .ToList();
        }

        private void KategoriList()
        {

            cmbKategori.Items.Clear();
            var deger = db.Categories.ToList();

            foreach (var item in deger)
            {
                cmbKategori.Items.Add(item.KategoriAdi);


            }
        }

        private void MusteriList()
        {
            cmbMusteri.Items.Clear();
            var deger2 = db.Customers.ToList();
            foreach (var item in deger2)
            {
                cmbMusteri.Items.Add(item.Ad + " " + item.Soyad);

            }
        }

        private void KitapList()
        {
            cmbKitap.Items.Clear();
            var deger3 = db.Books.ToList();
            foreach (var item in deger3)
            {
                cmbKitap.Items.Add(item.Baslik);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriListele(db);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapListele(db);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MusteriListele(db);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            KayitListele(db);
        }

        void Secim(byte secim)
        {
            switch (secim)
            {
                case 0:
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; break;
                case 1:
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; break;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            switch (tabloNo)
            {
                case 0:
                    txtKategoriId.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
                    txtKategoriAdi.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
                    break;
                case 1:
                    txtKitapId.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
                    txtBaslik.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
                    txtYazar.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
                    mskYayinTarihi.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
                    if (mskYayinTarihi.Text.Length < 10)
                        mskYayinTarihi.Text = "0" + mskYayinTarihi.Text;
                    txtStokSayisi.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
                    cmbKategori.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();

                    break;
                case 2:
                    txtMusteriId.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
                    txtAd.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
                    txtSoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
                    txtEposta.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
                    txtTelefon.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();

                    break;
                case 3:
                    txtKayitId.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
                    cmbMusteri.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString() + " " + dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
                    cmbKitap.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
                    mskOduncTarihi.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
                    if (mskOduncTarihi.Text.Length < 10)
                        mskOduncTarihi.Text = "0" + mskOduncTarihi.Text;
                    mskIadeTarihi.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();
                    if (mskIadeTarihi.Text.Length < 10)
                        mskIadeTarihi.Text = "0" + mskIadeTarihi.Text;

                    break;
                default:
                    break;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is ComboBox || item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
        }

        DateTime ParseDate(string dateText)
        {
            string[] dateParts = dateText.Split('.');
            if (dateParts.Length == 3)
            {
                if (int.TryParse(dateParts[0], out int day) &&
                    int.TryParse(dateParts[1], out int month) &&
                    int.TryParse(dateParts[2], out int year))
                {
                    // Girilen tarih doğru bir şekilde ayrıştırıldı
                    try
                    {
                        return new DateTime(year, month, day);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        // Geçersiz bir tarih oluşturuldu
                        return (DateTime.Now).AddYears(100);
                    }
                }
            }

            // Geçersiz tarih formatı
            return (DateTime.Now).AddYears(100);
        }

        void hata()
        {
            MessageBox.Show("bir hata oluştu");
        }


    }
}
