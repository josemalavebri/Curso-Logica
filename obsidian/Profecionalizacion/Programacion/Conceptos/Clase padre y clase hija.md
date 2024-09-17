La clase que contiene estos atributos hereditarios son las clases base, clases padre o la superclase de la clase hija

La clase que a la estamos heredando este comportamiento y propiedades se convierte en una clase hija, subclase o clase derivada

- **Clase Base (Superclase):** Es la clase que contiene la definición de los atributos y métodos que pueden ser reutilizados por otras clases. Esta clase contiene la lógica común que será compartida.
    
- **Clase Derivada (Subclase):** Es la clase que hereda de una clase base. Las clases derivadas pueden extender el comportamiento de la clase base añadiendo nuevos atributos y métodos, o pueden sobrescribir los existentes.

Normalmente a la versión que heredamos, es una clase mucho mas especifica en comparación de la clase padre que es una clase mucho mas abstracta o general


### Ejemplo en c# 
```c#
// Clase base
public class Vehiculo {
    
}

// Clase derivada
public class Coche : Vehiculo {
    
}


```