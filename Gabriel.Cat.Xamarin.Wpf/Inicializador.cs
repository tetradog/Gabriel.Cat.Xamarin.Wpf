using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF.Extensions;

namespace Gabriel.Cat.Xamarin.Wpf
{
    public static class Inicializador<TXamarinFormsMainPage>
        where TXamarinFormsMainPage : ContentPage, new() 

    {
        public static void Start( Window mainWpf)
        {
            TXamarinFormsMainPage main;

            Forms.Init();
            main = new TXamarinFormsMainPage();
            if (main.Title != null)
                mainWpf.Title = main.Title;
           System.Windows.Application.Current.MainWindow.Content = main.ToFrameworkElement();
        }
    }
}
