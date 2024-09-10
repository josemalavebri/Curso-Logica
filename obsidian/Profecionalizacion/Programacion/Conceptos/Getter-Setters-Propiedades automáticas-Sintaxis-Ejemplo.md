---
modificado: 2024-09-08
tags:
  - Comprendido
Regreso:
---
#### Sintaxis básica

```c#
public class MiClase
{
    public Tipo Propiedad { get; set; }
}

```
#### Ejemplo básico
```c#
using System;

Persona persona = new Persona();

//Asignaicon de valores
persona.Nombre = "Ana";
persona.Edad = 30;
Console.WriteLine($"Nombre: {persona.Nombre}");  
Console.WriteLine($"Edad: {persona.Edad}");      

class Persona
{
    // Propiedades automáticas
    public string Nombre { get; set; }

    public int Edad { get; set; }
}
```