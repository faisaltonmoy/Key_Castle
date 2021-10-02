using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle.Controllers
{
    public class BuyerProfileController : Controller
    {
        private readonly Key_Castle_DataAccess.ApplicationDbContext _db;
        public BuyerProfileController(Key_Castle_DataAccess.ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult BuyerProfileCon()
        {
            IEnumerable<Key_Castle_Models.Buyer_Profile> objList = _db.Buyer_Profile;

            return View(objList);
        }
    }
}
