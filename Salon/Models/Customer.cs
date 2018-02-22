using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Neighborhood { get; set; }
    }
}
