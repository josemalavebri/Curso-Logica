---
modificado: 2024-09-09
tags:
  - Comprendido
Flujo-Regreso:
---
### Atributos

Los **atributos** (o campos) son variables que se definen en una clase para almacenar datos.

Son los componentes básicos que mantienen el estado de un objeto.

```C#
public class Persona
{
    // Atributo o campo privado
    private string nombre;
}

```

Las **propiedades** son un mecanismo que permite controlar el acceso a los atributos. 

Una propiedad encapsula el acceso a un campo privado y puede incluir lógica adicional en los métodos `get` y `set`.

```c#
public class Persona
{
    // Atributo privado
    private string nombre;

    // Propiedad pública
    public string Nombre
    {
        get
        {
            return nombre;
        }
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

```

Un atributo no se transforma automáticamente en una propiedad solo por tener métodos `get` y `set`. 

Los métodos `get` y `set` deben estar explícitamente definidos en una propiedad para que el atributo se maneje como una propiedad en lugar de un campo.

```c#
public class Persona
{
    private string nombre; // Solo un atributo
}


public class Persona
{
    public string Nombre { get; set; } // Propiedad automática
}

```