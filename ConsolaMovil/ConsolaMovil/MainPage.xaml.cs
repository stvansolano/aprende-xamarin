using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string salida = "";

            salida += "Valor entero:" + miEntero;
            salida += "Nombre: " + nombreCompleto;
            salida += "Concatenacion: " + concatenacion;
            salida += "Division: " + miFlotante;
            salida += "El salario es: " + salario;
            salida += miBooleano;

            // Tarea: Presentar los Label en un StackLayout
            new Label { Text = "Valor entero:" + miEntero };
            new Label { Text = "Nombre:" + nombreCompleto};
            // ....
            new Label { Text = miBooleano.ToString() };

            LabelSalida.Text = salida;
        }
    }
}
