+ **Caso Base**: Toda función recursiva necesita un caso base que termine la recursión. Sin un caso base, la función seguiría llamándose indefinidamente, lo que podría llevar a un desbordamiento de pila (stack overflow).
    
+  **División del Problema**: El problema se divide en subproblemas más pequeños que son similares al problema original, y la función se llama recursivamente para resolver esos subproblemas.
    
+  **Acumulación de Resultados**: En algunas funciones recursivas, los resultados de las subllamadas se acumulan y combinan para formar la solución final.
    
+ **Pila de Llamadas**: Cada llamada recursiva se almacena en la pila de llamadas, lo que consume memoria. Por lo tanto, las funciones recursivas deben manejarse con cuidado para evitar problemas de rendimiento y errores de desbordamiento de pila.