---
modificado: 2024-09-09
tags:
  - Comprendido
Regreso:
  - "[[Clase-Estructura-Constructores]]"
---
#### Sintaxis básica

```c#
public NombreClase(parametros) {
	//Cuerpo del contructor
}
```
#### Ejemplo básico
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

    public void CambiarModelo(string nuevoModelo)
    {
        Modelo = nuevoModelo;
    }
}

Coche coche1 = new Coche("Toyota", "Corolla", 2020);
coche1.CambiarModelo("Camry");
Console.WriteLine(coche1.ObtenerDescripcion());  
// Marca: Toyota, Modelo: Camry, Año: 2020

```