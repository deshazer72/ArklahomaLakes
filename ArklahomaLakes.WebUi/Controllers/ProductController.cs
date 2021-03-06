﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArklahomaLake.Domain.Abstract;
using ArklahomaLake.Domain.Entities;
using ArklahomaLakes.WebUi.Models; 

namespace ArklahomaLakes.WebUi.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public int PageSize = 4;

        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository; 
        }

        public ViewResult List(string category, int page = 1)
        {
            ProductListViewModel model = new ProductListViewModel
            {
                Products = repository.Products
                 .Where(p => category == null || p.Category == category)
                 .OrderBy(p => p.ProductID)
                 .Skip((page - 1) * PageSize)
                 .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                         repository.Products.Count() :
                         repository.Products.Where(p => p.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }

        public FileContentResult GetImage(int productID)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productID); 
            if(product != null)
            {
                return File(product.ImageData, product.ImageMimeTyp); 
            }else
            {
                return null;
            }
        }
    }
}