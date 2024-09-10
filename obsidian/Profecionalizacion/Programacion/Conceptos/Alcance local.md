Las [[variable|variables]] declaradas dentro de una función tienen un alcance local, lo que significa que solo son accesibles dentro de esa función. No se pueden acceder desde fuera de la función.

```c#
void Sumar() 
{ 
	int a = 5; // Variable local 
	int b = 10; // Variable local 
	int suma = a + b; Console.WriteLine(suma); // Funciona 
} 

	// Console.WriteLine(a);
	// no funciona
```