using Avalonia.Controls;
using System;

namespace GUIH2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = Tis.SelectedItem as ComboBoxItem;
           
            switch (gg.Content)
            {
                case "EUR":
                    Vindue.Title = "EUR";
                    break;
                case "DKK":
                    Vindue.Title = "DKK";

                    break;
                case "USD":
                    Vindue.Title = "USD";

                    break;
            }
        }
        private void SkiftDato(object sender, CalendarDateChangedEventArgs e)
        {
            if (Jens.SelectedDates.Count >= 5)
            {
                Jens.IsVisible = false;
            }
        }

        private void CustomEvent(object sender, FancyEventArgs e)
        {



        }
        private void Mega(object sender, TextChangedEventArgs e)
        {
            int i = 0;
            if(int.TryParse(Stor.Text, out i))
            {
                Stor.FontSize = Convert.ToInt32(Stor.Text) * 10; 
            }

        }
        private void SkiftDato1(object sender, SelectionChangedEventArgs e)
        {
            if (Jens.SelectedDates.Count >= 5)
            {

                Jens.IsVisible = false;

            }

        }
    }
}