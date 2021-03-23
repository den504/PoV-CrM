using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoV.Models
{
    public class Risk
    {
        public int RiskId { get; set; } //id

        public string RiskType { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
