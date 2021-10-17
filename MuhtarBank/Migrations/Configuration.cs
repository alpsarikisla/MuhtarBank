namespace MuhtarBank.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MuhtarBank.Models.MuhtarBank_DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MuhtarBank.Models.MuhtarBank_DB context)
        {
            context.Musterilers.AddOrUpdate(x => x.ID, new Models.Musteri { ID = 1, Isim = "Büþra", Soyad = "Kaan", Telefon = "530XXXXXXX" });
            context.Musterilers.AddOrUpdate(x => x.ID, new Models.Musteri { ID = 2, Isim = "Cansu", Soyad = "Kalava", Telefon = "549XXXXXXX" });

            context.Musterilers.AddOrUpdate(x => x.ID, new Models.Musteri { ID = 3, Isim = "Alihan", Soyad = "Özcan", Telefon = "535XXXXXXX" });
            context.Hesaplars.AddOrUpdate(x => x.ID, new Models.Hesap { ID = 1, Musteri_ID = 3, Bakiye = 4000,KartNo="1234123412341234", SonKullanmaAy="12", SonKullanmaYil="25", CCV="123" });

            context.SanalPosMusterilers.AddOrUpdate(x => x.ID, new Models.SanalPosMusteri { ID = 1, MusteriKodu = "9876", MusteriSifre = "1587", Durum=true });

        }
    }
}
