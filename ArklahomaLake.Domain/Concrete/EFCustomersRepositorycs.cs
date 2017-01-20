using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArklahomaLake.Domain.Abstract;
using ArklahomaLake.Domain.Entities;
namespace ArklahomaLake.Domain.Concrete
{
  public class EFCustomersRepositorycs : ICustomerRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Customers> Customers
        {
            get { return context.Customers; }
        }

        public void SaveCustomer(Customers customers)
        {
            if (customers.CustomerID == 0)
            {
                context.Customers.Add(customers);

            }
            else
            {
                Customers dbEntry = context.Customers.Find(customers.CustomerID);

                if (dbEntry != null)
                {
                    dbEntry.CustomerName = customers.CustomerName;
                    dbEntry.Address = customers.Address;
                    dbEntry.City = customers.City;
                    dbEntry.State = customers.State;
                    dbEntry.ZipCode = customers.ZipCode;
                    dbEntry.PhoneNumber = customers.PhoneNumber;
                    dbEntry.AddressUrl = customers.AddressUrl;

                }
            }

            context.SaveChanges();
        }

        public Customers DeleteCustomers(int customerID)
        {
            Customers dbEntry = context.Customers.Find(customerID);
            if (dbEntry != null)
            {
                context.Customers.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
