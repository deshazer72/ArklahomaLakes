using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArklahomaLake.Domain.Entities;

namespace ArklahomaLakes.WebUi.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}