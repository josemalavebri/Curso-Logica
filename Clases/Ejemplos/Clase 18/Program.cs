// See https://aka.ms/new-console-template for more information


Persona persona = new Persona();
Empleado empleado = new Empleado();
Gerente gerente = new Gerente();
GerenteGeneral gerenteGeneral = new GerenteGeneral();

saltarPersonas(persona);
saltarPersonas(empleado);
saltarPersonas(gerente);
saltarPersonas(gerenteGeneral);

void saltarPersonas(Persona persona){
    persona.saltar();
}


string nombre = "jose";
int numero = 1;

nombre.GetType();
numero.GetType();

List<int >lista;

HashSet<int> listaHash;

lista.Add();
listaHash.Add();
