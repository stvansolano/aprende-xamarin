Tutorial
--------
C# usa variables booleanas para evaluar condiciones. Los valores booleanos `true` y` false` se devuelven cuando se compara o evalúa una expresión.
Por ejemplo:

    int a = 4;
    bool b = a == 4;

    if (b) {
        Console.WriteLine("Es verdadero!");
    }

Por supuesto, normalmente no asignamos una expresión condicional a un bool, solo usamos la versión corta:

    int a = 4;

    if (a == 4) {
        Console.WriteLine("Ohhh! So a is 4!");
    }

### Operadores booleanos

No hay muchos operadores para usar en sentencias condicionales y la mayoría de ellos son bastante simples:

    int a = 4;
    int b = 5;
    bool result;
    result = a < b; // true
    result = a > b; // false
    result = a <= 4; // menor o igual a 4- true
    result = b >= 6;
    result = a == b;
    result = a != b;
    result = a > b || a < b;
    result = 3 < a && a < 6;
    result = !result;

### Sentencias if - else

La sentencia if, else en C # es bastante simple.

    if (a == b) {
        // Tanto a como b son iguales, se ejecuta el codigo
    }

Y también podemos agregar una declaración else después de un if, para hacer algo si la condición no es verdadera

    if (a == b) {
        // Se ejecuta el codigo
    } else {
        // En caso de que no sea asi... :/
    }

Las declaraciones if - else no tienen que estar en varias líneas con {}, si se pueden usar en una línea, o sin {}, para una declaración de una sola línea.

    if (a == b)
        Console.WriteLine(Es verdadero!");
    else
        Console.WriteLine("Es falso!");

Although this method might be useful for making your code shorter by using fewer lines, we strongly recommend for beginners not to use this short version of statements and always use the full version with {}. This goes to every statement that can be shorted to a single line (for, while, etc).

Ejercicio
--------

En este ejercicio, debe construir una declaración `if` que compruebe si el número `adivinanza` es igual a 500. Si ese es el caso, Mostrar el mensaje `"¡Éxito! "`.

Código del Tutorial
-------------

    using System;
    
    public class Conditionals
    {
        public static void Main()
        {
            int guess = 500;
            
            // Write conditional here
        }
    }

Salida Esperada
---------------

    ¡Éxito, adivinaste!

Solucion
--------

    //