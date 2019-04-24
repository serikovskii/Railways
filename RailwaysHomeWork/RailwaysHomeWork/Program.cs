using RailwaysHomeWork.DataAccess;
using RailwaysHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwaysHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User
                {
                    FullName = "Azat", Inn = "999333999333", NumberPhone = "+77019997788"
                },
                new User
                {
                    FullName = "Askar", Inn = "999333999777", NumberPhone = "+77002226655"
                }
            };

            var trains = new List<Train>
            {
                new Train
                {
                    Name = "Talgo77", Arrival = "Astana", Departure = "Almaty", Capacity = 100, Price = 12000,
                    DateArrival = new DateTime(2019, 04, 20, 17, 50, 00), 
                    DateDeparture = new DateTime(2019, 04, 21, 08, 40, 00)
                },
                
                new Train
                {
                    Name = "Talgo99", Arrival = "Astana", Departure = "Petropavl", Capacity = 90, Price = 9000,
                    DateArrival = new DateTime(2019, 04, 20, 19, 20, 00), 
                    DateDeparture = new DateTime(2019, 04, 21, 12, 40, 00)
                },

                new Train
                {
                    Name = "Talgo55", Arrival = "Astana", Departure = "Semey", Capacity = 120, Price = 11000,
                    DateArrival = new DateTime(2019, 04, 20, 16, 50, 00),
                    DateDeparture = new DateTime(2019, 04, 21, 05, 40, 00)
                },
                
                new Train
                {
                    Name = "Talgo33", Arrival = "Astana", Departure = "Ural", Capacity = 80, Price = 7000,
                    DateArrival = new DateTime(2019, 04, 20, 22, 20, 00), 
                    DateDeparture =  new DateTime(2019, 04, 21, 09, 40, 00)
                }
            };

            using (var context = new LibraryContext())
            {
                context.Users.AddRange(users);
                context.Trains.AddRange(trains);
                context.SaveChanges();
            }

        }
    }
}
