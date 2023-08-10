using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Threading;
using Tmds.DBus.Protocol;

namespace GUIH2;

public partial class KnapControl : UserControl
{
    public KnapControl()
    {
        InitializeComponent();
    }

    private void ClearBTN(object sender, RoutedEventArgs e)
    {
        Fornavn.Text= string.Empty;
        Efternavn.Text = string.Empty;
        Gender1.IsChecked= false;
        Gender2.IsChecked = false;
        Gender3.IsChecked = false;
        Education1.IsChecked = false;
        Education2.IsChecked = false;
        Education3.IsChecked = false;

    }
    private void SubmitBTN(object sender, RoutedEventArgs e)
    {
        submit.Content = "Submitting...."; 
        Thread.Sleep(1000);
        Nej.IsVisible= true;
        ClearBTN(sender, e);
        Thread.Sleep(4000);
        Nej.IsVisible= false;
        submit.Content = "Submit."; 
    }


}