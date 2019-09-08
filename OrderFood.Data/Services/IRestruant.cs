using OrderFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Data.Services
{
    public interface IRestruant
    {
        IEnumerable<Restruant> GetAll();

        Restruant Get(int id);
        void Add(Restruant restruant);
        void Update(Restruant restruant);
        void Delete(int id);
    }
}
