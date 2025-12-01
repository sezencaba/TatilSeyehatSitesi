# 🗺️ Tatil & Seyahat Blog Sitesi

ASP.NET Core MVC 8.0 ile geliştirilmiş dinamik bir seyahat/tatil blog web sitesi. Gezip görülen yerler hakkında blog yazıları paylaşmak için tasarlanmıştır.

## ✨ Özellikler

### 🎯 Ana Özellikler
- **Blog Yönetimi**: Blog yazıları ekleme, düzenleme, silme ve listeleme
- **Yorum Sistemi**: Blog yazılarına yorum yapma ve yorum yönetimi
- **İletişim Formu**: Ziyaretçilerden mesaj alma ve yönetme
- **Hakkımızda Sayfası**: Site hakkında bilgi güncelleme
- **Admin Paneli**: Cookie tabanlı kimlik doğrulama ile güvenli admin paneli
- **Sayfalama**: Blog listesinde sayfa başına 6 blog gösterimi
- **Responsive Tasarım**: Mobil ve tablet uyumlu arayüz
- **Otomatik Migration**: Uygulama başlatıldığında veritabanı otomatik olarak oluşturulur/güncellenir

### 🎨 Teknik Özellikler
- **Framework**: ASP.NET Core MVC 8.0
- **Veritabanı**: SQL Server (Entity Framework Core Code First)
- **Kimlik Doğrulama**: Cookie Authentication
- **Frontend**: Bootstrap, jQuery, Responsive Design
- **Mimari**: MVC (Model-View-Controller) Pattern
- **ORM**: Entity Framework Core 8.0

## 🚀 Kurulum

### Gereksinimler
- .NET 8.0 SDK veya üzeri
- SQL Server (LocalDB, SQL Server Express veya SQL Server)
- Visual Studio 2022 veya Visual Studio Code (opsiyonel)
- Entity Framework Core Tools (migration için)

### Adımlar

1. **Projeyi klonlayın veya indirin**
   ```bash
   git clone <repository-url>
   cd TatilSeyehatSitesi
   ```

2. **Veritabanı bağlantı ayarlarını yapın**
   
   `appsettings.json` dosyasındaki connection string'i kendi SQL Server bilgilerinize göre güncelleyin:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TravelDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False"
     }
   }
   ```
   
   **Not**: LocalDB kullanıyorsanız `(localdb)\\mssqllocaldb` kullanabilirsiniz. Kendi SQL Server sunucunuz varsa `Server=SUNUCU_ADI;Database=TravelDb;...` formatını kullanın.

3. **NuGet paketlerini yükleyin**
   ```bash
   dotnet restore
   ```

4. **Projeyi çalıştırın**
   ```bash
   dotnet run
   ```
   
   Proje başlatıldığında veritabanı otomatik olarak oluşturulacak ve migration'lar uygulanacaktır.
   
   Tarayıcınızda `https://localhost:5001` veya `http://localhost:5000` adresine gidin (port numarası terminal çıktısında belirtilir).

### 🔧 Manuel Migration (Opsiyonel)

Eğer manuel olarak migration çalıştırmak isterseniz:
```bash
dotnet ef database update
```

## 👤 Varsayılan Admin Bilgileri

- **Kullanıcı Adı**: `admin`
- **Şifre**: `123456`

⚠️ **ÖNEMLİ GÜVENLİK UYARISI**: İlk girişten sonra admin şifresini mutlaka değiştirin! Üretim ortamında kesinlikle varsayılan şifreyi kullanmayın.

## 📁 Proje Yapısı

```
TatilSeyehatSitesi/
├── Controllers/          # Controller sınıfları
│   ├── AdminController.cs      # Admin paneli işlemleri
│   ├── BlogsController.cs      # Blog yönetimi
│   ├── DefaultController.cs    # Ana sayfa ve hakkımızda
│   ├── GirisYapController.cs   # Kimlik doğrulama
│   ├── HomeController.cs       # Hata sayfaları
│   ├── IletisimController.cs   # İletişim formu
│   └── AboutController.cs      # Hakkımızda sayfası
├── Models/               # Veri modelleri ve DbContext
│   ├── Siniflar/
│   │   ├── Blog.cs            # Blog modeli
│   │   ├── Yorumlar.cs        # Yorum modeli
│   │   ├── BlogYorum.cs       # Blog-Yorum ilişki modeli
│   │   ├── iletisim.cs        # İletişim mesaj modeli
│   │   ├── Admin.cs           # Admin kullanıcı modeli
│   │   ├── Hakkimizda.cs      # Hakkımızda içerik modeli
│   │   ├── AnaSayfa.cs        # Ana sayfa içerik modeli
│   │   ├── AdresBlog.cs       # İletişim adresi modeli
│   │   └── Context.cs         # Entity Framework DbContext
│   └── ErrorViewModel.cs
├── Views/                # Razor view dosyaları
│   ├── Admin/            # Admin paneli view'ları
│   ├── Blogs/            # Blog listesi ve detay sayfaları
│   ├── Default/          # Ana sayfa partial view'ları
│   ├── GirisYap/         # Login ve erişim engellendi sayfaları
│   ├── Iletisim/         # İletişim formu
│   └── Shared/           # Layout ve shared view'lar
├── Migrations/           # Entity Framework migrations
├── wwwroot/              # Statik dosyalar
│   ├── css/              # Özel CSS dosyaları
│   ├── js/               # JavaScript dosyaları
│   ├── lib/              # Bootstrap, jQuery vb. kütüphaneler
│   └── web/              # Tema dosyaları (W3Layouts)
├── Program.cs            # Uygulama başlangıç ve yapılandırma
└── appsettings.json      # Uygulama ayarları ve connection string
```

