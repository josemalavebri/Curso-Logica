---
modificado: 2024-09-11
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Static Class]]"
---

+ **No se puede instanciar**: No es posible crear un objeto de una clase estática utilizando `new`. Todos sus miembros se acceden directamente a través del nombre de la clase.
   
+ **Todos los miembros son estáticos**: Todos los métodos, propiedades, y campos dentro de una clase estática deben ser marcados como estáticos. No se pueden tener miembros no estáticos.
    
+ **No se puede heredar**: No se puede heredar de una clase estática, ni una clase estática puede heredar de otra clase.
    
+ **No tiene constructor de instancia**: Las clases estáticas no pueden tener constructores de instancia, ya que no se pueden crear instancias. Sin embargo, pueden tener un **constructor estático** (también llamado inicializador estático), que se ejecuta una vez cuando se accede por primera vez a cualquier miembro de la clase.