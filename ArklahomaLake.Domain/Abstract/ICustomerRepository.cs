using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArklahomaLake.Domain.Entities;

namespace ArklahomaLake.Domain.Abstract
{
 public interface ICustomerRepository
    {
        IEnumerable<Customers> Customers { get; }

        void SaveCustomer(Customers customers);

        Customers DeleteCustomers(int customerID);
    }
}
