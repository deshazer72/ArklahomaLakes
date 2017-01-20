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
    public class CustomersController : Controller
    {

        private ICustomerRepository repository; 

        public CustomersController(ICustomerRepository customerRepository)
        {
            this.repository = customerRepository; 
        }
        // GET: Customers
        public ActionResult Index()
        {
            CustomerListViewcs model = new CustomerListViewcs
            {
                Customers = repository.Customers
               
            };
            return View(model);
        }

       
    }
}