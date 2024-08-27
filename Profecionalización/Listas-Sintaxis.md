---
modificado: 2024-08-25
tags:
  - Comprendido
  - "#Codigo"
  - Investigar
Regreso:
---
#### Sintaxis básica
```c#
// Declaración e inicialización de una lista de enteros
List<TipoDato> variableUso = new List<TipoDato>();

// Declaración e inicialización de una lista de cadenas
List<string> nombres = new List<string>();

```

#### Ejemplo básico
```c#
// 1. Declarar e inicializar una lista de cadenas
List<string> nombres = new List<string>();

// 2. Añadir elementos a la lista
	nombres.Add("Ana");
	nombres.Add("Juan");
	nombres.Add("Luis");
	
	// 3. Acceder a un elemento de la lista por índice
	Console.WriteLine("Primer nombre en la lista: " + nombres[0]); // Salida: Ana
	
	// 4. Modificar un elemento en la lista
	nombres[1] = "Pedro";
	Console.WriteLine("Nombre en el índice 1 después de modificación: " + nombres[1]); // Salida: Pedro
	
	// 5. Eliminar un elemento de la lista
	nombres.Remove("Luis"); // Elimina el primer elemento con el valor "Luis"
	
	// 6. Recorrer la lista con un bucle foreach
	Console.WriteLine("Nombres en la lista:");
	foreach (string nombre in nombres)
	{
		Console.WriteLine(nombre);
	}
	
	// 7. Obtener el número de elementos en la lista
	int cantidad = nombres.Count;
	Console.WriteLine("Número de nombres en la lista: " + cantidad); // Salida: 2
	}
}

```