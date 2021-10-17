using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhtarBank.Models
{
    public class Musteri
    {
        public int ID { get; set; }

        [StringLength(maximumLength: 50)]
        public string Isim { get; set; }

        [StringLength(maximumLength: 50)]
        public string Soyad { get; set; }

        [StringLength(maximumLength: 50)]
        public string Telefon { get; set; }

        public ICollection<Hesap> Hesaplar { get; set; }
    }
}