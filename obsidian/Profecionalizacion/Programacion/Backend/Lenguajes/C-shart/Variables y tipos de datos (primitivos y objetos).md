- **`var`**:
    
    - Las variables declaradas con **`var`** se elevan (hoisting) al principio de su contexto de ejecución, pero se inicializan con **`undefined`**.
    - Esto puede llevar a comportamientos inesperados si se intenta usar una [[variable]] antes de su declaración.
    
- **`let`** y **`const`**:
    
    - También se elevan, pero no se inicializan hasta que la ejecución llega a la línea de código donde están definidas.
    - Usar la variable antes de su declaración resulta en un **`ReferenceError`**.

- Ejemplo con **`var`**:
    
    ```jsx
    console.log(a); // undefined, la declaración de var se eleva pero no se inicializa
    var a = 5;
    
    ```

- Ejemplo con **`let`**:
    
    ```js
    console.log(b); // ReferenceError: b is not defined, b no está accesible antes de su declaración
    let b = 5;
    
    ```



Parte del [[Temario de JavaScript]]
