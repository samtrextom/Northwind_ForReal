using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public class EFRepository : INorthwindRepository
    {
        private NorthwindContext context;

        public EFRepository(NorthwindContext northwindContext)
        {
            this.context = northwindContext;
        }

        public IQueryable<Product> Products => context.Products;
        public IQueryable<Category> Categories => context.Categories;
        public IQueryable<Discount> Discounts => context.Discounts;
        public IQueryable<Contact> Contacts => context.Contacts;
        public IQueryable<Customer> Customers => context.Customers;

        public void AddContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
        }

        public void AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
