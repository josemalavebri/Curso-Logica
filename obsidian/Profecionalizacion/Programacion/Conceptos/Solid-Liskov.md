---
modificado: 2024-09-17
tags:
  - Comprendido
Flujo-Regreso:
---
El **principio de sustitución de Liskov (LSP)**, que forma parte de los principios SOLID de diseño de software, establece que "los objetos de una clase derivada deben poder reemplazar a los de una clase base sin alterar el correcto funcionamiento del programa". 

Si una clase B es una subclase de A, deberías poder usar un objeto de tipo B en lugar de uno de tipo A sin que el código falle o se comporte de forma incorrecta.


##### Ejemplo de uso incorrecto
```c#
// Clase base Animal
public class Animal
{
    public virtual void Volar()
    {
        Console.WriteLine("Este animal puede volar.");
    }
}

// Clase derivada Pajaro
public class Pajaro : Animal
{
    public override void Volar()
    {
        Console.WriteLine("El pájaro está volando.");
    }
}

// Clase derivada Perro (no debería volar)
public class Perro : Animal
{
    // Perro no debería heredar Volar, pero lo hace.
}

public class Programa
{
    public static void Main(string[] args)
    {
        Animal miAnimal = new Perro();
        miAnimal.Volar(); // Error lógico: Un perro no puede volar.
    }
}

```


##### Ejemplo de uso incorrecto
```c#
public class Vehiculo
{
    public virtual void Encender()
    {
        Console.WriteLine("Vehículo encendido");
    }
}

public class VehiculoEncendido
{
    public virtual void Encender()
    {
        Console.WriteLine("Vehículo encendido");
    }
}

public class Bicicleta : VehiculoNoEncendido
{
    public override void Encender()
    {
        // Violación de LSP: una bicicleta no necesita ser encendida
        throw new NotImplementedException("Las bicicletas no se encienden.");
    }
}

```

Concepto
### Más sobre: Tema
##### [[-Sintaxis-Ejemplo]]
##### [[-Características]]

### Temas Relacionados:
