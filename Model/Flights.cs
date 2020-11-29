using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airflot
{
    class Flights
    {
        public int Id { get; set; }
        
        [DisplayName("Вылет")]
        public string Departure { get; set; }
        
        [DisplayName("Прилет")]
        public string Arrival { get; set; }
        
        [DisplayName("Тип самолета")]
        public string FlyType { get; set; }
        
        [DisplayName("Номер рейса")]
        public string FlyId { get; set; }
        
        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}
