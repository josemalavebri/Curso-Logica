---
modificado: 2024-09-01
tags:
  - Comprendido
Regreso:
  - "[[Static Class]]"
---


Son ideales para funcionalidades globales y utilitarias que no necesitan mantener datos entre invocaciones, como funciones matemáticas o constantes. 

Su uso simplifica el acceso a estas funcionalidades, ya que no es necesario crear una [[Instancia]] de la clase.

Es importante usar clases `static` con moderación, ya que pueden llevar a un estado global compartido que dificulta el mantenimiento y la prueba del código. 

Carecen de flexibilidad para extenderse o implementar interfaces

Deben ser reservadas en los casos que no se requiera el manejo de estado, herencia o polimorfismo, y donde el acceso global no implique riesgos de acoplamiento y dependencia excesiva.