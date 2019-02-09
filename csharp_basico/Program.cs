using System;

namespace csharp_basico
{
    class Program
    {
        /*
            Punto de arranque del programa 
        */ 
        public static void Main(string[] args)
        {
            // declaracion de variables
            string miNombre = "John";
            
            string nombreCompleto = "Esteban" + " " + "Solano";
            string concatenacion = "Esteban" + "Solano" + 1 + 1;

            int miEntero = (1 + 1) / 10; //   2 / 10 = 0.2
            float miFlotante = (float)(1 + 1) /10;

            // Palabra reservada VAR
            var salario = 123.45f;

            bool miBooleano = true;

            Console.WriteLine("Valor entero:" + miEntero);
            Console.WriteLine("Nombre: " + nombreCompleto);
            Console.WriteLine("Concatenacion: " + concatenacion);
            Console.WriteLine("Division: " + miFlotante);
            Console.WriteLine("El salario es: "+ salario);
            Console.WriteLine(miBooleano);

            Console.ReadKey();
        }
    }
}
