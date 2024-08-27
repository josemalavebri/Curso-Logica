Lo que básicamente quiere la refactorización o busca es mejorar el código sin crear funcionalidades nuevas teniendo algo más simple y ordenado

Transforma un código desordenado en un código limpio y con un diseño simple Transforma un código desordenado en un código limpio y con un diseño simple

---


Dirty Code Dirty Code Básicamente el dirty code es el resultado de la inexperiencia de plazos ajustados de a mala gestión lo que hace que los programadores tengan que tomar decisiones deficientes en el proceso del desarrollo de software.

---
Code smells básicamente son los indicadores de que algo está mál en el codigo y son fáciles de detectar
pero pueden ser sintomas de algo más profundo

---

Refactoring techniques
También existe en las técnicas de refactorización Que son cosas que tienen que usarse con precaución porque pueden tener pros y contras

---

clean code
Un código que esté limpio es fácil de leer Comprender y mantener y también aumenta la calidad Del Producto 1


---
Hay una regla bastante interesante que dice cuando se hace algo por primera vez simplemente se hace cuando se hace por segunda vez hay que tener vergüenza de hacerlo y cuando seas 3era vez hay que empezar a refactorizar

---

cuando Refactorizamos
cuando agregamos una nueva característica
Cuando corregimos un error bugs

---

Técnicas de refactorización
Composing Methods

Gran parte de las refactorización se dedica a componer Métodos correctamente En algunos casos los métodos son muy largos En otros ocultan la lógica de ejecución Y hace que esto sea difícil de entender

El Elimina la duplicación del código y allanan el camino para futuras Mejoras

----
	1 extract method
	La extracción del metodo consiste en extraer Una utilización de Un método ¿Y? Y separarlo en otro Cuantas más líneas de código tiene un método es más Complejo y difícil de mantener Alguna vez se puede extraer la lógica de un método en pequeñas partes
	Hay que darle un nombre a este nuevo método sea el libre
	Con estos Se mejora la duplicación del código ya que puede ser reutilizado en otros lugares
	Logró aislar parte de código de forma independiente Para buscar mejor lo que son los errores
	problema:
	![[Pasted image 20240623095345.png]]
	 solucion
	 ![[Pasted image 20240623095357.png]]
	 Vou Pesetas