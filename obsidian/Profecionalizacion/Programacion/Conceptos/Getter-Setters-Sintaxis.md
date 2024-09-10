---
modificado: 2024-09-08
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Getter-Setters]]"
---
#### Sintaxis básica
```c#
public class Persona
{
	//Atributo
    public string nombre;

	//getter
	[ModificadorDeAccesoPublico] |TipoRetorno |nombre
	public string Nombre(){
		return this.nombre;
	}

	//getter
	[ModificadorDeAccesoPublico] |TipoRetorno |nombre
	public void Nombre(string nombre){
		 this.nombre = nombre;
	}
}

```
#### Ejemplo básico
```c#
using System;

public class Persona
{
    // Campo privado
    private string nombre;

    // Propiedad con getter y setter
    public string Nombre
    {
        get{ return nombre;}
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }
    }
}

public class Programa
{
    public static void Main()
    {
        Persona persona = new Persona();

        // Usando el setter para asignar un valor
        persona.Nombre = "Juan Pérez";

        // Usando el getter para obtener el valor
        Console.WriteLine(persona.Nombre);  // Salida: Juan Pérez

        // Intentando asignar un valor inválido
        try
        {
            persona.Nombre = "";  // Esto lanzará una excepción
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);  // Salida: El nombre no puede estar vacío.
        }
    }
}

```