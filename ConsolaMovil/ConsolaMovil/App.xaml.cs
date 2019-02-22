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

        protected override void OnStart()
        {
            base.OnStart();

            MostrarSalida("La aplicacion se ha iniciado");
        }

        protected override void OnSleep()
        {
            base.OnSleep();

            MostrarSalida("La aplicacion se ha interrumpido");
        }

        protected override void OnResume()
        {
            base.OnResume();

            MostrarSalida("La aplicacion se ha reanudado");
        }

        private void MostrarSalida(string mensaje)
        {
            // Nivel 1: Propiedad "MainPage"
            var main = (Xamarin.Forms.NavigationPage)MainPage;

            // Nivel 2: Propiedad "RootPage"
            var root = main.RootPage;

            // Nivel 3: Casteo al tipo "MainPage"
            MainPage paginaActual = (MainPage)root;

            paginaActual.MostrarMensaje(mensaje);

            Console.WriteLine(mensaje);
        }

    }
}
