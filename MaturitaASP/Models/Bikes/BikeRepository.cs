using System.Collections.Generic;
using System.Linq;

namespace MaturitaASP.Models.Bikes
{
    public class BikeRepository
    {
        private MyContext _database = new MyContext();

        /*SELECT * FROM BIKE*/
        public List<Bike> SelectAll()
        {
            return this._database.Bike.ToList();
        }

        public void Insert(Bike bike)
        {
            this._database.Bike.Add(bike);
            this._database.SaveChanges();
        }
    }
}
