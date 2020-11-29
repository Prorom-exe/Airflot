using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airflot
{
    class RepositoryFlights : IFlights
    {
        private readonly AppDbContext db;
        public RepositoryFlights(AppDbContext appDbContext)
        {
            db = appDbContext;
        }
        public IEnumerable<Flights> AllFlights => db.Flights;

        public void Add(Flights fly)
        {
            db.Flights.Add(fly);
            db.SaveChanges();
        }

        public IEnumerable<Flights> Seacrh(string _seacrh1, string _seacrh2)
        {
            IEnumerable<Flights> flights = db.Flights.Where(p => p.Arrival.Contains(_seacrh1) || p.FlyId.Equals(_seacrh2));
            return flights;
        }
    }
}
