using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArklahomaLake.Domain.Abstract;
using ArklahomaLake.Domain.Entities;
using ArklahomaLakes.WebUi.Models;

namespace ArklahomaLakes.WebUi.Controllers
{
    public class CartController : Controller
    {
        private IProductsRepository repository;
        private IorderProcessor orderProcessor;
       public CartController(IProductsRepository repo, IorderProcessor proc)
        {
            repository = repo;
            orderProcessor = proc;
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                ReturnUrl = returnUrl,
                Cart = cart
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int productID, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productID); 

            if(product != null)
            {
                cart.AddItem(product, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productID, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productID);

            if(product != null)
            {
                cart.RemoveLine(product);

            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart); 
        }

        public ViewResult Checkout()
        {
            ViewBag.Months = new SelectList(Enumerable.Range(1, 12).Select(x => new SelectListItem()
            {
                Text = x.ToString(),
                Value = x.ToString()
            }), "Value", "Text");
            return View(new ShippingDetails()); 
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                orderProcessor.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }

       
    }
}