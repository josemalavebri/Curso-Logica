---
modificado: 2024-08-25
tags:
  - Comprendido
Regreso:
---
#### Sintaxis básica
```c#
// Declaración de un arreglo
TipoDatos[] variableUso;


variableUso = new int[5]; // Inicialización 

// Declaración e inicialización junta
int[] edades = new int[3];


//  Inicialización con valores
int[] edades = { 25, 30, 35 };
```
#### Ejemplo básico
```c#


int[] numeros = new int[5];

//Asignación de valores
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
numeros[3] = 40;
numeros[4] = 50;

// Acceso
Console.WriteLine("Primer número en el arreglo: " + numeros[0]); // Salida: 10

// Modificación de un elemento
numeros[2] = 35;
Console.WriteLine("Número en el índice 2 después de modificación: " + numeros[2]); // Salida: 35

// Recorrer elementos

for (int i = 0; i < numeros.Length; i++)
{
	Console.WriteLine(numeros[i]);
}

//  Inicialización con valores
int[] edades = { 25, 30, 35 };
Console.WriteLine("Edades en el arreglo:");
foreach (int edad in edades)
{
	Console.WriteLine(edad);
}

```