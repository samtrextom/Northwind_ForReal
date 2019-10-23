using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public class Contact
    {
        public int id { get; set; }
        [RequiredAttribute]
        public String name { get; set; }
        [EmailAddressAttribute]
        public String email { get; set; }
    }
}
