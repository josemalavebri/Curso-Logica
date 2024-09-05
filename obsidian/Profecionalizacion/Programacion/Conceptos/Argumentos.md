Son los valores reales que se pasan a la función cuando se invoca. Los argumentos deben coincidir en número, orden y tipo con los [[parámetros]] definidos en la función.

``` c#
void Sumar(int a, int b) 
{
	int resultado = a + b; // Suma de los dos argumentos 
	Console.WriteLine("El resultado de la suma es: " + resultado);
}

void Main() 
{ 
	Sumar(5, 10);// Llamada a la función Sumar | argumentos
}
```