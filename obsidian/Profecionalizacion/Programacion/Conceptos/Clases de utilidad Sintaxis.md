---
modificado: 2024-09-12
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Clases y Objetos]]"
---


#### Sintaxis básica

```c#
class static NombreDeUtilidad {


    public static Retorno nombre(TipoParametro1 param1...) {
        return valor;
    }

}

```
#### Ejemplo básico
```c#
public final class MathUtils {

    public static int sumar(int a, int b) {
        return a + b;
    }

    public static int max(int a, int b) {
        return (a > b) ? a : b;
    }
}

```

