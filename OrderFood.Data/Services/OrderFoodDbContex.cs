using OrderFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderFood.Data.Services
{
    public class OrderFoodDbContex:DbContext
    {
        public DbSet<Restruant> Restruants { get; set; }
    }
}
