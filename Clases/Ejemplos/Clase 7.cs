

//ejemplo for con variable externa
int i=10;

for(i=0; j <=5 ; j++){
    Console.WriteLine(j);
}

//distantas ejecuciones de for con operadores
for(int j=0; j <=6 ; j++){
    Console.WriteLine(j);
}

for(int j=1; j <=4 ; j++){
    Console.WriteLine(j);
}

for(int j=0; j <6 ; j++){
    Console.WriteLine(j);
}


for( j=5; j >= 0 ; c--){
    Console.WriteLine(j);
}

//practicando los for

//1 hasta el 3
int a = 1;
for(; a <4 ;a++){
    Console.WriteLine(a);
}

//3 hasta el 1

for(int b = 3 ; b >= 1 ; b--){
    Console.WriteLine(b);
}
*/


//Enseñar variables por fuera y por dentro

int numeroParcial(){
    return 0;
}

string cadena = "hola";

void metodoVacio(){
    for(int numero = numeroParcial(); numero <= 1 ; numero--){
        Console.WriteLine(numero);
    }

}



//Operaciones dinamicas
void metodoVacio(){
    string cadena = "hola";

    for(int numero = cadena.length ; numero <= 1 ; numero--){
        Console.WriteLine(numero);
    }

}

//Ejemplo de while
int numeroContador = 0;

while (numeroContador <= 10) {
    Console.WriteLine(numeroContador);
    numeroContador++;
}



//While recursivo
int numeroContador2(int numero){
    return numero--;
}

int numero = 4;

while (numero >= (numeroContador2(numero))) {
    
    Console.WriteLine(numeroContador2);
    numero++;

}