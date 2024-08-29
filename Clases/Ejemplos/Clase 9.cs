

/*
int number = 5;
int result = Factorial(number);

int Factorial(int n)
{
    if (n == 1)
        return 1;
    else{
        Console.WriteLine("ahora number es: " +n);

        return n * Factorial(n - 1);
    }
}

*/
/*
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

    Console.WriteLine(numero);
    return metodo3(numero-1);

}

int metodo4(int numero){
    return numero+1;
}

Console.WriteLine("el nuemero final "+entero);

*/

int divicion = 0/2;

bool bandera = confirmarMetodo(5,2);

bool confirmarMetodo(int numero1,int numero2){

    bool bandera = numero1 > numero2;
    if(! (numero1 > numero2) || (numero2>numero1) ){
        return bandera;
    }
    return numero1 > numero2;
}

Console.WriteLine(bandera);


//AND

string contraseñaValida = "jose1234";
string contraseñaIngresada = "se1234";

bool usuarioRegistrado = true;

if( (comprobarContraseña()==false) &&  (contraseñaIngresada==contraseñaValida) && usuarioRegistrado){
    Console.WriteLine("Puede entrar al sistema");
}

bool comprobarContraseña(){
    return true;
}
