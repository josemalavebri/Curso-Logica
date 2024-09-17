---
modificado: 2024-09-12
tags:
  - Comprendido
Flujo-Regreso:
  - "[[Static Class]]"
---
#### Sintaxis básica

```c#
public static class MiClaseEstatica
{
    public static void MetodoEstatico()
    {
        Console.WriteLine("Este es un método estático.");
    }
    
    public static int Sumar(int a, int b)
    {
        return a + b;
    }
}

```
#### Ejemplo básico
```c#
public class Calculadora
{
    public static int Sumar(int a, int b) 
    { 
        return a + b;
    }
    
    public static int Restar(int a, int b)
    {
        return a - b;
    }
}

```