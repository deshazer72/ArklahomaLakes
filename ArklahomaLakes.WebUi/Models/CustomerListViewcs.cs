using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArklahomaLake.Domain.Entities; 

namespace ArklahomaLakes.WebUi.Models
{
  public class CustomerListViewcs
    {
        public IEnumerable<Customers> Customers { get; set; }
    }
}
