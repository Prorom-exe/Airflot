using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airflot
{
    interface IFlights
    {
        IEnumerable<Flights> AllFlights { get; }

         void Add(Flights fly);
        IEnumerable<Flights> Seacrh(string _search1, string _search2);
    }
}
