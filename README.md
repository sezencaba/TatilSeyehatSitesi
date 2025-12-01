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

### 🎨 Teknik Özellikler
- **Framework**: ASP.NET Core MVC 8.0
- **Veritabanı**: SQL Server (Entity Framework Core Code First)
- **Kimlik Doğrulama**: Cookie Authentication
- **Frontend**: Bootstrap, jQuery, Responsive Design
- **Mimari**: MVC (Model-View-Controller) Pattern

## 🚀 Kurulum

### Gereksinimler
- .NET 8.0 SDK
- SQL Server (LocalDB veya SQL Server Express)
- Visual Studio 2022 veya Visual Studio Code

### Adımlar

1. **Projeyi klonlayın**
   ```bash
   git clone https://github.com/kullaniciadi/MvcSeyehatSitesi.git
   cd MvcSeyehatSitesi_20.10.2025
   ```

2. **Veritabanı bağlantı ayarlarını yapın**
   
   `appsettings.json` dosyasındaki connection string'i kendi SQL Server bilgilerinize göre güncelleyin:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=SUNUCU_ADI;Database=TravelDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False"
     }
   }
   ```

3. **NuGet paketlerini yükleyin**
   ```bash
   dotnet restore
   ```

4. **Veritabanı migration'larını çalıştırın**
   ```bash
   dotnet ef database update
   ```
   
   Veya projeyi çalıştırdığınızda otomatik olarak migration'lar uygulanacaktır.

5. **Projeyi çalıştırın**
   ```bash
   dotnet run
   ```
   
   Tarayıcınızda `https://localhost:5001` veya `http://localhost:5000` adresine gidin.

## 👤 Varsayılan Admin Bilgileri

- **Kullanıcı Adı**: `admin`
- **Şifre**: `123456`

⚠️ **Güvenlik Uyarısı**: İlk girişten sonra admin şifresini mutlaka değiştirin!

## 📁 Proje Yapısı

```
MvcSeyehatSitesi_20.10.2025/
├── Controllers/          # Controller sınıfları
│   ├── AdminController.cs
│   ├── BlogsController.cs
│   ├── DefaultController.cs
│   └── ...
├── Models/               # Veri modelleri
│   └── Siniflar/
│       ├── Blog.cs
│       ├── Yorumlar.cs
│       ├── iletisim.cs
│       └── ...
├── Views/                # Razor view dosyaları
│   ├── Admin/
│   ├── Blogs/
│   ├── Default/
│   └── ...
├── Migrations/           # Entity Framework migrations
├── wwwroot/             # Statik dosyalar (CSS, JS, images)
└── Program.cs           # Uygulama başlangıç dosyası
```

## 🗄️ Veritabanı Modelleri

- **Blog**: Blog yazıları
- **Yorumlar**: Blog yorumları
- **iletisim**: İletişim mesajları
- **Admin**: Admin kullanıcıları
- **Hakkimizda**: Hakkımızda bilgileri
- **AdresBlog**: İletişim bilgileri

## 🎯 Kullanım

### Admin Paneli
1. `/GirisYap/Login` adresine gidin
2. Varsayılan admin bilgileriyle giriş yapın
3. Admin panelinden:
   - Blog ekleyebilir, düzenleyebilir, silebilirsiniz
   - Yorumları yönetebilirsiniz
   - İletişim mesajlarını görüntüleyebilirsiniz
   - Hakkımızda sayfasını güncelleyebilirsiniz

### Blog Yönetimi
- Blog listesi: `/Blogs/Index`
- Blog detay: `/Blogs/BlogDetay/{id}`
- Her sayfada 6 blog gösterilir
- Sayfalama ile diğer bloglara geçebilirsiniz

## 🛠️ Geliştirme

### Yeni Migration Oluşturma
```bash
dotnet ef migrations add MigrationAdi
```

### Veritabanını Güncelleme
```bash
dotnet ef database update
```

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. Tema dosyaları W3Layouts'tan alınmıştır.

## 👨‍💻 Geliştirici

Proje Kasım 2025 tarihinde başlatılmıştır.

## 🤝 Katkıda Bulunma

1. Fork edin
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Push edin (`git push origin feature/AmazingFeature`)
5. Pull Request açın

## 📧 İletişim

Sorularınız için issue açabilirsiniz.

---

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!

