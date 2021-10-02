using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle.Controllers
{
    public class SellerProfileController : Controller
    {
        private readonly Key_Castle_DataAccess.ApplicationDbContext _db;
        public SellerProfileController(Key_Castle_DataAccess.ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult SellerProfileCon()
        {
            IEnumerable<Key_Castle_Models.Seller_Profile> objList = _db.Seller_Profile;

            return View(objList);
        }
    }
}
