using Key_Castle_Models;
using Key_Castle_Models.ViewModels;
using Key_Castle_Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Key_Castle_DataAccess.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        [BindProperty]
        public ProductUserVM ProductUserVM { get; set; }

        public CartController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult CartCon()
        {

            List<Cart> shoppingCartList = new List<Cart>();
            if (HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<Cart>>(WC.SessionCart);
            }

            List<int> prodInCart = shoppingCartList.Select(i => i.Cart_id).ToList();
            IEnumerable<Product> prodList = _db.Product.Where(u => prodInCart.Contains(u.Product_id));

            return View(prodList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("CartCon")]
        public IActionResult IndexPost()
        {

            return RedirectToAction(nameof(Summary));
        }


        public IActionResult Summary()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //var userId = User.FindFirstValue(ClaimTypes.Name);

            List<Cart> shoppingCartList = new List<Cart>();
            if (HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart).Count() > 0)
            {
                //session exsits
                shoppingCartList = HttpContext.Session.Get<List<Cart>>(WC.SessionCart);
            }

            List<int> prodInCart = shoppingCartList.Select(i => i.Cart_id).ToList();
            IEnumerable<Product> prodList = _db.Product.Where(u => prodInCart.Contains(u.Product_id));

            ProductUserVM = new ProductUserVM()
            {
                AppUser = _db.AppUser.FirstOrDefault(u => u.Id == claim.Value),
                ProductList = prodList
            };


            return View(ProductUserVM);
        }

        public IActionResult Remove(int id)
        {

            List<Cart> shoppingCartList = new List<Cart>();
            if (HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart).Count() > 0)
            {
                shoppingCartList = HttpContext.Session.Get<List<Cart>>(WC.SessionCart);
            }

            shoppingCartList.Remove(shoppingCartList.FirstOrDefault(u => u.Cart_id == id));
            HttpContext.Session.Set(WC.SessionCart, shoppingCartList);

            return RedirectToAction("CartCon");
        }
    }
}
