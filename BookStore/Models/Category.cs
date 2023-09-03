using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }

        public List<Book> Kitaplar;
    }
}
