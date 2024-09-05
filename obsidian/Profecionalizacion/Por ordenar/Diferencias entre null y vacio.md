La diferencia principal radica en cómo representan el estado de una variable. La cadena puede generar errores, ya que no hay un objeto sobre el cual trabajar.


```c#
string cadena = null;  
// La variable cadena no tiene ninguna referencia o valor

```


#### Vacío (`""` o `string.Empty`)**:

- En el contexto de cadenas, **vacío** es un valor válido que representa una cadena de **longitud cero**, es decir, una cadena que no contiene ningún carácter, pero **existe**.

- Una cadena vacía es una instancia válida de una cadena, por lo que se puede acceder a sus propiedades, como su longitud.
```c#
string cadena = "";  // La variable cadena tiene una cadena vacía

```

#### Ejemplo de operaciones

```c#
// Cadena vacía

string texto = "";
Console.WriteLine(texto.Length);  

string textoNull = null;
//Error null
Console.WriteLine(textoNull.Length); 
```