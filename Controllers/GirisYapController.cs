using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcSeyehatSitesi_20._10._2025.Models.Siniflar;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcSeyehatSitesi_20._10._2025.Controllers
{
    [AllowAnonymous]
    public class GirisYapController : Controller
    {

        private readonly Context _context;

        public GirisYapController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Mesaj = "Kullanıcı adı ve şifre zorunludur.";
                return View();
            }

            var girisYapanKullanici = await _context.Admins
                .FirstOrDefaultAsync(x => x.Kullanici == userName && x.Sifre == password);

            if (girisYapanKullanici == null)
            {
                ViewBag.Mesaj = "Kullanıcı adı veya şifre hatalıdır! Tekrar deneyiniz.";
                return View();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, girisYapanKullanici.ID.ToString()),
                new Claim(ClaimTypes.Name, girisYapanKullanici.Kullanici)
            };

            var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(userIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("Index", "Admin");

        }

        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");

        }

        public IActionResult ErisimEngellendi()
        {
            return View();
        }

    }
}
