using RailwaysModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railways
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 2;
            var trains = new List<Train>
            {
                new Train
                {
                    Name = "Talgo77", Arrival = "Astana", Departure = "Almaty", Capacity = 100, Price = 12000,
                    DateArrival = new List<DateTime> { new DateTime(2019, 04, 20, 17, 50, 00), new DateTime(2019, 04, 20, 09, 40, 00) }, 
                    DateDeparture = new List<DateTime> { new DateTime(2019, 04, 21, 08, 40, 00), new DateTime(2019, 04, 21, 22, 30, 00) } 
                },
                new Train
                {
                    Name = "Talgo77", Arrival = "Almaty", Departure = "Astana", Capacity = 100, Price = 12000,
                    DateArrival = new List<DateTime> { new DateTime(2019, 04, 20, 17, 50, 00), new DateTime(2019, 04, 20, 09, 40, 00) },
                    DateDeparture = new List<DateTime> { new DateTime(2019, 04, 21, 08, 40, 00), new DateTime(2019, 04, 21, 22, 30, 00) }
                },
                new Train
                {
                    Name = "Talgo99", Arrival = "Astana", Departure = "Petropavl", Capacity = 90, Price = 9000,
                    DateArrival = new List<DateTime> { new DateTime(2019, 04, 20, 19, 20, 00), new DateTime(2019, 04, 20, 06, 15, 00) },
                    DateDeparture = new List<DateTime> { new DateTime(2019, 04, 21, 12, 40, 00), new DateTime(2019, 04, 21, 23, 30, 00) }
                },
                new Train
                {
                    Name = "Talgo99", Arrival = "Petropavl", Departure = "Astana", Capacity = 90, Price = 9000,
                    DateArrival = new List<DateTime> { new DateTime(2019, 04, 20, 19, 20, 00), new DateTime(2019, 04, 20, 06, 15, 00) },
                    DateDeparture = new List<DateTime> { new DateTime(2019, 04, 21, 12, 40, 00), new DateTime(2019, 04, 21, 23, 30, 00) }
                },
                new Train
                {
                    Name = "Talgo55", Arrival = "Astana", Departure = "Semey", Capacity = 120, Price = 11000,
                    DateArrival = new List<DateTime> { new DateTime(2019, 04, 20, 16, 50, 00), new DateTime(2019, 04, 20, 07, 40, 00) },
                    DateDeparture = new List<DateTime> { new DateTime(2019, 04, 21, 05, 40, 00), new DateTime(2019, 04, 21, 21, 30, 00) }
                },
                new Train
                {
                    Name = "Talgo55", Arrival = "Semey", Departure = "Astana", Capacity = 120, Price = 11000,
                    DateArrival = new List<DateTime> { new DateTime(2019, 04, 20, 16, 50, 00), new DateTime(2019, 04, 20, 07, 40, 00) },
                    DateDeparture = new List<DateTime> { new DateTime(2019, 04, 21, 05, 40, 00), new DateTime(2019, 04, 21, 21, 30, 00) }
                },
                new Train
                {
                    Name = "Talgo33", Arrival = "Astana", Departure = "Ural", Capacity = 80, Price = 7000,
                    DateArrival = new List<DateTime> { new DateTime(2019, 04, 20, 22, 20, 00), new DateTime(2019, 04, 20, 11, 15, 00) },
                    DateDeparture = new List<DateTime> { new DateTime(2019, 04, 21, 09, 40, 00), new DateTime(2019, 04, 21, 22, 30, 00) }
                },
                new Train
                { 
                    Name = "Talgo33", Arrival = "Ural", Departure = "Astana", Capacity = 80, Price = 7000,
                    DateArrival = new List<DateTime> { new DateTime(2019, 04, 20, 22, 20, 00), new DateTime(2019, 04, 20, 11, 15, 00) },
                    DateDeparture = new List<DateTime> { new DateTime(2019, 04, 21, 09, 40, 00), new DateTime(2019, 04, 21, 22, 30, 00) }
                }
            };
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
            using (var context = new LibraryContext())
            {
                context.Users.AddRange(users);
                context.Trains.AddRange(trains);

                var ticketForUser = trains.Where(train => train.Arrival.Contains("Astana")).Where(train => train.Departure.Contains("Almaty")).FirstOrDefault();

                var ticket = new Ticket
                {
                    TrainId = ticketForUser.Id,
                    UserId = users.ToList()[1].Id,
                    Count = count,
                    TotalPrice = ticketForUser.Price * count
                };
                context.Tickets.Add(ticket);

                context.SaveChanges();
            }
            


        }
    }
}
