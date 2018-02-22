using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Salon.Models
{
    public class CityViewModel
    {
        public List<Customer> customers;
        public SelectList city;
        public string customerCity { get; set; }
    }
}
