Una variable global es accesible desde cualquier función dentro del programa.

``` c#
int contadorGlobal = 0; // Variable global 


void IncrementarContador() 
{ 
	contadorGlobal++; // Accede a la variable global 
} 

void MostrarContador() 
{
	Console.WriteLine(contadorGlobal); // Accede a la variable global 
}
```