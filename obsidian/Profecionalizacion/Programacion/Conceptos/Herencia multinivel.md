---
modificado: 2024-09-16
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Tipos de herencia]]"
---
La **herencia multinivel** ocurre cuando una clase hereda de otra clase que a su vez hereda de una tercera clase. 

Este tipo de herencia implica una cadena jerárquica de herencia, donde una clase derivada se convierte en la base para otra subclase.
```c#
public class Animal {
    public void Comer() {
        Console.WriteLine("El animal come.");
    }
}

public class Mamifero : Animal {
    public void Amamantar() {
        Console.WriteLine("El mamífero amamanta a sus crías.");
    }
}

public class Perro : Mamifero {
    public void Ladrar() {
        Console.WriteLine("El perro ladra.");
    }
}

Perro miPerro = new Perro();
miPerro.Comer();      // Heredado de Animal
miPerro.Amamantar();  // Heredado de Mamifero
miPerro.Ladrar();     // Definido en Perro

```