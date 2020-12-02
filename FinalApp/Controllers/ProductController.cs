using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalApp.Models;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;

namespace FinalApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        static readonly ConnectionMultiplexer muxer = ConnectionMultiplexer.Connect("127.0.0.1:6379,password=");
        IDatabase bag = muxer.GetDatabase(1);


        public IActionResult ShowAll()
        {
            string test = Request.Query["Kategori"];

            ViewData["Heading"] = test;
            var products = new List<Product>();
            foreach (var item in bag.HashGetAll("Urunler"))
            {
                string[] veri = item.Value.ToString().Split(';');
                if (test != null)
                {
                    if (test == veri[0])
                        products.Add(new Product { Kategori = veri[0], Urun = item.Name, Fiyat = double.Parse(veri[1]), Resim = veri[2] });
                }
                else
                {
                    ViewData["Heading"] = "Tüm Ürünler";
                    products.Add(new Product { Kategori = veri[0], Urun = item.Name, Fiyat = double.Parse(veri[1]), Resim = veri[2] });
                }
            }
            return View(products);
        }
    }
}
