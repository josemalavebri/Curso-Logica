

//Primera parte

//Comentar la ejecucion paso a paso 

void principal(){
    string persona1 = "Maria";
    if(PersonaEsRelajosa(persona1)){
        Console.WriteLine("EstaPersonaSeraExpulsada");
    }

    string persona2 = "Falconi";

    if(PersonaEsRelajosa(persona)){
        Console.WriteLine("EstaPersonaSeraExpulsada");
    }
}

bool PersonaEsRelajosa(string Persona){

    if(Persona=="Maria"){
        return true;
    }
     if(Persona=="Falconi"){
        return false;
    }
}


//Comentar la ejecucion paso a paso 
void principal(){
    string nombre = "Jose";
    int edad = 19;
    VerificarMayorDeEdadPersona(nombre,edad);
    
}


void VerificarMayorDeEdadPersona(string nombre,int edad){
    
    if(edad>=18){
        CrearCertificado(nombre,edad);
        
    }else{
        Console.WriteLine("No es mayor de edad para crear un certificado");
    }
}

string CrearCertificado(string nombre,int edad){
    string certificado = ""+nombre+"-"+CrearNumeroSerie();
    return certificado;
}

string CrearNumeroSerie(){
    string numeroCertificado = "09";
    // Crear una instancia de la clase Random
    Random random = new Random();
    for(int i = 1; i<=10;i++){
        // Generar un número aleatorio entre 0 y el valor máximo de un entero (int.MaxValue)
        int randomInt = random.Next(0, 10);
        string numeroCertificadoTemporal = numeroCertificado+randomInt;
        numeroCertificado = numeroCertificadoTemporal;

    }
    return numeroCertificado;
}


//Segunda parte practica


//que imprime el siguiente while
int i=1;
while(){

}


//que imprimen los siguientes for

for(int i = 0; i<5;i++){
    Console.WriteLine(i);
}


int b = 10;
for(int i = 0; i<5;i++){
    Console.WriteLine(b);
}


int b = 4;
for(int i = 0; i<5;i++){
    Console.WriteLine(b);
}

int horaTrabajar(){
    return 6;
}

int horaSalida(){
    return 15;
}

for(int i = horaTrabajar(); i<=horaSalida();i++){
    Console.WriteLine("Trabajando...");
}


int a = horaSalida();
while(a <= horaSalida()){
    Console.WriteLine("Trabajando...");
    a--;
}


 
 