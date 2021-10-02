﻿using Key_Castle_Models;
using Key_Castle_Models.ViewModels;
using Key_Castle_Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_DataAccess.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Products = _db.Product.Include(u => u.Category),
                Categories = _db.Category
            };
            return View(homeVM);
        }

        public IActionResult Details(int id)
        {
            List<Cart> shoppingCartList = new List<Cart>();
            if (HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<Cart>>(WC.SessionCart);
            }

            DetailsVM DetailsVM = new DetailsVM()
            {
                Product = _db.Product.Include(u => u.Category)
                .Where(u => u.Product_id == id).FirstOrDefault(),
                ExistsInCart = false
            };

            foreach (var item in shoppingCartList)
            {
                if (item.Cart_id == id)
                {
                    DetailsVM.ExistsInCart = true;
                }
            }

            return View(DetailsVM);
        }

        [HttpPost, ActionName("Details")]
        public IActionResult DetailsPost(int id)
        {
            List<Cart> shoppingCartList = new List<Cart>();
            if (HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<Cart>>(WC.SessionCart);
            }

            shoppingCartList.Add(new Cart { Cart_id = id });
            HttpContext.Session.Set(WC.SessionCart, shoppingCartList);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveFromCart(int id)
        {
            List<Cart> shoppingCartList = new List<Cart>();
            if (HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<Cart>>(WC.SessionCart);
            }

            var itemToRemove = shoppingCartList.SingleOrDefault(r => r.Cart_id == id);
            if (itemToRemove != null)
            {
                shoppingCartList.Remove(itemToRemove);
            }

            HttpContext.Session.Set(WC.SessionCart, shoppingCartList);
            return RedirectToAction(nameof(Index));
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
