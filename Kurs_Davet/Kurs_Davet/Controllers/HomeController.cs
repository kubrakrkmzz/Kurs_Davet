using Kurs_Davet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Kurs_Davet.Controllers
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

        [HttpGet] //formun yeniden yüklenmesi sağlanır
        public ViewResult BilgiFormu() //ViewResult ile Views klasöründe Controller adıyla Method ismiyle .cshtml uzantılı dosya arayacaktır.
        {
            return View();
        }

        [HttpPost] //Tarayıcı tarafından post isteği gönderilerek verilerin sunucuya iletilmesi sağlanır
        public ViewResult BilgiFormu(Bilgiler KatilimciCevabi)
        {

            Repository.CevapEkle(KatilimciCevabi);

            return View("Tesekkurler", KatilimciCevabi);
        }


        public ViewResult CevaplariListele()
        {
            //Repositorydeki Cevaplardaki katilimi true olanları döndür. x=Repository.Bilgiler
            return View(Repository.Bilgiler.Where(x => x.Katilim == true));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
