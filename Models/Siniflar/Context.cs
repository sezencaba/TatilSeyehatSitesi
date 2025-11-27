using Microsoft.EntityFrameworkCore;

namespace MvcSeyehatSitesi_20._10._2025.Models.Siniflar
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Blog ve Yorumlar arasındaki ilişkiyi tanımla
            modelBuilder.Entity<Yorumlar>()
                .HasOne(y => y.Blog)
                .WithMany(b => b.Yorumlars)
                .HasForeignKey(y => y.BlogID);

            // Admin tablosu için varsayılan değerler
            modelBuilder.Entity<Admin>().HasData(
                new Admin { ID = 1, Kullanici = "admin", Sifre = "123456" }
            );

            // Blog tablosu için örnek veriler
            modelBuilder.Entity<Blog>().HasData(
                new Blog 
                { 
                    ID = 1, 
                    Baslik = "İstanbul'da Gezilecek Yerler", 
                    Tarih = DateTime.Now, 
                    Aciklama = "İstanbul'un en güzel yerlerini keşfedin...", 
                    BlogImage = "istanbul.jpg" 
                },
                new Blog 
                { 
                    ID = 2, 
                    Baslik = "Kapadokya Balon Turu", 
                    Tarih = DateTime.Now.AddDays(-1), 
                    Aciklama = "Kapadokya'da unutulmaz bir balon turu deneyimi...", 
                    BlogImage = "kapadokya.jpg" 
                }
            );

            // Hakkımızda için örnek veri
            modelBuilder.Entity<Hakkimizda>().HasData(
                new Hakkimizda 
                { 
                    ID = 1, 
                    FotoUrl = "https://picsum.photos/400/300?random=1", 
                    Aciklama = "Bu proje Mvc Code First Entity yapısı kullanılarak 50 derslik bir seri kapsamında tamamen ücretsiz olarak hazırlamaktadır. Serimize Youtube kanlımızdan ulaşabilirsiniz..." 
                }
            );

            // İletişim bilgileri için örnek veri
            modelBuilder.Entity<AdresBlog>().HasData(
                new AdresBlog 
                { 
                    ID = 1, 
                    Baslik = "İletişim Bilgileri", 
                    Aciklama = "Bizimle iletişime geçin", 
                    AdresAcik = "İstanbul, Türkiye", 
                    Mail = "info@seyahatsitesi.com", 
                    Telefon = "+90 212 555 0123", 
                    Konum = "https://maps.google.com" 
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
