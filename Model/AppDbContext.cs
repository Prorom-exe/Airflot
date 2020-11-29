using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Airflot
{
    class AppDbContext:DbContext
    {
        public AppDbContext() : base("strConn") { }
       public  DbSet<Flights> Flights { get; set; }
    }
}
