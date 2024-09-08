---
modificado: 2024-08-17
Enlace:
  - "[[SQL]]"
tags:
---
`DEFAULT` se utiliza para asignar un valor predeterminado a una columna cuando se crea una tabla o se modifica una existente.

Este valor se utiliza si no se especifica un valor explícito para la columna durante una operación de inserción.

#### Ejemplo
``` sql
CREATE TABLE Empleados ( id INT PRIMARY KEY, nombre VARCHAR(100), salario DECIMAL(10, 2) DEFAULT 50000.00 ); 
-- Insertar sin especificar salario, el valor por defecto será usado 

INSERT INTO Empleados (id, nombre) VALUES (1, 'Juan Pérez');

```

