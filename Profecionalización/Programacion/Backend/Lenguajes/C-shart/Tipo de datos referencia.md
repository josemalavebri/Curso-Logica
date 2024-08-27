Los [[Tipos de datos]] de referencia almacenan una referencia a los datos, que se encuentran en el montón de memoria ([[heap]]). Cuando copias un tipo de referencia, estás copiando la referencia, no los datos en sí.
**Clases y Objetos**

- **`class`**: Define un tipo de referencia que puede contener métodos, propiedades, eventos y otros miembros.

    `class Persona {     public string Nombre { get; set; }     public int Edad { get; set; } }`
####  **Cadenas**

- **`string`**: Una secuencia inmutable de caracteres Unicode. Se comporta como un tipo de referencia, pero tiene algunas características de tipo de valor.

####  **Matrices**

- **`array`**: Una colección de elementos del mismo tipo.
    
    `int[] numeros = { 1, 2, 3, 4, 5 };`
    
#### **Interfaces**

- **`interface`**: Define un contrato que una clase o struct puede implementar.
    
    `interface IMovil {     void Mover(); }`
    
####  **Delegados**

- **`delegate`**: Un tipo que representa referencias a métodos con una lista de parámetros y un [[tipo de retorno]] específico.

####  **Tipos Nulos**

- **`Nullable<T>`**: Permite que un tipo de valor pueda contener `null`. Es útil en bases de datos y en situaciones donde un valor podría ser opcional.
    
    `int? edad = null;`
    
### **Tipos de Referencia Internos**

- **`object`**: El tipo base para todos los tipos de C#. Todos los tipos heredan de `object`.
- **`dynamic`**: Se resuelve en tiempo de ejecución, permitiendo la flexibilidad de cambiar el tipo en el tiempo de ejecución.