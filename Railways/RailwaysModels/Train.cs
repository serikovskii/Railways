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
        public string Path { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
    }
}
