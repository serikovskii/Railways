using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwaysHomeWork.Models
{
    public class User : Entity
    {
        public string FullName { get; set; }
        public string Inn { get; set; }
        public string NumberPhone { get; set; }
    }
}
