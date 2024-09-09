
//Uso de constructores
Empleado empleado = new Empleado("Jose");
Empleado empleado2 = new Empleado();


//Uso correcto de la instancia
intanciaEmpleado();
empleado.CambiarNombre(empleado);



Empleado empleadoInstancia;
void intanciaEmpleado(){
    empleadoInstancia = new Empleado("Jose");
}