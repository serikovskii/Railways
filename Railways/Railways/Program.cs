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
            var train = new Train
            {
                Name = "Baiterek" , Capacity = 90, Date = DateTime.Now, Path = "Astana - Almamty"
            };
            var ticket = new Ticket
            {
                TrainId = train.Id, Arrival = "Astana", Departure = "Almaty", Price = 4900, DateAndTime = DateTime.Now
            };
            var user = new User
            {
                Name = "Azat", Inn = "999333666777", TicketId = ticket.Id
            };

            using (var context = new LibraryContext())
            {
                context.Users.Add(user);
                context.Trains.Add(train);
                context.Tickets.Add(ticket);
                context.SaveChanges();
            }
            using (var context = new LibraryContext())
            {
                
            }


        }
    }
}
