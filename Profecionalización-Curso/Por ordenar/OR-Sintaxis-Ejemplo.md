---
modificado: 2024-08-29
tags:
  - Comprendido
Regreso:
  - "[[OR]]"
---
#### Sintaxis básica

```c#
expresión1 || expresión2

```
#### Ejemplo básico
```c#
bool esAdmin = false;
bool esUsuarioRegistrado = true;

if (esAdmin || esUsuarioRegistrado) {
    Console.WriteLine("Tienes acceso al sistema.");
}

```