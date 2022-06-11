using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hairsalon.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int ContactNo { get; set; }
    }
}
