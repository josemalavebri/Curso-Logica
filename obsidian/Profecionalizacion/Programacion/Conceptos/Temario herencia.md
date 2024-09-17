#### **. Herencia y el principio de sustitución (Polimorfismo)**

- **4.1. Polimorfismo y la relación con la herencia**
    - Definición de polimorfismo
    - Cómo la herencia facilita el polimorfismo
- **4.2. El principio de sustitución de Liskov (LSP)**
    - Explicación del principio LSP
    - Ejemplos donde subclases pueden ser usadas en lugar de la clase base sin romper el código
- **4.3. Sobrecarga de métodos**
    - Concepto de sobrecarga de métodos
    - Diferencia entre sobrecarga y sobrescritura (overriding)
- **4.4. Sobrescritura de métodos (Overriding)**
    - Uso de métodos en la clase hija que reemplazan los de la clase padre
    - Cómo aplicar el uso de `virtual` y `override` en lenguajes como C# y Java

#### **5. Accesibilidad en la herencia**

- **5.1. Modificadores de acceso**
    - Public, private, protected y su impacto en la herencia
- **5.2. Control de acceso en clases derivadas**
    - Qué atributos y métodos son accesibles en las subclases
    - Cómo proteger datos sensibles con `private` y `protected`
- **5.3. Métodos y atributos `protected`**
    - Qué son los métodos `protected`
    - Casos donde `protected` es útil en herencia
- **5.4. Clases y métodos `sealed` (C#) o `final` (Java)**
    - Evitar la herencia no deseada con `sealed` y `final`
    - Ejemplos y beneficios del uso de clases selladas o métodos finales

#### **6. Constructores y herencia**

- **6.1. Constructores en la herencia**
    - Cómo se llaman los constructores de las clases base y derivadas
- **6.2. Uso de `base` y `super` en herencia**
    - Cómo llamar al constructor de la clase padre desde la clase hija (uso de `super` o `base`)
    - Orden de ejecución de constructores en jerarquías de herencia
- **6.3. Sobrecarga de constructores en herencia**
    - Definir múltiples constructores en clases padre e hija
    - Ejemplos de constructores con parámetros y sin parámetros
- **6.4. Inicialización de atributos heredados**
    - Cómo los atributos de la clase padre se inicializan en la clase hija
    - Control sobre la inicialización con constructores parametrizados

#### **7. Relaciones “es un” y “tiene un”**

- **7.1. Relación "es un" (Herencia)**
    - Definición y ejemplos de la relación “es un”
    - Por qué la herencia representa la relación “es un”
- **7.2. Relación "tiene un" (Composición)**
    - Diferencia entre herencia y composición
    - Cuándo usar herencia y cuándo usar composición
- **7.3. Buenas prácticas para decidir entre herencia o composición**
    - Ventajas de la composición sobre la herencia en ciertos casos
    - Ejemplos donde la herencia puede ser un mal diseño

#### **8. Herencia en el diseño de software**

- **8.1. Principios SOLID en relación con la herencia**
    - Principio de Responsabilidad Única (SRP)
    - Principio de Sustitución de Liskov (LSP)
- **8.2. Evitar la herencia profunda (anti-pattern)**
    - Problemas de herencia excesiva
    - Soluciones para evitar la herencia profunda
- **8.3. Aplicación de interfaces y clases abstractas**
    - Definición de interfaces y clases abstractas
    - Diferencias entre interfaces y herencia de clases
- **8.4. Diseño basado en herencia vs. diseño basado en interfaces**
    - Ventajas y desventajas de cada enfoque
    - Ejemplos de aplicaciones de cada uno

#### **9. Herencia múltiple y el problema del diamante**

- **9.1. Qué es el problema del diamante**
    - Explicación del problema del diamante en herencia múltiple
- **9.2. Cómo lenguajes como C++ y Python manejan la herencia múltiple**
    - Ejemplos de herencia múltiple en C++ y Python
    - Soluciones al problema del diamante: uso de clases virtuales
- **9.3. Alternativas a la herencia múltiple**
    - Uso de interfaces y mixins como alternativas

#### **10. Herencia en patrones de diseño**

- **10.1. Patrón de diseño Template Method**
    - Explicación del patrón Template Method
    - Aplicación práctica con herencia
- **10.2. Patrón de diseño Strategy y relación con herencia**
    - Cómo el patrón Strategy utiliza la herencia para el polimorfismo
- **10.3. Patrón Factory y uso de herencia**
    - Ejemplos del uso de herencia en fábricas de objetos
- **10.4. Otros patrones de diseño que utilizan herencia**
    - Patrón Decorator
    - Patrón Observer

#### **11. Ejercicios prácticos y aplicaciones de la herencia**

- **11.1. Ejercicios prácticos con herencia simple**
    - Implementación de una jerarquía de clases sencilla
    - Ejemplo: Clases de animales con métodos comunes
- **11.2. Ejercicios avanzados de herencia multinivel**
    - Creación de jerarquías complejas
    - Ejemplo: Clases de vehículos (bicicleta, coche, motocicleta)
- **11.3. Implementación de un sistema usando herencia e interfaces**
    - Ejemplo de un sistema de gestión de empleados
- **11.4. Resolución de problemas de herencia múltiple**
    - Ejercicios que simulan la herencia múltiple en Python y C++