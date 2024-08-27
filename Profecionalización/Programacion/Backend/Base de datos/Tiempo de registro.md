#### Datos
- **Insertar `TRUE/FALSE` (BIT):** Tamaño de 1 [[Bit]] por registro (aproximadamente 1 byte por registro en la práctica).
- **Insertar `OK` (VARCHAR(2))**: Tamaño de 2 [[Byte]] por registro.
- 40,000 Registros tanto de bit como de byte
### Cálculo de Tiempo
+ (40,000r x 1b) /40,000r = 40,000b
+ Aproximadamente 40kb
+ 40,000r X 2b) /40,000r = 80,000b
+ Aproximadamente 80kb
    
2. **Estimación del Tiempo de Inserción**
    Supongamos que el tiempo de inserción para 1 KB de datos es XX milisegundos.
    
    - **Para `TRUE/FALSE` (BIT):**
        
        - Tamaño total = 40 KB
        - Tiempo estimado = 40 KB×X milisegundos/KB=40X milisegundos40 KB×X milisegundos/KB=40X milisegundos
    - **Para `OK` (VARCHAR(2)):**
        
        - Tamaño total = 80 KB
        - Tiempo estimado = 80 KB×X milisegundos/KB=80X milisegundos80 KB×X milisegundos/KB=80X milisegundos

### Resultados Típicos

- **Tiempo de Inserción para `TRUE/FALSE` (BIT):** Aproximadamente 40X40X milisegundos.
- **Tiempo de Inserción para `OK` (VARCHAR(2)):** Aproximadamente 80X80X milisegundos