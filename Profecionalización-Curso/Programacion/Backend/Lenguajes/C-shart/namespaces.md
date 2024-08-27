---
modificado: 2024-08-18
tags:
  - Investigar
  - NoEstructura
  - NoProfundizado
Regreso:
---
#Comprendido 
[[C-shart]]

Los namespace sirven para agrupar las clases  interfaces, structs, enums, y otros namespaces relacionados entre sí y organizar el código en grupos lógicos, 

Todos los namespaces pertenecen a un asembley

---
#### Uso básico

```c#
namespace Grupo A{
	class Prueba{
	}
}

namespace GrupoB
{
//namespace aniddado
	namespace GrupoC
	{
	//misma clase en diferente namespace
		class Prueba{
		}
	}
}

class Entrada {
	static void Main()
	{
	GrupoA.Prueba
	GrupoB.GrupoC.Prueba
	}
}

```