Tutorial
--------

Los arreglos y matrices en C# son muy similares a las matrices en C. Se definen utilizando el operador de corchetes `[]`, y
se inicializan utilizando una lista definida con llaves. Por ejemplo:

    int [] nums = {1, 2, 3, 4, 5};

También podemos definir un arreglo vacío como este:

    int [] nums = new int [10];

Para obtener el tamaño del arreglo/matriz, use el método `Length`.

    int [] nums = new int [10];
    Console.WriteLine (nums.Length);

Para acceder a un elemento específico en el arreglo, usamos el operador de paréntesis:

    int [] nums = new int [10];
    int primero = nums [0];
    int segundo = nums [1];
	nums [2] = 10;

Notese que C# utiliza índices basados ​​en cero.

### Matrices Multidimensionales

C# admite matrices multidimensionales, definidas de la siguiente manera:

    int [,] matriz = new int [2,2];

    matriz [0,0] = 1;
    matriz [0,1] = 2;
    matriz [1,0] = 3;
    matriz [1,1] = 4;

    int [,] matrizPredefinida = new int [2,2] {{1, 2}, {3, 4}};

Ejercicio
--------

Defina una matriz llamada `fruits` que contenga las siguientes cadenas:" apple "," banana "y" orange ".

Código Tutorial
-------------

    utilizando el sistema;

    clase pública tutorial
    {
       vacío estático público principal ()
       {
          // Codigo aqui

          // código de prueba
          Console.WriteLine (frutas [0]);
          Console.WriteLine (frutas [1]);
          Console.WriteLine (frutas [2]);
       }
    }

Salida Esperada
---------------

    manzana
	banana
    naranja

Solución
--------
  using System;

    public class Tutorial
    {
       public static void Main()
       {
          string[] frutas = new string[] { "manzana", "banana", "naranja" };

          // test code
          Console.WriteLine(frutas[0]);
          Console.WriteLine(frutas[1]);
          Console.WriteLine(frutas[2]);
       }
    }
