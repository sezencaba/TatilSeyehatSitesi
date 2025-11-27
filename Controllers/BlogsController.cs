using Microsoft.AspNetCore.Mvc;
using MvcSeyehatSitesi_20._10._2025.Models.Siniflar;

namespace MvcSeyehatSitesi_20._10._2025.Controllers
{
    public class BlogsController : Controller
    {
        private readonly Context _context;

        public BlogsController(Context context)
        {
            _context = context;
        }

        BlogYorum by = new BlogYorum();

        public IActionResult Index(int? sayfa)
        {
            
            int sayfaNumarasi = sayfa ?? 1;
            int sayfaBoyutu = 6; 
            
            
            int toplamBlogSayisi = _context.Blogs.Count();
            
            
            int toplamSayfa = (int)Math.Ceiling((double)toplamBlogSayisi / sayfaBoyutu);
            
            
            var bloglar = _context.Blogs
                .OrderByDescending(x => x.Tarih) 
                .Skip((sayfaNumarasi - 1) * sayfaBoyutu)
                .Take(sayfaBoyutu)
                .ToList();
            
            by.Deger1 = bloglar;
            by.Deger3 = _context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            
            
            ViewBag.SayfaNumarasi = sayfaNumarasi;
            ViewBag.ToplamSayfa = toplamSayfa;
            ViewBag.SayfaBoyutu = sayfaBoyutu;
            
            return View(by);
        }

        

        public IActionResult BlogDetay(int id)
        {

            by.Deger1=_context.Blogs.Where(x=>x.ID==id).ToList(); 
            
            by.Deger2=_context.Yorumlars.Where(y=>y.BlogID==id).ToList();   

            return View(by);

        }

        [HttpPost]
        public IActionResult YorumYap(Yorumlar y)
        {
            _context.Yorumlars.Add(y);
            _context.SaveChanges();
            return RedirectToAction("BlogDetay", new { id = y.BlogID });
        }

    }
}
