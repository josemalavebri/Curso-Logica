

//Verificar que imprimen los siguientes metodos (True o false)
bool bandera = confirmarMetodo(5,2);

bool confirmarMetodo(int numero1,int numero2){
    bool bandera = numero1 > numero2;
    if((numero1 > numero2) && (numero2 < numero1)){
        return bandera;
    }
    return numero1 > numero2;
}

Console.WriteLine(bandera);

bool bandera2 = confirmarMetodo2(5,2,1);

bool confirmarMetodo2(int numero1,int numero2, int numero3){
    bool bandera2 = (numero1 > numero3) && (numero2 > numero3);
    if((numero1 > numero3) && (numero2 > numero3)){
        return bandera;
    }
    return (numero1 > numero3) && (numero2 > numero3);
}

Console.WriteLine(bandera);

bool bandera3 = confirmarMetodo3(1,5,7);

bool confirmarMetodo3(int numero1,int numero2, int numero3){
    bool bandera3 = (numero1 == numero2) && ( numero1> numero3);
    if((numero1 == numero2) && (numero3 > numero1) && bandera3){
        return bandera;
    }
    return (numero1 == numero2) && (numero3 > numero1);
}

Console.WriteLine(bandera); 


///SEGUNDO EJERCICIO - VERIFICAR QUE IMPRIME LA CONSOLA
///
bool bandera5 = verificarAcceso();

bool verificarAcceso() {
    if ((comprobarContraseña() == false) && validarContraseña() && esUsuarioRegistrado()) {
        Console.WriteLine("Puede entrar al sistema");
        return true;
    }
    return false;
}

bool comprobarContraseña(){
    return false;
}

bool validarContraseña(){
    string contraseñaIngresada = "abc123";
    string contraseñaValida = "abc123";
    
    return contraseñaIngresada == contraseñaValida;
}

bool esUsuarioRegistrado(){
    return true;
}

Console.WriteLine(bandera);


//TERCER EJERCICIO  - COMENTAR CODIGO

int entero = metodo1();

int metodo1(){
    return metodo2();
}

int metodo2(){
    int numero = 10;
    return metodo3(numero);
}

int metodo3(int numero){
    if(numero == 1){
        return metodo4(numero);
    }

    Console.WriteLine(numero * 2); 
    return metodo3(numero - 1); 
}

int metodo4(int numero){
    return numero + 1;
}

Console.WriteLine(entero); 

