using proyecto;

using proyecto.persona;
using proyecto.gelatina;


int numero  = 2;
int numero2 = 2;
int numero3 = 3;

//TipoDatoClasePersona - variable
Persona persona = new Persona();
Persona persona2 = new Persona();
Persona persona3 = new Persona();
Persona persona4;


persona.edad = 21;
persona.nombre = "jose";
persona.apellido = "malave";

persona2.edad = 22;
persona2.nombre = "juan";
persona2.apellido = "rogriguez";
persona2.saltar();



Gelatina gelatinaMari = new Gelatina();
gelatinaMari.color = "azul";
gelatinaMari.espezor = 0;
gelatinaMari.sabor = "malo";



int asignacionValor(int numeroAsignacion,int numero){
    numeroAsignacion = numero;
    return numeroAsignacion;
}


int numeroAsignacion = 0;

int numeroFinal = asignacionValor(numeroAsignacion, 3);

Console.WriteLine(numeroFinal);

Gelatina gelatinaMalave = new Gelatina();
gelatinaMalave.color = "rojo";
gelatinaMalave.espezor = 1;
gelatinaMalave.sabor = "bueno";


Gelatina asignacionValorReferencia(Gelatina gelatina ,Gelatina gelatinaMalave){
    gelatina = gelatinaMalave;
    return gelatina;
}

Gelatina gelatina = new Gelatina();
gelatina = asignacionValorReferencia(gelatina, gelatinaMalave);
Console.WriteLine(gelatina);
Console.WriteLine(gelatina);
int getinaEspezor = gelatina.dobleDelEspezor(gelatina.espezor,gelatina.espezor);



Operaciones operaciones = new Operaciones();
operaciones.numero1 = 1;
operaciones.numero2 = 2;
return operaciones.sumarNumeros();

List<int> ints = new List<int>();
List<int> ints2 = new List<int>();


public class Operaciones{

    public int numero1;
    public int numero2;

    public int sumarNumeros(){
        return numero1+numero2;
    }

    public int restaNumeros(){
        return numero1-numero2;
    }

    public int multiplicarNumerosTriple(int numero){
        return numero*numero*numero;
    }

}



namespace proyecto.gelatina;
public class Gelatina {

    public int espezor;
    public string sabor;
    
    public string color;

    public int dobleDelEspezor(int numero1,int numero2){
        Operaciones operaciones = new Operaciones();
        operaciones.numero1 = numero1;
        operaciones.numero2 = numero2;
        return operaciones.sumarNumeros();
    }


    public int multiplicarEspezor(){
        Operaciones operaciones = new Operaciones();
        return operaciones.multiplicarNumerosTriple(espezor);
    }
}




namespace proyecto.persona;

//modificador de acceso - TipoDatoClase
public class Persona {

    public int edad;
    public string nombre;    
    public string apellido;


    public Persona(){
    }

    public void saltar(){
        Console.WriteLine("persona saltando...");
    }

    public int multiplicarEdad(){
        Operaciones operaciones = new Operaciones();
        return operaciones.multiplicarNumerosTriple(edad);
    }

}


