using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoV.Models
{
    public class Status
    {
        public int StatusId { get; set; } //id

        public string StatusType { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
