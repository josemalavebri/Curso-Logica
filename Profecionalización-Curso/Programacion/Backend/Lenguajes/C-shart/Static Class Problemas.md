---
fecha: 2024-07-13
Enlace:
  - "[[Static Class]]"
tags:
  - NoProfundizado
Modificado: 2024-08-17
Estado:
---
Los principales problemas de las clases estáticos con:
* Concurrencia
	* Como los miembros estáticos comparten el mismo estado entre todas las instancias e hilos si varias partes del programa trata de acceder a esta clase habrán problemas.
	* ###### Ejemplo
		* Si varios hilos intentan incrementar el contador al mismo tiempo, puedes encontrarte con problemas de "race conditions" donde el valor del contador puede no ser el esperado debido a accesos concurrentes no controlados.
		* Si varios hilos intentan incrementar el contador al mismo tiempo, puedes encontrarte con problemas de "race conditions" donde el valor del contador puede no ser el esperado debido a accesos concurrentes no controlados.
		* ![[Pasted image 20240713145330.png]]
🔴	
* Testabilidad🟣
	* Investigar bien este concepto ya que tiene que ver con pruebas unitarias 
	
