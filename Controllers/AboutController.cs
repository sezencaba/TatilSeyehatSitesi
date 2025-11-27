using Microsoft.AspNetCore.Mvc;
using MvcSeyehatSitesi_20._10._2025.Models.Siniflar;

namespace MvcSeyehatSitesi_20._10._2025.Controllers
{
    public class AboutController : Controller
    {
        private readonly Context _context;

        public AboutController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var degerler = _context.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
