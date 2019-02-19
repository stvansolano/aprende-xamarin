using System;

namespace ConsolaMovil
{
    public partial class App
    {
        // Constructor de la clase
        public App()
        {
            InitializeComponent();

            // Asignacion de la propiedad "MainPage"
            var pagina = new Xamarin.Forms.NavigationPage(new MainPage());
            pagina.CurrentPage.Title = "Consola movil";

            MainPage = pagina;
        }
    }
}
