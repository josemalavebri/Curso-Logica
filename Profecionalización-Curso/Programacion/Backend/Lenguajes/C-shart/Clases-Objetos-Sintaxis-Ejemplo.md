---
modificado: 2024-09-01
tags:
  - Comprendido
Regreso:
  - "[[Clases-Objetos]]"
---
#### Sintaxis básica
Un modificador de acceso opcional precede a la palabra clave `class`.
Como en este caso se usa [[public]], cualquier usuario puede crear instancias de esta clase. El nombre de la clase sigue a la palabra clave `class`. El nombre de la clase debe seguir con ciertas 
[[Clase-Objeto-Reglas de nomenclatura|reglas de nomenclatura]] El resto de la definición es el cuerpo de la clase, donde se definen los datos y el comportamiento. Los campos, las propiedades, los métodos y los eventos de una clase se denominan de manera colectiva _miembros de clase_.

[[Nombre de la Nota|Texto Personalizado]]
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