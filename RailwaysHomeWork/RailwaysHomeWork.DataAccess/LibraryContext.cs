namespace RailwaysHomeWork.DataAccess
{
    using RailwaysHomeWork.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}