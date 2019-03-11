using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace csharp_basico
{
    enum MarcaCarro
    {
        Toyota = 1,
        Honda = 2,
        Ford = 3
    }

    class Program
    {
        /*
            Punto de arranque del programa 
        */
        public static void Main(string[] args)
        {
            ConsumoREST();

            Console.ReadKey();
        }

        private static async void ConsumoREST()
        {
            // Mostrar el JSON y/o los productos de la API

            using (var cliente = new HttpClient())
            {
                // 1) Hacer la peticion al servidor
                cliente.BaseAddress = new Uri("http://cloud-services.azurewebsites.net/");



                var respuesta = await cliente.GetAsync("api/Products");

                Console.WriteLine("URL:" + cliente.BaseAddress + "/api/Products");
                Console.WriteLine("------Headers---------------");
                Console.WriteLine("Respuesta:" + respuesta.StatusCode.ToString());
                Console.WriteLine(respuesta.Headers);

                Console.WriteLine("-----Body--------");

                // 2) Leer el contenido de la respuesta (peticion)
                string json = await respuesta.Content.ReadAsStringAsync();

                // 3) Interpretar (deserializar) el contenido JSON 
                // Deserializar (JSON => {Objeto})
                // Serializar ({Objeto} => String => JSON)

                var deserializado = (JArray)JsonConvert.DeserializeObject(json);
                Console.WriteLine(json);

                Console.WriteLine("Cantidad de inventario");
                Console.WriteLine(deserializado.Count);
            }
        }

        private static void Parte1()
        {
            // declaracion de variables
            string miNombre = "John";
            
            string nombreCompleto = "Esteban" + " " + "Solano";
            string concatenacion = "Esteban" + "Solano" + 1 + 1;

            int miEntero = (1 + 1) / 10; //   2 / 10 = 0.2
            float miFlotante = (float)(1 + 1) /10;

            // Palabra reservada VAR
            var salario = 123.45f;

            bool miBooleano = false;

            Console.WriteLine("Valor entero:" + miEntero);
            Console.WriteLine("Nombre: " + nombreCompleto);
            Console.WriteLine("Concatenacion: " + concatenacion);
            Console.WriteLine("Division: " + miFlotante);
            Console.WriteLine("El salario es: "+ salario);
            Console.WriteLine(miBooleano);

            // Enumeraciones
            var marca1 = MarcaCarro.Toyota;
            marca1 = MarcaCarro.Honda;
            marca1 = MarcaCarro.Ford;
            marca1 = (MarcaCarro)1;

            Console.WriteLine("Marca de carro: " + marca1);
            
            miBooleano = !miBooleano; // si es false, pasa a true o viceversa
            miBooleano = false;  // true
            miBooleano = (0 == 0);

            // Condicionales
            if (miBooleano)
            {
                // Ejecuto el bloque
                Console.WriteLine($"La condicion se cumple: {miBooleano}");
            }

            var segundero = DateTime.Now.Second;

            Console.WriteLine($"Segundero:{segundero}");

            if (segundero % 2 == 0)
            {
                Console.WriteLine("El segundero es par");
            }
            else
                Console.WriteLine("El segundero es impar");


            int[] nums = { 10, 20, 30 };

            nums = new int[3];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            // nums[3] = 40; // Representa un error fuera de indice

            Console.WriteLine("----------------------");
            Console.WriteLine("Elementos del arreglo");

            Console.WriteLine(nums[0]); // 10

            var posicionActual = 1;
            var valor = nums[posicionActual];

            Console.WriteLine(valor); // 20
            Console.WriteLine(nums[2]); // 30

            Console.WriteLine($"Cantidad de elementos:{nums.Length}");

            Console.ReadKey();
        }
    }
}
