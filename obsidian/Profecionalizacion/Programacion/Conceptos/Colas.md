---
modificado: 2024-08-25
tags:
  - Comprendido
Regreso:
---
Una cola es una estructura de datos basada en el principio **FIFO** (First In, First Out). 

Esto significa que el primer elemento en ser agregado es el primero en ser retirado. 

Es como una fila en una caja de supermercado: las personas se agregan al final de la fila y se atienden desde el frente.

#### Características

- **Acceso a ambos extremos**: Los elementos se agregan al final de la cola y se quitan desde el frente.
- **Operaciones principales**: `Enqueue` para agregar, `Dequeue` para quitar, y `Peek` para ver el elemento al frente sin quitarlo.


```c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaración e inicialización de una cola de enteros
        Queue<int> cola = new Queue<int>();

        // Agregar elementos a la cola
        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);

        // Ver el elemento al frente sin quitarlo
        Console.WriteLine("Elemento al frente: " + cola.Peek()); // Salida: 10

        // Quitar y obtener el elemento al frente
        Console.WriteLine("Elemento retirado: " + cola.Dequeue()); // Salida: 10
        // Recorrer la cola
        Console.WriteLine("Elementos restantes en la cola:");
        foreach (int numero in cola)
        {
            Console.WriteLine(numero);
        }
        
    }
}

```