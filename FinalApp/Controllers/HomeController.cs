using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalApp.Models;
using StackExchange.Redis;
using System.Collections;
using Microsoft.Extensions.Hosting.Internal;
using System.IO;

namespace FinalApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public static string userName = "Ziyaretçi";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        static readonly ConnectionMultiplexer muxer = ConnectionMultiplexer.Connect("127.0.0.1:6379,password=");
        IDatabase bag = muxer.GetDatabase(1);
        public static ArrayList kategoriler = new ArrayList();

        public IActionResult Index()
        {

            var products = new List<Product>();
            foreach (var item in bag.HashGetAll("Urunler"))
            {
                string[] veri = item.Value.ToString().Split(';');
                if (!kategoriler.Contains(veri[0]))
                    kategoriler.Add(veri[0]);
                double indirim = double.Parse(veri[1]) - ((double.Parse(veri[1]) * double.Parse(veri[2])) / 100);
                string urunresim = null;
                urunresim = "~/Images/" + item.Name + "/1.jpg";
                products.Add(new Product { Kategori = veri[0], Urun = item.Name, Fiyat = string.Format("{0:C0}", double.Parse(veri[1])), Indirim = veri[2], IndirimliFiyat = string.Format("{0:C0}", indirim), Resim = urunresim });
            }
            return View(products);
        }

        public IActionResult Sepet()
        {
            return View();
        }
        public IActionResult UrunDetay()
        {
            return View();
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
