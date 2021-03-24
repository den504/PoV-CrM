using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoV.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }//id

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string email { get; set; }

        public string contact { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; } //nav prop

        public int RiskId { get; set; }

        public Risk Risk { get; set; } //nav prop

        public int StatusId { get; set; }

        public Status Status { get; set; } //nav prop
    }
}
