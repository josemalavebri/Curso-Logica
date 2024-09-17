---
modificado: 2024-09-16
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Tipos de herencia]]"
---
La **herencia jerárquica** ocurre cuando varias subclases heredan de una misma clase base. 

En este escenario, todas las subclases comparten los atributos y métodos de la clase base, pero cada una puede tener su propio comportamiento específico.

```c#
class Animal {
    public void mover() {
        System.out.println("El animal se mueve.");
    }
}

class Perro : Animal {
    public void ladrar() {
        System.out.println("El perro ladra.");
    }
}

class Gato : Animal {
    public void maullar() {
        System.out.println("El gato maúlla.");
    }
}

Perro miPerro = new Perro();
miPerro.mover();  // Heredado de Animal
miPerro.ladrar();  // Método de Perro

Gato miGato = new Gato();
miGato.mover();  // Heredado de Animal
miGato.maullar();  // Método de Gato

```


x