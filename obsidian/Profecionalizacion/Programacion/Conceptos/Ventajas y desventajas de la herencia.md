---
modificado: 2024-09-16
tags:
  - Comprendido
Flujo-Regreso:
---


1. **Reutilización del código:** Los atributos y métodos de la clase base pueden ser reutilizados por las subclases sin tener que reescribirlos
    
2. **Mantenimiento más sencillo:** Las modificaciones en la clase base automáticamente afectan a todas las subclases, lo que facilita la corrección de errores y la introducción de nuevas funcionalidades.
    
3. **Organización lógica:** Facilita la estructura de jerarquías claras en sistemas complejos, donde las relaciones "es un" entre objetos se pueden modelar de forma natural.
    
4. **Polimorfismo:** La herencia es un pilar para el polimorfismo, hace que el codigo sea mas flexible al tratar varios objetos de forma común
    

**Desventajas de la herencia:**

1. **Herencia excesiva:** Si una jerarquía de clases se vuelve demasiado profunda (demasiadas capas de herencia), puede hacer que el código sea difícil de seguir y mantener. A menudo, demasiada herencia crea dependencia innecesaria entre clases.
    
2. **Rigidez en la jerarquía:** Los cambios en la clase base pueden tener efectos no deseados en las subclases, lo que puede causar problemas en sistemas grandes.
    
3. **Falta de flexibilidad:** Una vez que se establece una jerarquía de herencia, es difícil de cambiar sin afectar a todo el sistema. A veces, la **composición** (relación "tiene un") puede ser una mejor opción que la herencia para evitar estos problemas.
    
4. **Sobrecarga de métodos innecesarios:** Al heredar métodos que no son útiles para la subclase, puedes terminar con métodos que no tienen relevancia, lo que añade complejidad innecesaria.


