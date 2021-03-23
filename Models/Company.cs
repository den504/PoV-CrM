using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoV.Models
{
    public class Company
    {
        public int CompanyId { get; set; }//id

        public string CompanyName { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
