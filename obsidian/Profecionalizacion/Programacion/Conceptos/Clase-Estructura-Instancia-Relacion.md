---
modificado: 2024-09-09
tags:
  - Comprendido
Regreso:
  - "[[Clase-Estructura-Instancia]]"
---
Los métodos de una clase pueden acceder y modificar las **variables de instancia**. Esto permite que un objeto mantenga un estado y que los métodos interactúen con ese estado.

#### Ejemplo de modificación de variables de instancia:

Vamos a agregar un método que permita cambiar el modelo del coche.

```c#
class Coche
{
    public string Marca;
    public string Modelo;
    public int Año;

    public Coche(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public string ObtenerDescripcion()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}";
    }

	    // Método para cambiar el modelo del coche
    public void CambiarModelo(string nuevoModelo)
    {
        Modelo = nuevoModelo;
    }
}

Coche coche1 = new Coche("Toyota", "Corolla", 2020);
coche1.CambiarModelo("Camry");
Console.WriteLine(coche1.ObtenerDescripcion());  // Marca: Toyota, Modelo: Camry, Año: 2020

```


