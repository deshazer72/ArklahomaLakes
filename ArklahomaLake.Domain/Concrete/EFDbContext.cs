using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArklahomaLake.Domain.Entities;
using System.Data.Entity; 

namespace ArklahomaLake.Domain.Concrete
{
   public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set;  }
        public DbSet<Customers> Customers { get; set; }
        
    }
}
