Tutorial
--------

C# es un lenguaje estáticamente tipado. Por lo tanto, debemos definir los tipos de variables antes de usarlas.

Para definir una variable en C #, usamos la siguiente sintaxis, que es similar a C / Java:

    int myInt = 1;
    float myFloat = 1f;
    bool myBoolean = true;
    char myChar = 'a';
    doble myDouble = 1.75;

Notese que la definición de un número de punto flotante requiere una letra `f` explícita después del número.

C# admite la inferencia de tipos, lo que significa que no siempre tiene que especificar explícitamente un tipo.
Puede dejar que el compilador intente y entienda el tipo de variable automáticamente. Sin embargo, una vez que el tipo de variable
Se ha determinado, no se le puede asignar un tipo diferente.

    var x = 1;
    var y = 2;
    var suma = x + y;    // suma sera definida tambien integer o entero

### Enums

Las enumeraciones son un tipo especial que utilizan números enteros para representar un elemento como parte de un subconjunto.

    public enum CarType
    {
        Toyota = 1,
        Honda = 2,
        Ford = 3,
    }

    public class Tutorial
    {
        public static void Main()
        {
            CarType myCarType = CarType.Toyota;
        }
    }


Ejercicio
--------

Definir tres variables:

* Un string o cadena llamado `nombreProducto` igual a `TV`.
* Un integer o entero llamado `annoProducto` igual a 2019.
* Un float o flotante llamado `precioProducto` igual a 279.99f.

Codigo del Tutorial
-------------

    using System;

    public class Tutorial
    {
       public static void Main()
       {
          // write your code here

          // test code
          Console.WriteLine("nombreProducto: " + productName);
          Console.WriteLine("annoProducto: " + productYear);
          Console.WriteLine("precioProducto: " + productPrice);

       }
    }


Salida Esperada
---------------

    nombreProducto: TV
    annoProducto: 2012
    precioProducto: 279.99

Solution
--------

    using System;

    public class Tutorial
    {
       public static void Main()
       {
          // write your code here
          string nombreProducto = "TV";
          int productYear = 2012;
          float precioProducto = 279.99f;

          // test code
          Console.WriteLine("nombreProducto: " + nombreProducto);
          Console.WriteLine("annoProducto: " + annoProducto);
          Console.WriteLine("precioProducto: " + precioProducto);
       }
    }

