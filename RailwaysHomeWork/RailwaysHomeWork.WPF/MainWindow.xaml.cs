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
    public partial class MainWindow : Window
    {
        private string _arrival;
        private string _departure;
        private DateTime _date;
        public int CountPerson { get; set; } // спросить как передать значение в другое окно

        public Guid TrainId { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchBilet(object sender, RoutedEventArgs e)
        {
            if (Arrivial.SelectedItem == null)
            {
                MessageBox.Show("норм откуда введи");
                return;
            }

            if (Departure.SelectedItem == null)
            {
                MessageBox.Show("норм куда введи");
                return;
            }

            if (Date.SelectedItem == null)
            {
                MessageBox.Show("норм дату введи");
                return;
            }

            if (Count.SelectedItem == null)
            {
                MessageBox.Show("норм количество персон введи");
                return;
            }

            using (var context = new LibraryContext())
            {
                var trainTicket = context.Trains.Where(train => train.Arrival.Contains(_arrival)).Where(train => train.Departure.Contains(_departure))
                    .Where(train => train.DateArrival == _date).FirstOrDefault();

                var ticket = new Ticket
                {
                    TrainId = trainTicket.Id,
                    Count = CountPerson,
                    TotalPrice = trainTicket.Price*CountPerson
                };
                context.Tickets.Add(ticket);
                context.SaveChanges();
                if (trainTicket.Id != null)
                {
                    TrainId = trainTicket.Id;
                    var buyTicket = new BuyTicket();
                    buyTicket.Show();
                }
                else
                    MessageBox.Show("такого поезда нет");
            }
        }

        private void ArrivialChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            _arrival = selectedItem.Content.ToString();
        }
        private void DepartureChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            _departure = selectedItem.Content.ToString();
        }
        private void DateChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            _date = DateTime.ParseExact(selectedItem.Content.ToString(), "dd.MM.yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);

        }
        private void CountChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            CountPerson = int.Parse(selectedItem.Content.ToString());
        }
    }
}
