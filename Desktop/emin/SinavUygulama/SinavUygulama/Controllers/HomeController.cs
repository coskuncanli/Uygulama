using Microsoft.AspNetCore.Mvc;
using SinavUygulama.Models;
using System.Diagnostics;

namespace SinavUygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kayit(Uye uye)
        {
            return Content($"Adı: {uye.Ad}, Soyadı: {uye.Soyad}, Doğum Tarihi: {uye.DogumTarihi}, Adresi: {uye.Adres} ");
        }

        public IActionResult Islem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Islem(double s1, double s2, int islem)
        {
            double sonuc = 0;
            switch (islem)
            {
                case 0: sonuc = s1 + s2; break;
                case 1: sonuc = s1 - s2; break;
                case 2: sonuc = s1 * s2; break;
                case 3: sonuc = s1 / s2; break;
            }

            return Content($"İşlem Sonucu: {sonuc}");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}