using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace GUIH2;

public partial class MinHeltEgenKnap : UserControl
{
    public event FancyeventHandler Fancyevent; 
    public MinHeltEgenKnap()
    {

        InitializeComponent();
        Fancyevent += MinHeltEgenKnap_EVENTET_TIL_MUSEN;
    }

    private void MinHeltEgenKnap_EVENTET_TIL_MUSEN(object sender, FancyEventArgs e)
    {

    }

    void SlipMusen(object sender,RoutedEventArgs ff)
    {
        FancyEventArgs eventet = new FancyEventArgs();
        eventet.KnapKlik = 1;
        Fancyevent?.Invoke(this, eventet);    
    }
    void SlipMusen(object sender, PointerReleasedEventArgs ff)
    {
        FancyEventArgs eventetargs = new FancyEventArgs();
        eventetargs.KnapKlik = 2; 
        Fancyevent?.Invoke(this,eventetargs);
    }
}