
Cuando hay múltiples condiciones que necesitan ser evaluadas, se puede usar `else if` para evaluar más de una condición:
#### Sintaxis
```c#
int temperatura = 30;

if (temperatura > 40)
{
    Console.WriteLine("Hace mucho calor.");
}
else if (temperatura > 30)
{
    Console.WriteLine("Hace calor.");
}
else if (temperatura > 20)
{
    Console.WriteLine("El clima es templado.");
}
else
{
    Console.WriteLine("Hace frío.");
}

```

#### [[Cuando usar if - else if]]
