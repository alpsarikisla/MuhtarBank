using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MuhtarBank.Models
{
    public class Hesap
    {
        public int ID { get; set; }
       
        public int Musteri_ID { get; set; }

        [ForeignKey("Musteri_ID")]
        public virtual Musteri musteriler { get; set; }
        public decimal Bakiye { get; set; }

        [StringLength(maximumLength: 50)]
        public string KartNo { get; set; }

        [StringLength(maximumLength: 50)]
        public string SonKullanmaAy { get; set; }

        [StringLength(maximumLength: 50)]
        public string SonKullanmaYil { get; set; }

        [StringLength(maximumLength: 50)]
        public string CCV { get; set; }

    }
}