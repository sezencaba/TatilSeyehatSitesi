using Microsoft.AspNetCore.Mvc;
using MvcSeyehatSitesi_20._10._2025.Models.Siniflar;

namespace MvcSeyehatSitesi_20._10._2025.Controllers
{
    public class DefaultController : Controller
    {

        private readonly Context c;

        public DefaultController(Context context)
        {
            c = context;
        }

        public IActionResult Index()
        {
            var degerler = c.Blogs
                .OrderByDescending(b => b.Tarih)
                .Take(10)
                .ToList();

            return View(degerler);
        }

        public IActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {

            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();

            return PartialView(degerler);  

        }

        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.ID==1).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger);  
        }

        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();    
            return PartialView(deger);
        }



    }
}
