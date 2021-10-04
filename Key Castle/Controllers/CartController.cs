using Braintree;
using Key_Castle_DataAccess.Repo;
using Key_Castle_DataAccess.Repo.IRepository;
using Key_Castle_Models;
using Key_Castle_Models.ViewModels;
using Key_Castle_Utility;
using Key_Castle_Utility.BrainTree;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
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
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IEmailSender _emailSender;
        private readonly IAppUserRepository _userRepo;
        private readonly IProductRepository _prodRepo;
        private readonly IInquiryHeaderRepository _inqHRepo;
        private readonly IInquiryDetailRepository _inqDRepo;
        private readonly IBrainTreeGate _brain;

        [BindProperty]
        public ProductUserVM ProductUserVM { get; set; }

        public CartController(IWebHostEnvironment webHostEnvironment, IEmailSender emailSender,
        IAppUserRepository userRepo, IProductRepository prodRepo,
        IInquiryHeaderRepository inqHRepo, IInquiryDetailRepository inqDRepo, IBrainTreeGate brain)
        {
            _webHostEnvironment = webHostEnvironment;
            _emailSender = emailSender;
            _userRepo = userRepo;
            _prodRepo = prodRepo;
            _inqDRepo = inqDRepo;
            _inqHRepo = inqHRepo;
            _brain = brain;
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
            IEnumerable<Product> prodList = _prodRepo.GetAll(u => prodInCart.Contains(u.Product_id));

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

            List<Cart> shoppingCartList = new List<Cart>();
            if (HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<Cart>>(WC.SessionCart).Count() > 0)
            {
                //session exsits
                shoppingCartList = HttpContext.Session.Get<List<Cart>>(WC.SessionCart);
            }

            List<int> prodInCart = shoppingCartList.Select(i => i.Cart_id).ToList();
            IEnumerable<Product> prodList = _prodRepo.GetAll(u => prodInCart.Contains(u.Product_id));

            ProductUserVM = new ProductUserVM()
            {
                AppUser = _userRepo.FirstOrDefault(u => u.Id == claim.Value),
                ProductList = prodList
            };

            var gateway = _brain.GetGateway();
            var clientToken = gateway.ClientToken.Generate();
            ViewBag.ClientToken = clientToken;

            return View(ProductUserVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Summary")]
        public IActionResult SummaryPost(IFormCollection collection, ProductUserVM ProductUserVM)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);


            InquiryHeader inquiryHeader = new InquiryHeader()
            {
                CreatedByUserId = claim.Value,
                FullName = ProductUserVM.AppUser.FullName,
                Email = ProductUserVM.AppUser.Email,
                PhoneNumber = ProductUserVM.AppUser.PhoneNumber,
                OrderDate = DateTime.Now

            };

            _inqHRepo.Add(inquiryHeader);
            _inqHRepo.Save();

            foreach (var prod in ProductUserVM.ProductList)
            {
                InquiryDetail inquiryDetail = new InquiryDetail()
                {
                    InquiryHeaderId = inquiryHeader.Id,
                    ProductId = prod.Product_id
                };
                _inqDRepo.Add(inquiryDetail);

            }
            _inqDRepo.Save();

            string nonceFromTheClient = collection["payment_method_nonce"];

            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal(inquiryHeader.FinalOrderTotal),
                PaymentMethodNonce = nonceFromTheClient,
                OrderId = inquiryHeader.Id.ToString(),
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                }
            };

            //var gateway = _brain.GetGateway();
            //Result<Transaction> result = gateway.Transaction.Sale(request);

            //if (result.Target.ProcessorResponseText == "Approved")
            //{
            //    inquiryHeader.TransactionId = result.Target.Id;
            //    inquiryHeader.OrderStatus = WC.StatusApproved;
            //}
            //else
            //{
            //    inquiryHeader.OrderStatus = WC.StatusCancelled;
            //}
            _inqHRepo.Save();

            return RedirectToAction(nameof(InquiryConfirmation));
        }
        public IActionResult InquiryConfirmation()
        {
            HttpContext.Session.Clear();
            return View();
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
