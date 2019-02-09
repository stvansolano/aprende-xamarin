Tutorial
--------

C# es un lenguaje de programación de que nos permite escribir código que se ejecuta sobre el entorno .NET de Microsoft.
C# tiene más funciones y capacidades de otros lenguajes como Java y JavaScript, fue desarrollado por Microsoft y puede utilizarse
en diferentes entornos, ambientes y Sistemas Operativos.

C# está orientado a objetos y su sintaxis es muy similar a otros lenguajes de alto nivel como Java, JavaScript, Python.

En este tutorial, usaremos la función `System.Console.WriteLine` para escribir líneas en la salida
consola. Al escribir una aplicación de línea de comandos de C#, la misma función también se puede utilizar para imprimir en la
consola.

** Nota: ** Es posible escribir aplicaciones web usando  # usando el entorno ASP.NET, Xamarin, entre otras.

Ejercicio
--------

Mostrar "Hola, Mundo!" en la consola.

Código del Tutorial
-------------

    using System;

    public class Hello
    {
        public static void Main()
        {
            System.Console.WriteLine("Adios, Mundo!");
        }
    }

Salida esperada
---------------

    Hola, Mundo!

Solución
--------

using System;

namespace csharp_basico
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.Write("Hola, Mundo!");
            Console.Write("Haga enter para cerrar");

            Console.ReadKey();
        }
    }
}
