---
modificado: 2024-09-17
tags:
  - Comprendido
Flujo-Regreso:
---
El enlace dinámico ocurre en [[tiempo de ejecución]].
Cuando se llama a un método a través de una referencia de clase base, el sistema determina en tiempo de ejecución qué versión del método invocar, según el tipo real del objeto.

```c#
Animal miAnimal = new Perro();
miAnimal.HacerSonido(); // Llama a Perro.HacerSonido() en lugar de Animal.HacerSonido()

```

