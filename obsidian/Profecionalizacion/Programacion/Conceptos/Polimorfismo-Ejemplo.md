---
modificado: 2024-09-17
tags:
  - Comprendido
Flujo-Regreso:
---
```c#
public class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("Sonido general de animal");
    }
    
}

public class Perro : Animal
{
    public override void HacerSonido()
	{
        Console.WriteLine("El perro ladra");
    }
}

public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maúlla");
    }
}

// Uso de polimorfismo
Animal miAnimal = new Perro();
miAnimal.HacerSonido(); // Salida: El perro ladra

miAnimal = new Gato();
miAnimal.HacerSonido(); // Salida: El gato maúlla

```




