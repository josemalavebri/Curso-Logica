---
modificado: 2024-09-16
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Tipos de herencia]]"
---

La **herencia simple** ocurre cuando una subclase hereda de una única clase base. 

Es el nivel más básico y común de herencia, donde una clase derivada toma los atributos y métodos de una única superclase.


```c#
public class Vehiculo {
    public void Moverse() {
        Console.WriteLine("El vehículo se mueve.");
    }
}

public class Coche : Vehiculo {
    public void TocarBocina() {
        Console.WriteLine("El coche toca la bocina.");
    }
}

```
