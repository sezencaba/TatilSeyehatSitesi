using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcSeyehatSitesi_20._10._2025.Models.Siniflar;

#nullable disable

namespace MvcSeyehatSitesi_20._10._2025.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250120000000_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Kullanici")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Kullanici = "admin",
                            Sifre = "123456"
                        });
                });

            modelBuilder.Entity("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.AdresBlog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresAcik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AdresBlogs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "Bizimle iletişime geçin",
                            AdresAcik = "İstanbul, Türkiye",
                            Baslik = "İletişim Bilgileri",
                            Konum = "https://maps.google.com",
                            Mail = "info@seyahatsitesi.com",
                            Telefon = "+90 212 555 0123"
                        });
                });

            modelBuilder.Entity("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "İstanbul'un en güzel yerlerini keşfedin...",
                            Baslik = "İstanbul'da Gezilecek Yerler",
                            BlogImage = "istanbul.jpg",
                            Tarih = new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            Aciklama = "Kapadokya'da unutulmaz bir balon turu deneyimi...",
                            Baslik = "Kapadokya Balon Turu",
                            BlogImage = "kapadokya.jpg",
                            Tarih = new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.Hakkimizda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hakkimizdas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "Türkiye'nin en güzel yerlerini keşfetmeniz için buradayız. Deneyimli rehberlerimizle unutulmaz anılar biriktirin.",
                            FotoUrl = "hakkimizda.jpg"
                        });
                });

            modelBuilder.Entity("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.iletisim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("iletisims");
                });

            modelBuilder.Entity("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.Yorumlar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yorum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BlogID");

                    b.ToTable("Yorumlars");
                });

            modelBuilder.Entity("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.Yorumlar", b =>
                {
                    b.HasOne("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.Blog", "Blog")
                        .WithMany("Yorumlars")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("MvcSeyehatSitesi_20._10._2025.Models.Siniflar.Blog", b =>
                {
                    b.Navigation("Yorumlars");
                });
#pragma warning restore 612, 618
        }
    }
}


