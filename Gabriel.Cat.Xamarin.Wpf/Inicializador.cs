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
    public static class Inicializador<TXamarinFormsMainPage, TWPFMainWindows>
        where TXamarinFormsMainPage : ContentPage, new()
        where TWPFMainWindows : Window  

    {
        public static void Start(System.Windows.Application currentApp, TWPFMainWindows mainWpf)
        {
            TXamarinFormsMainPage main;
            Forms.Init();
            main = new TXamarinFormsMainPage();
            if (main.Title != null)
                mainWpf.Title = main.Title;
            currentApp.MainWindow.Content = main.ToFrameworkElement();
        }
    }
}
