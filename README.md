# Gabriel.Cat.Xamarin.Wpf
hacer simple la parte de inicializar la app
Solo se tiene que añadir al proyecto wpf los paquetes del nuget Xamarin.Forms.Platform.WPF , Gabriel.Cat.Xamarin.Wpf y el proyecto Xamarin.Forms


en el constructor después del InitialitzeComponent();

//XamarinNameSpace es el namespace del proyecto Xamarin.Forms
Gabriel.Cat.Xamarin.Wpf.Inicializador<XamarinNameSpace.MainPage>.Start(this);

Licencia GNUV3
