using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderFood.Data.Models;

namespace OrderFood.Data.Services
{
    public class RestruantsData : IRestruant
    {
        List<Restruant> Restruants;
        public RestruantsData()
        {
            Restruants = new List<Restruant>()
            {
                new Restruant{Id=1,Name="Scott's Pizza",Manue=FoodType.French },
                new Restruant{Id=2,Name="Biriani",Manue=FoodType.Indian },
                new Restruant{Id=3,Name="Momo",Manue=FoodType.Italiyan },
            };
        }

        public Restruant Get(int id)
        {
            return Restruants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restruant> GetAll()
        {
            return Restruants.OrderBy(m => m.Name);
        }

        public void Add(Restruant restruant)
        {
            Restruants.Add(restruant);
            restruant.Id = Restruants.Max(e => e.Id)+1;
        }

        public void Update(Restruant restruant)
        {
            var existing = Get(restruant.Id);
            if(existing.Name!=null)
            {
                existing.Name = restruant.Name;
                existing.Manue = restruant.Manue;
            }
        }

        public void Delete(int id)
        {
            var restrurant = Get(id);
            if (restrurant != null)
            {
                Restruants.Remove(restrurant);
            }
        }
    }
}
