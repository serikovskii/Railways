using System;
using System.Windows;
using RailwaysModels;
using Railways;
using System.Windows.Controls;

namespace Railways.WPF
{
    public partial class MainWindow : Window
    {
        private string _arrival;
        private string _departure;
        private DateTime _date;
        private int _countPerson;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchBilet (object sender, RoutedEventArgs e)
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

            using(var context = new LibraryContext())
            {
                Train train = new Train();
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

            _date = DateTime.ParseExact(selectedItem.Content.ToString(), "dd-MM-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            
        }
        private void CountChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            _countPerson = int.Parse(selectedItem.Content.ToString());
        }
    }
}
