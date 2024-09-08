---
modificado: 2024-09-02
tags:
  - Comprendido
Regreso:
  - "[[-.NET-Compilador]]"
---

Cuando se compila el código C#, el compilador lo convierte en **CIL (Common Intermediate Language)**, también conocido como **MSIL** (Microsoft Intermediate Language). 

El CIL es el código que es independiente de la plataforma y es ejecutado por el **Common Language Runtime (CLR)**.


```c
.method public hidebysig static void Main() cil managed
{
    .entrypoint
    ldstr "Hola, Mundo!"
    call void [mscorlib]System.Console::WriteLine(string)
    ret
}

```


