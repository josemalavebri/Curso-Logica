---
modificado: 2024-09-08
tags:
  - Comprendido
Regreso:
  - "[[StreamReader]]"
---
#### Sintaxis Básica
```c#
using System.IO;
using (StreamReader reader = new StreamReader("ruta_del_archivo.txt")) {
// Leer operaciones aquí 
}
```

#### Ejemplo básico
```c#
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Ruta del archivo a leer
        string path = "example.txt";

        // Asegúrate de que el archivo existe
        if (File.Exists(path))
        {
            // Crear un StreamReader para leer el archivo
            using (StreamReader reader = new StreamReader(path))
            {
                // Leer y mostrar todo el contenido del archivo
                string content = reader.ReadToEnd();
                Console.WriteLine("Contenido del archivo:");
                Console.WriteLine(content);
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
}

```

