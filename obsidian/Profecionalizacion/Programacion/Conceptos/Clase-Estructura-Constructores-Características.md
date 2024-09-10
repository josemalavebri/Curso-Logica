---
modificado: 2024-09-09
tags:
  - Comprendido
Regreso:
  - "[[Clase-Estructura-Constructores]]"
---
#### **Características**

+ **Mismo nombre que la clase**: Un constructor debe tener el mismo nombre que la clase en la que está definido.
    
+ **Sin valor de retorno**: Los constructores no tienen tipo de retorno, ni siquiera `void`. Esto es lo que los diferencia de otros métodos.
    
+ **Se ejecutan automáticamente**: Los constructores se ejecutan automáticamente cuando se crea una nueva instancia de la clase utilizando `new`.
    
+ **Sobrecarga de constructores**: Una clase puede tener múltiples constructores (sobrecargados), cada uno con diferentes parámetros. Esto permite crear objetos de diferentes maneras, dependiendo de los argumentos proporcionados al constructor.
    
+ **Constructor predeterminado**: Si no defines un constructor explícitamente, el compilador crea un constructor predeterminado (vacío) automáticamente. Este constructor no inicializa ninguna [[variable]], pero permite la creación de objetos de la clase.
    
+ **Constructor por defecto**: Si no hay constructores definidos en una clase, C# proporciona un **constructor por defecto sin parámetros** que no hace nada más que permitir la instanciación del objeto.
    
+ **Modificadores de acceso**: Los constructores pueden tener modificadores de acceso como `public`, `private`, `protected`.


