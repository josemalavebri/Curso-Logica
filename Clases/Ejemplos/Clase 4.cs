
//Introduccion a funciones
int a = 12;
int b = 20;

void sumar(int a, int b){
    int suma = a+b;
    Console.WriteLine(suma);
}

//sumar(a,b);


//Tipos de funciones

//tipo de funcion sin retorno
void funcionSinRetorno(int a, int b){
    int suma = a+b;
    Console.WriteLine(suma);
}

//tipo de funcion que retorna algo
int funcionRetorno(int a, int b){
    int suma = a+b;
    return suma;
}


//tipo de funcion que retorna algo
int funcionSinParametro(){
    int suma = 10+20;
    return suma;
}


//tipo de funcion que retorna algo
int funcionConParametro(int a, int b){
    int suma = a+b;
    return suma;
}
//-------------------------//-------------------------

//Funciones que alteran estados
//estado
int entero = 0;

void funcionAlteraEstado(int valor){
     entero = valor;
     Console.WriteLine(entero);
}

void sumario(int valor){
     int resultado = entero + valor;
     Console.WriteLine(resultado);
     if(condicion){
        int resultado2 = 0;
        Console.WriteLine(resultado2);
     }


}
//-------------------------//-------------------------


//Modularidad de codigo
int resultado = entero + 10;
     Console.WriteLine(resultado);

int resultado2 = entero + 11;
     Console.WriteLine(resultado2);

sumario(10);
sumario(11);
sumario(12);
sumario(13);
sumario(14);

funcionAlteraEstado(11);


    
