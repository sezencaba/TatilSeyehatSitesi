using Microsoft.AspNetCore.Mvc;
using MvcSeyehatSitesi_20._10._2025.Models.Siniflar;

namespace MvcSeyehatSitesi_20._10._2025.Controllers
{
    public class IletisimController : Controller
    {

        private readonly Context c;

        public IletisimController(Context context)
        {
            c = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult IletisimGonder(iletisim i)
        {
            if (ModelState.IsValid)
            {
                c.iletisims.Add(i);
                c.SaveChanges();
                TempData["ContactSuccess"] = "Mesajınız başarıyla gönderildi! Teşekkür ederiz.";
                return RedirectToAction("Index");
            }
            
            TempData["ContactError"] = "Lütfen tüm alanları doğru şekilde doldurun.";
            return View("Index", i);
        } 

    }
}
