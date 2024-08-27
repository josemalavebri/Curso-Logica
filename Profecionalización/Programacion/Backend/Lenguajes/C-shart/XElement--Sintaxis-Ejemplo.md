#### Sintaxis básica de [[XElement]] 
```c#
using System.Xml.Linq;

using System.Xml.Linq;

// Crear un elemento sin atributos ni contenido
XElement element = new XElement("ElementName");

// Crear un elemento con contenido de texto
XElement elementWithText = new XElement("ElementName", "Text Content");

// Crear un elemento con atributos y contenido de texto
XElement elementWithAttributes = new XElement("Person",
    new XAttribute("Id", 1),
    new XElement("Name", "John Doe"),
    new XElement("Age", 30)
);


```
#### Ejemplo básico 
```c#
using System.Xml.Linq;

// Crear un elemento sin atributos ni contenido
XElement element = new XElement("Name");

// Crear un elemento con contenido de texto
XElement elementWithText = new XElement("Name", "John Doe");

// Crear un elemento con atributos y contenido de texto
XElement elementWithAttributes = new XElement("Person",
    new XAttribute("Id", 1),
    new XElement("Name", "John Doe"),
    new XElement("Age", 30)
);


```

#### Cargar un [[Documento XML]]
```c#
XDocument doc = XDocument.Load("example.xml");
```
#### Crear, Modificar, Añadir, Setear atributo
```c#
XElement element = new XElement("Person",
    new XAttribute("Id", 1),
    new XElement("Name", "John Doe"),
    new XElement("Age", 30)
);

// Cambiar el valor de un atributo
element.SetAttributeValue("Id", 2);

// Cambiar el valor del contenido de texto de un elemento hijo
element.Element("Name").Value = "Jane Smith";

// Agregar un nuevo elemento hijo
element.Add(new XElement("Occupation", "Software Developer"));

// Eliminar un elemento hijo
element.Element("Age").Remove();

```