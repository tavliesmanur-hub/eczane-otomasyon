using System;
using System.Data.Entity;
using System.Linq;

namespace eczaneoto
{
    public class EczaneDbContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Ilac> Ilaclar { get; set; }
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Recete> Receteler { get; set; }

        public EczaneDbContext() : base("name=EczaneDbContext")
        {
            // Veritabanını otomatik kontrol et ve başlangıç verilerini yükle
            Database.SetInitializer(new EczaneDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().ToTable("Table_Kategori");
            modelBuilder.Entity<Ilac>().ToTable("Table_Ilac");
            modelBuilder.Entity<Hasta>().ToTable("Table_Hasta");
            modelBuilder.Entity<Recete>().ToTable("Table_Recete");

            base.OnModelCreating(modelBuilder);
        }
    }

    // ── VERİTABANINA OTOMATİK KATEGORİ EKLEYEN YENİ KISIM ──
    public class EczaneDbInitializer : CreateDatabaseIfNotExists<EczaneDbContext>
    {
        protected override void Seed(EczaneDbContext context)
        {
            // Eğer veritabanında hiç kategori yoksa otomatik ekler
            if (!context.Kategoriler.Any())
            {
                context.Kategoriler.Add(new Kategori { Kategori_Adi = "Ağrı Kesiciler", Kategori_Aciklama = "Genel ağrı kesici ilaçlar" });
                context.Kategoriler.Add(new Kategori { Kategori_Adi = "Antibiyotikler", Kategori_Aciklama = "Bakteriyel enfeksiyon ilaçları" });
                context.Kategoriler.Add(new Kategori { Kategori_Adi = "Vitaminler", Kategori_Aciklama = "Takviye edici vitamin grupları" });

                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}