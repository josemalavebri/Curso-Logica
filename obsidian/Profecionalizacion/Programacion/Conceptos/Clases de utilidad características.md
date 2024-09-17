---
modificado: 2024-09-12
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Clases y Objetos]]"
---

- **Métodos estáticos**: La mayoría de los métodos de estas clases son estáticos para que puedan ser invocados sin crear instancias.

- **Sin estado**: No mantienen ningún estado interno, ya que no hay variables de instancia.

- **No deben ser instanciadas**: Para evitar la creación de instancias, muchas veces se declaran constructores privados.

- **Reutilizables**: Facilitan la reutilización del código ya que encapsulan funcionalidades comunes.

- **Generalmente final**: En algunos lenguajes, se pueden declarar como `final` para evitar la herencia y sobrecarga innecesaria.

- **Agrupación de funciones comunes**: Se suelen agrupar por propósito, como utilidades de cadenas (`StringUtils`), fechas (`DateUtils`), etc.


