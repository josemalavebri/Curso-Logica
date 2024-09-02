---
modificado: 2024-08-25
tags:
  - Comprendido
Regreso:
  - "[[Temario-Lógica funcional y cerebral]]"
---
Una pila es una estructura de datos basada en el principio **LIFO** (Last In, First Out). Esto significa que el último elemento que se agrega es el primero en ser retirado. 

Es como una pila de platos: agregas platos a la cima y también los quitas desde la cima.

#### Características

- **Acceso a un solo extremo**: Solo se puede agregar o quitar elementos desde el extremo superior
 
- **Operaciones principales**: `Push` para agregar, `Pop` para quitar, y `Peek` para ver el elemento en la cima sin quitarlo.

```c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaración e inicialización de una pila de enteros
        Stack<int> pila = new Stack<int>();

        // Agregar elementos a la pila
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);

        // Ver el elemento en la cima sin quitarlo
        Console.WriteLine("Elemento en la cima: " + pila.Peek()); // Salida: 30

        // Quitar y obtener el elemento en la cima
        Console.WriteLine("Elemento retirado: " + pila.Pop()); // Salida: 30

        // Recorrer la pila
        Console.WriteLine("Elementos restantes en la pila:");
        foreach (int numero in pila)
        {
            Console.WriteLine(numero);
        }
    }
}

```