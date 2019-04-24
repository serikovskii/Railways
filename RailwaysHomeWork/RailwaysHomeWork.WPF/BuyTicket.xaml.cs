using RailwaysHomeWork.DataAccess;
using RailwaysHomeWork.Models;
using RailwaysHomeWork;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Collections.Generic;


namespace RailwaysHomeWork.WPF
{
    public partial class BuyTicket : Window
    {
        public BuyTicket()
        {
            InitializeComponent();
        }

        public void BuyTicketButton(object sender, RoutedEventArgs e)
        {
            string name;
            if (nameBox.Text.Length == 0)
            {
                MessageBox.Show("Норм введи");
                return;
            }
            else
                name = nameBox.Text;

            string iin;
            if (iinBox.Text.Length == 0)
            {
                MessageBox.Show("Норм введи");
                return;
            }
            else
                iin = iinBox.Text;

            string number;
            if (numberBox.Text.Length == 0)
            {
                MessageBox.Show("норм введи");
                return;
            }
            else
                number = numberBox.Text;
            MainWindow mainWindow = new MainWindow();
            var train1 = mainWindow.TrainId;
            using (var context = new LibraryContext())
            {
                var user = new User
                {
                    FullName = name, Inn = iin, NumberPhone = number
                };
                context.Users.Add(user);
                context.SaveChanges();

                context.Tickets.ToList().First().UserId = user.Id;
                context.SaveChanges();

                var ticket = context.Tickets.ToList().First();
                var trainForTicket = context.Trains.Where(train => train.Id == ticket.TrainId).FirstOrDefault();
                MessageBox.Show($"Вы купили билет на имя: {user.FullName}\nПоезд {trainForTicket.Arrival} - {trainForTicket.Departure}" +
                    $" \nНа {ticket.Count} персон, Сумма {ticket.TotalPrice}");
            }
            Close();
        }
    }
}
