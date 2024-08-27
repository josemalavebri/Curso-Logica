#### Ejemplo básico
```c#


static int Factorial(int n)
{
	// Caso base: si n es 1, el factorial es 1
	if (n == 1)
		return 1;
	else
		// Llamada recursiva: n * factorial de (n - 1)
		return n * Factorial(n - 1);
}

static void Main(string[] args)
{
	int number = 5;
	int result = Factorial(number);
	Console.WriteLine($"El factorial de {number} es {result}");
}

```