Los **[[Tipos de datos]] compuestos** son tipos de datos que se construyen a partir de otros tipos de datos más simples o [[Tipos de datos Primitivos]]. A diferencia de los tipos de datos primitivos, que almacenan un solo valor (como un número o un carácter), los tipos compuestos pueden almacenar [[colecciones]] de valores o estructuras más complejas que pueden contener diferentes tipos de datos.


1. **Arrays (Matrices)**: Una colección de elementos del mismo tipo almacenados en posiciones contiguas de la memoria.
    
    `int[] numeros = { 1, 2, 3, 4, 5 }; // Array de enteros`
    
2. **Classes (Clases)**: Una estructura que agrupa datos (campos) y comportamiento (métodos) en un solo tipo de dato. Representan objetos en la [[programación]] orientada a objetos.
    
    `class Persona {     public string Nombre { get; set; }     public int Edad { get; set; } }`
    
3. **Structs (Estructuras)**: Similar a las clases, pero con menos sobrecarga. Se utilizan para agrupar datos relacionados y suelen ser más ligeras que las clases.
    
    `struct Punto {     public int X;     public int Y; }`
    
4. **Enums (Enumeraciones)**: Un conjunto de constantes con nombre que representan un conjunto de valores posibles para un tipo de dato.
    
    `enum DiasSemana { Lunes, Martes, Miercoles, Jueves, Viernes }`
    
5. **Tuplas (Tuples)**: Un conjunto ordenado de elementos, que pueden ser de diferentes tipos. Son útiles para devolver múltiples valores desde un método.
    
    `var persona = (Nombre: "Juan", Edad: 25);`
    
### Ejemplo Práctico con una Clase


`class Coche {     public string Marca { get; set; }     public string Modelo { get; set; }     public int Año { get; set; } }  Coche miCoche = new Coche {     Marca = "Toyota",     Modelo = "Corolla",     Año = 2020 };`

En este ejemplo, `Coche` es un tipo de dato compuesto que agrupa varios tipos de datos primitivos (`string` y `int`) en una estructura más compleja.