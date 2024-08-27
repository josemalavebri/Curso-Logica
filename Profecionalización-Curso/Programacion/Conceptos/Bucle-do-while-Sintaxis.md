---
modificado: 2024-08-21
tags:
  - Comprendido
---

### Sintaxis básica
```c#
do
{
    // Bloque de código a ejecutar
}
while (condición);

```
### Ejemplo de uso
```c#
int numeroSecreto = 7;
do { 
Console.Write("Adivina el número entre 1 y 10: "); 
intento = int.Parse(Console.ReadLine());
	if (intento != numeroSecreto) 
	{ 
		Console.WriteLine("Incorrecto, intenta de nuevo.");
	}
}  while (intento != numeroSecreto);
Console.WriteLine("¡Felicidades! Adivinaste el número.");
```