## 🗄️ Veritabanı Modelleri

- **Blog**: Blog yazıları (Başlık, içerik, tarih, görsel vb.)
- **Yorumlar**: Blog yorumları (Kullanıcı adı, mail, yorum, onay durumu)
- **BlogYorum**: Blog ve yorum ilişki tablosu
- **iletisim**: İletişim mesajları (Ad, mail, konu, mesaj, okundu durumu)
- **Admin**: Admin kullanıcıları (Kullanıcı adı, şifre)
- **Hakkimizda**: Hakkımızda sayfası içeriği
- **AnaSayfa**: Ana sayfa içeriği
- **AdresBlog**: İletişim adresi ve iletişim bilgileri

## 🎯 Kullanım

### Admin Paneli
1. `/GirisYap/Login` adresine gidin
2. Varsayılan admin bilgileriyle giriş yapın (`admin` / `123456`)
3. Admin panelinden (`/Admin/Index`) şunları yapabilirsiniz:
   - ✅ Blog ekleme, düzenleme ve silme
   - ✅ Yorumları görüntüleme, onaylama ve silme
   - ✅ İletişim mesajlarını görüntüleme ve yönetme
   - ✅ Hakkımızda sayfasını güncelleme
   - ✅ Blog detaylarını görüntüleme ve düzenleme

### Blog Yönetimi
- **Blog Listesi**: `/Blogs/Index` - Tüm blogları görüntüleyin
- **Blog Detay**: `/Blogs/BlogDetay/{id}` - Belirli bir blogun detay sayfası
- **Sayfalama**: Her sayfada 6 blog gösterilir, sayfalama ile diğer bloglara geçebilirsiniz
- **Yorum Yapma**: Blog detay sayfasından ziyaretçiler yorum yapabilir

### Ziyaretçi Özellikleri
- Ana sayfada blog özetleri görüntülenir
- Blog detay sayfalarında yorum yapılabilir
- İletişim formu ile mesaj gönderilebilir
- Hakkımızda sayfasından site hakkında bilgi alınabilir

## 🛠️ Geliştirme

### Yeni Migration Oluşturma
Veritabanı modelinde değişiklik yaptıktan sonra yeni migration oluşturun:
```bash
dotnet ef migrations add MigrationAdi
```

### Veritabanını Güncelleme
Migration'ları veritabanına uygulayın:
```bash
dotnet ef database update
```

**Not**: Proje başlatıldığında migration'lar otomatik olarak uygulanır (`Program.cs` içinde `db.Database.Migrate()`).

### Geliştirme Ortamı
Development ortamında çalıştırmak için:
```bash
dotnet watch run
```
Bu komut değişiklikleri otomatik olarak algılar ve uygulamayı yeniden başlatır.

## 📦 Kullanılan Paketler

- `Microsoft.EntityFrameworkCore` (8.0.0)
- `Microsoft.EntityFrameworkCore.SqlServer` (8.0.0)
- `Microsoft.EntityFrameworkCore.Tools` (8.0.0)
- `Microsoft.EntityFrameworkCore.Design` (8.0.0)
- `Microsoft.VisualStudio.Web.CodeGeneration.Design` (8.0.7)

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. 

**Tema**: Tema dosyaları W3Layouts'tan alınmıştır. (Lisans: `wwwroot/web/w3layouts-License.txt`)

## 👨‍💻 Geliştirici

Proje 2024 yılında başlatılmıştır.

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! Katkıda bulunmak için:

1. Bu repository'yi fork edin
2. Feature branch oluşturun (`git checkout -b feature/YeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik: Açıklama'`)
4. Branch'inizi push edin (`git push origin feature/YeniOzellik`)
5. Pull Request açın

## 📧 İletişim & Destek

- Sorularınız için issue açabilirsiniz
- Hata bildirimi için issue açabilirsiniz
- Önerileriniz için issue açabilirsiniz

## 🐛 Bilinen Sorunlar

Şu anda bilinen bir sorun bulunmamaktadır. Eğer bir sorun fark ederseniz lütfen issue açın.

---

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!

