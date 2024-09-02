Los [[parámetros]] de una función también tienen un alcance local, pero son un caso especial de variables locales. 

Los valores de estos [[parámetros]] se pasan a la función cuando es llamada y son accesibles solo dentro de esa función.

``` c#


void MostrarMensaje(string mensaje) {
	Console.WriteLine(mensaje); 
	// "mensaje" es un parámetro y tiene alcance local 
} 


// Console.WriteLine(mensaje); // error
```