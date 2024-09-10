---
modificado: 2024-09-09
tags:
  - Comprendido
Regreso:
  - "[[Clase-Estructura]]"
---
### Variables de instancias
El término "variables de instancias" se refiere a las variables que pertenecen a un objeto (instancia de una clase) y que almacenan el estado del objeto.

Son propiedades de un objeto, que almacenan los datos específicos de esa instancia en particular. 

Cada objeto puede tener valores diferentes para sus variables de instancia, lo que permite que cada uno mantenga un estado individual.

```c#
class Coche
{
    // Variables de instancia (propiedades del coche)
    public string Marca;
    public string Modelo;
    public int Año;
    
    // Constructor para inicializar una instancia de Coche
    public Coche(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }
}
//Instanciacion
Coche coche1 = new Coche("Toyota", "Corolla", 2020);
Coche coche2 = new Coche("Honda", "Civic", 2021);

Console.WriteLine(coche1.Marca);  // Toyota
Console.WriteLine(coche2.Marca);  // Honda


```

### Métodos

Los **métodos** son funciones que definen un comportamiento en la clase. 

Estos pueden operar sobre las variables de instancia y ejecutar acciones como modificar el estado de un objeto o realizar cálculos.

```c#

class Coche
{
    // Variables de instancia
    public string Marca;
    public string Modelo;
    public int Año;

    // Constructor
    public Coche(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    // Método para obtener una descripción del coche
    public string ObtenerDescripcion()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}";
    }
}
```



### Más sobre: Tema
##### [[Clase-Estructura-Instancia-Relacion|Relacion entre las variables de instancia y sus métodos]]

 