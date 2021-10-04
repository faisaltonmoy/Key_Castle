using Key_Castle_DataAccess.Repo;
using Key_Castle_DataAccess.Repo.IRepository;
using Key_Castle_Models;
using Key_Castle_Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Castle.Controllers
{
    public class InquiryController : Controller
    {
        private readonly IInquiryHeaderRepository _inqHRepo;
        private readonly IInquiryDetailRepository _inqDRepo;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IEmailSender _emailSender;

        [BindProperty]
        public InquiryVM InquiryVM { get; set; }

        public InquiryController(IInquiryDetailRepository inqDRepo,
            IInquiryHeaderRepository inqHRepo, IWebHostEnvironment webHostEnvironment, IEmailSender emailSender)
        {
            _inqDRepo = inqDRepo;
            _inqHRepo = inqHRepo;
            _webHostEnvironment = webHostEnvironment;
            _emailSender = emailSender;
        }

        public IActionResult InquiryCon()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            InquiryVM = new InquiryVM()
            {
                InquiryHeader = _inqHRepo.FirstOrDefault(u => u.Id == id),
                InquiryDetail = _inqDRepo.GetAll(u => u.InquiryHeaderId == id, includeProperties: "Product")


            };
            return View(InquiryVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Details")]
        public IActionResult DetailsPost(ProductUserVM ProductUserVM)
        {

            return RedirectToAction(nameof(InquiryConfirmation));
        }

        public IActionResult InquiryConfirmation()
        {
            //HttpContext.Session.Clear();
            return View();
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetInquiryList()
        {
            return Json(new { data = _inqHRepo.GetAll() });
        }

        #endregion
    }
}
