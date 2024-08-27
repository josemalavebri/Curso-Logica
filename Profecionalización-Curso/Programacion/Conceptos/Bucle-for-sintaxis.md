---
modificado: 2024-08-21
tags:
  - Comprendido
---
### Sintaxis básica
```c#
for (inicialización; condición; incremento/decremento) 
{ 
// Bloque de código a ejecutar en cada iteración 
}
```


### Ejemplo de uso simple
```c#
using System;

class Program
{
    static void Main()
    {
        // Bucle for para imprimir números del 1 al 5
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}

```

### Ejemplo de uso dinámico
```c#
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine(); 

        Console.Write("Ingrese la letra que desea contar: ");
        char letra = Console.ReadLine()[0]; 

        int contador = 0;

        
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == letra)
            {
                contador++;
            }
        }

        Console.WriteLine($"La letra '{letra}' aparece {contador} veces en la palabra '{palabra}'.");
    }
}

```