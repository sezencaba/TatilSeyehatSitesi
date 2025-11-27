using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcSeyehatSitesi_20._10._2025.Models.Siniflar;

namespace MvcSeyehatSitesi_20._10._2025.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        private readonly Context _context;

        public AdminController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var degerler = _context.Blogs.ToList();

            return View(degerler);

        }

        public IActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult YeniBlog(Blog p)
        {

            _context.Blogs.Add(p);
            _context.SaveChanges(); 
            return RedirectToAction("Index");   

        }

        public IActionResult BlogSil(int id)
        {

            var b=_context.Blogs.Find(id);
            _context.Blogs.Remove(b);
            _context.SaveChanges(); 
            return RedirectToAction("Index");

        }

        public IActionResult BlogGetir(int id)
        {

            var blg = _context.Blogs.Find(id);
            return View("BlogGetir", blg);

        }

        public IActionResult BlogGuncelle(Blog b)
        {

            var blg = _context.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult YorumListesi()
        {
            var yorumlar = _context.Yorumlars
                .Include(y => y.Blog)
                .ToList();

            return View(yorumlar);
        }

        public IActionResult YorumSil(int id)
        {

            var b = _context.Yorumlars.Find(id);
            _context.Yorumlars.Remove(b);
            _context.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

        public ActionResult YorumGetir(int id)
        {

            var yorum = _context.Yorumlars.Find(id);
            return View("YorumGetir", yorum);

        }

        public IActionResult YorumGuncelle(Yorumlar y)
        {

            var yorum = _context.Yorumlars.Find(y.ID);
            yorum.KullaniciAdi = y.KullaniciAdi;
            yorum.Mail=y.Mail;
            yorum.Yorum = y.Yorum;  
            _context.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

        public IActionResult IletisimListe()
        {
            var iletisimler = _context.iletisims.ToList();
            return View(iletisimler);
        }

        public IActionResult MesajSil(int id)
        {
            var mesaj = _context.iletisims.Find(id);
            if (mesaj != null)
            {
                _context.iletisims.Remove(mesaj);
                _context.SaveChanges();
            }
            return RedirectToAction("IletisimListe");
        }

        public IActionResult MesajDetay(int id)
        {
            var mesaj = _context.iletisims.Find(id);
            if (mesaj != null)
            {
                // Mesaj detayına bakıldığında okundu olarak işaretle
                mesaj.OkunduMu = true;
                _context.SaveChanges();
            }
            return View(mesaj);
        }

        public IActionResult MesajOkunduDegistir(int id)
        {
            var mesaj = _context.iletisims.Find(id);
            if (mesaj != null)
            {
                // Okundu durumunu tersine çevir
                mesaj.OkunduMu = !mesaj.OkunduMu;
                _context.SaveChanges();
            }
            return RedirectToAction("IletisimListe");
        }

        public IActionResult Hakkimizda()
        {
            // Hakkımızda genelde tek kayıt olduğu için ilk kaydı getir
            var hakkimizda = _context.Hakkimizdas.FirstOrDefault();
            
            // Eğer kayıt yoksa yeni bir kayıt oluştur
            if (hakkimizda == null)
            {
                hakkimizda = new Hakkimizda
                {
                    FotoUrl = "",
                    Aciklama = ""
                };
                _context.Hakkimizdas.Add(hakkimizda);
                _context.SaveChanges();
            }
            
            return View(hakkimizda);
        }

        [HttpPost]
        public IActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var hakkimizda = _context.Hakkimizdas.Find(h.ID);
            if (hakkimizda != null)
            {
                hakkimizda.FotoUrl = h.FotoUrl;
                hakkimizda.Aciklama = h.Aciklama;
                _context.SaveChanges();
                TempData["HakkimizdaSuccess"] = "Hakkımızda bilgileri başarıyla güncellendi!";
            }
            return RedirectToAction("Hakkimizda");
        }

    }
}
