using System;
using Xamarin.Forms;

namespace ConsolaMovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Codigo de la consola
            string miNombre = "John";

            string nombreCompleto = "Esteban" + " " + "Solano";
            string concatenacion = "Esteban" + "Solano" + 1 + 1;

            int miEntero = (1 + 1) / 10; //   2 / 10 = 0.2
            float miFlotante = (float)(1 + 1) / 10;

            // Palabra reservada VAR
            var salario = 123.45f;

            bool miBooleano = true;

            string salida = "Consola de salida";
            
            LabelSalida.Text = salida;

            Stack1.Children.Add(new Label { TextColor = Color.White, Text = "Valor entero:" + miEntero });
            Stack1.Children.Add(new Label { TextColor = Color.White, Text = "Nombre:" + nombreCompleto});
            Stack1.Children.Add(new Label { TextColor = Color.White, Text = "Concatenacion:" + concatenacion });
            Stack1.Children.Add(new Label { TextColor = Color.White, Text = "Division:" + miFlotante });
            Stack1.Children.Add(new Label { TextColor = Color.White, Text = "El salario es:" + salario});
            Stack1.Children.Add(new Label { TextColor = Color.White, Text = "El booleano es:" + miBooleano.ToString() });

            MostrarMensaje("Se ejecuto el metodo: MostrarMensaje");

            Console.WriteLine("Cantidad de etiquetas: " + Stack1.Children.Count);

            PickerPantalla.Items.Add("Pantalla 3");

            PickerPantalla.SelectedIndexChanged += PickerPantalla_SelectedIndexChanged;
        }

        private void PickerPantalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Usted escogio: " + PickerPantalla.SelectedItem);

            MostrarMensaje("Usted escogio: " + PickerPantalla.SelectedItem);

            Navigation.PushAsync(new MainPage());
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);

            Stack1.Children.Add(new Label { TextColor = Color.White, Text = mensaje});
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MostrarMensaje("La pantalla se ha mostrado");
        }
    }
}
