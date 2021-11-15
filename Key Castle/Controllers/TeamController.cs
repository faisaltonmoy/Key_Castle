using Key_Castle_DataAccess.Repo.IRepository;
using Key_Castle_Models;
using Key_Castle_Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle.Controllers
{
   
    public class Team : Controller
    {
      
        public IActionResult TeamCon()
        {
            

            //foreach (var obj in objList)
            //{
            //    obj.Pr = _prodRepo.FirstOrDefault(u => u.Category_id == obj.Product_id);
            //};

            return View();
        }

    }   
}
