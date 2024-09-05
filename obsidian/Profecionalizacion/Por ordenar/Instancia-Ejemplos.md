---
modificado: 2024-09-05
tags:
  - Comprendido
Regreso:
  - "[[Instancia]]"
---
#### Ejemplo básico
```c#
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
    }
}

Persona persona1 = new Persona();
persona1.Nombre = "Juan";
persona1.Edad = 25;

Persona persona2 = new Persona();
persona2.Nombre = "María";
persona2.Edad = 30;

persona1.Saludar();  
persona2.Saludar();

```