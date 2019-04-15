using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwaysModels
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Inn { get; set; }
        public Guid TicketId { get; set; }
    }
}
