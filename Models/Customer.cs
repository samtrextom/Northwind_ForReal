using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [RequiredAttribute]
        public String CompnayName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Region { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        [PhoneAttribute]
        public String Phone { get; set; }
        [PhoneAttribute]
        public String Fax { get; set; }
    }
}
