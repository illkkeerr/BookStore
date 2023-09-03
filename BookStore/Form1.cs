using BookStore.Data;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        Context db = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriList();

            MusteriList();

            KitapList();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text != null)
            {
                Category kategori = new Category();

                kategori.KategoriAdi = txtKategoriAdi.Text;

                db.Categories.Add(kategori);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Kategori eklendi");
                else
                    MessageBox.Show("Bir hata oluştu");
                txtKategoriAdi.Text = "";
                KategoriList();
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();

                customer.Ad = txtAd.Text;
                customer.Soyad = txtSoyad.Text;
                customer.EPosta = txtEposta.Text;
                customer.Telefon = txtTelefon.Text;

                db.Customers.Add(customer);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Müşteri Eklendi");
                else
                    MessageBox.Show("Bir hata oluştu");
                txtAd.Text = txtSoyad.Text = txtEposta.Text = txtTelefon.Text = "";
                MusteriList();
            }
            catch (Exception)
            {

                hata();
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Baslik = txtBaslik.Text;
                book.Yazar = txtYazar.Text;


                book.YayinTarihi = ParseDate(mskYayinTarihi.Text);
                book.StokSayisi = int.Parse(txtStokSayisi.Text);
                var deger = db.Categories.FirstOrDefault(x => x.KategoriAdi == cmbKategori.Text);
                book.KategoriId = deger.KategoriId;
                db.Books.Add(book);

                if (db.SaveChanges() > 0)
                    MessageBox.Show("Kitap Eklendi");
                else
                    MessageBox.Show("Bir hata oluştu");
                txtBaslik.Text = txtYazar.Text = mskYayinTarihi.Text = txtStokSayisi.Text = "";

                KitapList();
            }
            catch (Exception)
            {

                hata();
            }
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowRecord record = new BorrowRecord();
                var deger = db.Books.FirstOrDefault(x => x.Baslik == cmbKitap.Text);
                record.KitapId = deger.KitapId;
                string[] musteri = cmbMusteri.Text.Split(' ');
                string ad = musteri[0];
                string soyad = musteri[1];
                var deger2 = db.Customers.FirstOrDefault(x => x.Ad == ad && x.Soyad == soyad);
                record.MusteriId = deger2.MusteriId;
                record.IadeTarihi = ParseDate(mskIadeTarihi.Text);
                record.OduncTarihi = ParseDate(mskOduncTarihi.Text);
                db.BorrowRecords.Add(record);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("kayıt oluşturuldu");
                else
                    MessageBox.Show("Bir hata oluştu");

                mskOduncTarihi.Text = mskIadeTarihi.Text = cmbKitap.Text = cmbMusteri.Text = "";
            }
            catch (Exception)
            {

                hata();
            }
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

            cmbMusteri.Items.Clear();
            var deger3 = db.Books.ToList();
            foreach (var item in deger3)
            {
                cmbKitap.Items.Add(item.Baslik);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        void hata()
        {
            MessageBox.Show("bir hata oluştu");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KategoriList();
            MusteriList();
            KitapList();
        }
    }
}
