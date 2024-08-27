---
modificado: 2024-08-18
tags:
  - Secundario
---
#### Sintaxis básica de Xdocument
```c#
using System.Xml.Linq;

XDocument doc = new XDocument(
    new XDeclaration("1.0", "utf-8", "yes"),
    new XElement("Root",
        new XElement("Child",
            new XAttribute("Id", 1),
            new XElement("Name", "John Doe"),
            new XElement("Age", 30)
        ),
        new XElement("Child",
            new XAttribute("Id", 2),
            new XElement("Name", "Jane Smith"),
            new XElement("Age", 25)
        )
    )
);

// Guardar el documento en un archivo
doc.Save("example.xml");

```
#### Ejemplo básico
```c#
using System.Xml.Linq;

XDocument doc = new XDocument(
    new XDeclaration("1.0", "utf-8", "yes"),
    new XElement("Personas",
        new XElement("Persona",
            new XAttribute("Id", 1),
            new XElement("Nombre", "Juan Pérez"),
            new XElement("Edad", 30)
        ),
        new XElement("Persona",
            new XAttribute("Id", 2),
            new XElement("Nombre", "Ana Gómez"),
            new XElement("Edad", 25)
        )
    )
);

// Guardar el documento en un archivo
doc.Save("personas.xml");

```

#### Cargar un [[Documento XML]]
```c#
XDocument doc = XDocument.Load("example.xml");
```
#### Modificar Xdocument
```c#
XDocument doc = XDocument.Load("example.xml");

// Agregar un nuevo elemento
doc.Root.Add(new XElement("Child",
    new XAttribute("Id", 3),
    new XElement("Name", "Alice Johnson"),
    new XElement("Age", 28)
));

// Cambiar un valor de un elemento
XElement firstChild = doc.Descendants("Child").First();
firstChild.Element("Name").Value = "Johnathan Doe";

// Eliminar un elemento
XElement secondChild = doc.Descendants("Child").Skip(1).First();
secondChild.Remove();

// Guardar los cambios en el archivo
doc.Save("example.xml");

```