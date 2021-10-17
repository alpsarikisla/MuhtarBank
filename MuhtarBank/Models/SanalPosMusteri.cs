using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhtarBank.Models
{
    public class SanalPosMusteri
    {
        public int ID { get; set; }

        [StringLength(maximumLength:50)]
        public string MusteriKodu { get; set; }

        [StringLength(maximumLength: 50)]
        public string MusteriSifre { get; set; }
        public bool Durum { get; set; }
    }
}