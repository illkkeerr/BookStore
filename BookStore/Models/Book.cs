using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int KitapId { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public DateTime YayinTarihi { get; set; }
        public int StokSayisi { get; set; }
        public int KategoriId { get; set; }
        public Category Kategori { get; set; }

        public List<BorrowRecord> OduncKayitlari { get; set; }
    }
}
