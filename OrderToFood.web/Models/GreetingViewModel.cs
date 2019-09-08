using OrderFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderToFood.web.Models
{
    public class GreetingViewModel
    {
        public string Message { get; set; }
        public string Name { get; set; }
        public IEnumerable<Restruant> Restruants { get; set; }

    }
}