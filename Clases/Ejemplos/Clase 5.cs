

//Comparacion
int a = 10;
int b = 20;


if (a == 10){
    Console.WriteLine("Esto es igual a 10");
} else{
    Console.WriteLine("Esto es no igual a 10")
}

int edad = 18;

//Evaluar si tiene 10 años para que entre a la fiesta de los pequeños
//Evaluar si tiene 15 años para que entre a la fiesta de los adolecentes
//Evaluar si tiene 18 años para que entre a la fiesta de los adultos

//comparacion if-else if
if (edad < 10){
    Console.WriteLine("No se le permite entrar a ninguna fiesta")
}
else if (edad < 15){
    Console.WriteLine("Se le permite entrar a la fiesta de los pequeños")
}

else if (edad < 18){
    Console.WriteLine("Se le permite entrar a la fiesta de los adolecentes")
} else{
     Console.WriteLine("Se le permite entrar a la fiesta de los adolecentes")
}

 Condicionales

for(int i = 1; i <= 10; i++){
    Console.WriteLine(i);
    Console.WriteLine("vatir el cafe");
}

Console.WriteLine("Cafe vatido con exito");

//Sintaxis
/*
 for(inicio contador; condicion ; suma contador ){
    Console.WriteLine("vatir el cafe");
 }
 */


//Asignacion 
 int a = 10;
 int b = 20;

//String objeto
 string objetoCadena = "aa"; 
  string objetoCadena = cd; 

 char c = 'a';
 char d = 'a';


//simbolos de comparacion
 if(a == b){
    Console.WriteLine("igualdad");
 }

 if(objetoCadena.ToString() == "cd"){
    Console.WriteLine("igualdad");
 }

 if(a < b){
    Console.WriteLine("menor");
 }

  if(a > b){
    Console.WriteLine("mayor");
 }


 if(a <= b){
    Console.WriteLine("menor igual");
 }


 if(a >= b){
    Console.WriteLine("mayor igual");
 }



//Usando banderas
if(bandera){
    Console.WriteLine("verdad");
}

if(  !bandera ){
    Console.WriteLine("falso");
} else{
    Console.WriteLine("verdad");
}


//Practica de banderas
bool bandera = true;
if(bandera){
    Console.WriteLine("");
    bandera = diferencia();
    for( int i = 5; i >= 0; i--){
        if(i==0){
            Console.WriteLine("");
            bandera = diferenciador(bandera);
            if(bandera){
                Console.WriteLine("");

                if( diferenciador(bandera) ){
                   Console.WriteLine("");
                }
            }
        }
        else{
        }
        Console.WriteLine("");
    }
}
Console.WriteLine(bandera);

bool diferencia(){
    return false;
}

bool diferenciador(bool bandera){
    return !bandera;
}
