﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FinalApp.Models;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;

namespace FinalApp.Controllers
{
    public class ProductController : Controller
    {
        static readonly ConnectionMultiplexer muxer = ConnectionMultiplexer.Connect("127.0.0.1:6379,password=");
        IDatabase bag = muxer.GetDatabase(1);

        public IActionResult Index()
        {
            Product prd = new Product();
            prd.Urun = Request.Query["Urun"].ToString().ToUpper();
            bool varmi = false;
            foreach (var item in bag.HashGetAll("Urunler"))
            {
                string[] veri = item.Value.ToString().Split(';');
                if (item.Name == Request.Query["Urun"])
                {
                    prd.Kategori = veri[0];
                    prd.Fiyat = string.Format("{0:C0}", double.Parse(veri[1]));
                    prd.Indirim = veri[2];
                    double indirim = double.Parse(veri[1]) - ((double.Parse(veri[1]) * double.Parse(veri[2])) / 100);
                    prd.IndirimliFiyat = string.Format("{0:C0}", indirim);
                    string urunresim = null;
                    urunresim = "~/Images/" + item.Name + "/1.jpg";
                    prd.Resim = urunresim;
                    varmi = true;
                }
            }
            if (prd.Urun != "" && varmi == true) return View(prd);
            else return View("Index1");
        }



        public IActionResult Index1()
        {
            return View();
        }

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
                        products.Add(new Product { Kategori = veri[0], Urun = item.Name, Fiyat = string.Format("{0:C0}", double.Parse(veri[1])), Resim = veri[3] });
                }
                else
                {
                    ViewData["Heading"] = "Tüm Ürünler";
                    products.Add(new Product { Kategori = veri[0], Urun = item.Name, Fiyat = string.Format("{0:C0}", double.Parse(veri[1])), Resim = veri[3] });
                }
            }
            return View(products);
        }
    }
}
