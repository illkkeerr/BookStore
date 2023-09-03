using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BorrowRecord
    {
        [Key]
        public int KayitId { get; set; }
        public int MusteriId { get; set; }
        public int KitapId { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime IadeTarihi { get; set; }

        public Customer Musteri { get; set; }
        public Book Kitap { get; set; }
    }
}
