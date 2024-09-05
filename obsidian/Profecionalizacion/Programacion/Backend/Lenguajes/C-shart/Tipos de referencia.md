---
modificado: 2024-09-01
tags:
  - Comprendido
Regreso:
  - "[[Temario de C-shart]]"
---
Un tipo que se define como una `class`, es un _tipo de referencia_.

Al declarar una variable de un tipo de referencia en tiempo de ejecución, esta contendrá el valor [[null]] hasta que se cree expresamente una [[Instancia]] de la clase mediante el operador `new` o se le asigne un objeto de un tipo compatible que se ha creado en otro lugar

[[Tipos de referencia-Ejemplo]]

Cuando se crea el objeto, se asigna suficiente memoria en el montón administrado para ese objeto específico y la variable solo contiene una referencia a la ubicación de dicho objeto.

La memoria que un objeto usa la reclama la funcionalidad de administración automática de memoria de CLR, lo que se conoce como _recolección de elementos no utilizados_.

#### Relacionados:
[[Recolección de memoria]]