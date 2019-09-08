using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderFood.Data.Models;
using System.Data.Entity;

namespace OrderFood.Data.Services
{
    public class SqlRestruantData : IRestruant
    {
        private readonly OrderFoodDbContex db;

        public SqlRestruantData(OrderFoodDbContex db1)
        {
            this.db = db1;
        }
        public void Add(Restruant restruant)
        {
            db.Restruants.Add(restruant);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var restruant = db.Restruants.Find(id);
            db.Restruants.Remove(restruant);
            db.SaveChanges();
        }

        public Restruant Get(int id)
        {
          return  db.Restruants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restruant> GetAll()
        {
            return from m in db.Restruants
                   orderby m.Name
                   select m;
        }

        public void Update(Restruant restruant)
        {
            //Optimistic concuranci
            var entry = db.Entry(restruant);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
