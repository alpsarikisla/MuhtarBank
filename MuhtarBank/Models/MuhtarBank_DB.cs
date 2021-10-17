using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MuhtarBank.Models
{
    public partial class MuhtarBank_DB : DbContext
    {
        public MuhtarBank_DB()
            : base("name=MuhtarBank_DB")
        {
        }

        public virtual DbSet<Musteri> Musterilers { get; set; }
        public virtual DbSet<Hesap> Hesaplars { get; set; }
        public virtual DbSet<SanalPosMusteri> SanalPosMusterilers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
