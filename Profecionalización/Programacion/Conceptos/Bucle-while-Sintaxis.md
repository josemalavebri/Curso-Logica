---
modificado: 2024-08-21
tags:
  - Comprendido
---
### Sintaxis básica
```c#
while (condición)
{
    // Bloque de código a ejecutar mientras la condición sea verdadera
}

```


### Ejemplo básico

```c#
using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        int numero;

        Console.WriteLine("Ingrese números para sumar. Ingrese 0 para terminar.");

        while (true)
        {
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                break; 
            }

            suma += numero;
        }

        Console.WriteLine($"La suma total es: {suma}");
    }
}

```