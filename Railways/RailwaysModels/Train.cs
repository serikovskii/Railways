using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwaysModels
{
    public class Train : Entity
    {
        public string Name { get; set; }
        public string Arrival { get; set; }
        public string Departure { get; set; }
        public virtual DateTime DateArrival { get; set; }
        public virtual DateTime DateDeparture { get; set; }
        public int Capacity { get; set; }
        public int Price { get; set; }
    }
}
