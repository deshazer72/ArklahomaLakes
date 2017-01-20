using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArklahomaLake.Domain.Abstract;
using ArklahomaLake.Domain.Entities;

namespace ArklahomaLakes.WebUi.Controllers
{
    public class AddCustomerController : Controller
    {
        private ICustomerRepository repository;

        public AddCustomerController(ICustomerRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index()
        {
            return View(repository.Customers);
        }

        public ViewResult Edit(int customerId)
        {
            Customers customers = repository.Customers
                .FirstOrDefault(p => p.CustomerID == customerId);
            return View(customers);
        }

        [HttpPost]
        public ActionResult Edit(Customers customers)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCustomer(customers);
                TempData["message"] = string.Format("{0}  has been saved", customers.CustomerName);
                return RedirectToAction("Index");
            }
            else
            {
                return View(customers);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Customers());
        }
        [HttpPost]
        public ActionResult Delete(int customerId)
        {
            Customers deleteCustomers = repository.DeleteCustomers(customerId);

            if (deleteCustomers != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deleteCustomers.CustomerName);
            }

            return RedirectToAction("Index");
        }
    }
}