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
        public Guid UserId { get; set; }
        public int TotalPrice { get; set; }
        public int Count { get; set; }
    }
}
