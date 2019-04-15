using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwaysModels
{
    public class Ticket : Entity
    {
        public Guid TrainId { get; set; }
        public int Price { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime DateAndTime { get; set; }

    }
}
