using Key_Castle_DataAccess.Repo.IRepository;
using Key_Castle_Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle.Controllers
{
    [Authorize(Roles = WC.AdminRole)]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _catRepo;
        public CategoryController(ICategoryRepository catRepo)
        {
            _catRepo = catRepo;
        }
        public IActionResult CategoryCon()
        {
            IEnumerable<Key_Castle_Models.Category> objList = (IEnumerable<Key_Castle_Models.Category>)_catRepo.GetAll();

            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Key_Castle_Models.Category obj)
        {
            if(ModelState.IsValid)
            {
                _catRepo.Add(obj);
                _catRepo.Save();

                return RedirectToAction("CategoryCon");
            }
            return View(obj);
            
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _catRepo.Find(id.GetValueOrDefault());
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Key_Castle_Models.Category obj)
        {
            if (ModelState.IsValid)
            {
                _catRepo.Update(obj);
                _catRepo.Save();

                return RedirectToAction("CategoryCon");
            }
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _catRepo.Find(id.GetValueOrDefault());
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(Key_Castle_Models.Category obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
                _catRepo.Remove(obj);
                _catRepo.Save();

                return RedirectToAction("CategoryCon");
        }
    }
}
