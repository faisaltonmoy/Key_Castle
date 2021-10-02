using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle.Controllers
{
    public class PaymentController : Controller
    {
        private readonly Key_Castle_DataAccess.ApplicationDbContext _db;
        public PaymentController(Key_Castle_DataAccess.ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult PaymentCon()
        {
            IEnumerable<Key_Castle_Models.Payment> objList = _db.Payment;

            return View(objList);
        }
    }
}
