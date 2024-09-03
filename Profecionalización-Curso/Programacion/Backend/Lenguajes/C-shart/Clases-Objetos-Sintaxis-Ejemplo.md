---
modificado: 2024-09-01
tags:
  - Comprendido
Regreso:
  - "[[Clases-Objetos]]"
---
#### Sintaxis básica

```c#
[ModificadorDeAcceso] class NombreClase{

	//Campos
	private string campo;
	...
	
	//Constructores
	public NombreClase(){
	}
	...
	
	//Metodos
	public void NombreMetodo(){
	}
	...
}
```

#### Ejemplo básico
```c#
public class Persona
{
    // Campos
    private string nombre;
    private int edad;

    // Propiedad para acceder al campo nombre
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    // Propiedad para acceder al campo edad
    public int Edad
    {
        get { return edad; }
        set
        {
            if (value >= 0) // Validación p
                edad = value;
            else
                throw new ArgumentException("La edad no puede ser negativa.");
        }
    }

    // Constructor
    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    // Método
    public void Saludar()
    {
        Console.WriteLine($"Hola, me llamo {nombre} y tengo {edad} años.");
    }
}

```