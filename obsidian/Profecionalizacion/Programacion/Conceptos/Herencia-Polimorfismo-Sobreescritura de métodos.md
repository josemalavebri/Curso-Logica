---
modificado: 2024-09-17
tags:
  - Comprendido
Flujo-Regreso:
---
La sobreescritura (o overriding) es cuando una subclase proporciona una implementación específica de un método que ya está definido en su clase base.

La implementación de la subclase reemplaza la versión de la clase base.

```c#
public class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra.");
    }
}

```

