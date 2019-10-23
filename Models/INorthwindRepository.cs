using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public interface INorthwindRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Product> Products { get; }
        IQueryable<Discount> Discounts { get; }
        IQueryable<Contact> Contacts { get; }
        IQueryable<Customer> Customers { get; }

        void AddContact(Contact contact);

        void AddCustomer(Customer customer);

        
    }
}
