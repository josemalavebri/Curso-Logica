

int a = operacion1(0);

int b = operacion2(1);

int c = operacion3(0);


Console.WriteLine(a+" -  "+b+" - "+c);



int operacionNumero(){
    return 1 + (1*0);
}

int operacion1(int n){
    return operacionValidacion(n);

}


int operacion(int a){
    if(operacionBool()){
        return a;
    }
    else{
        return a;
    }
}

int operacion2(int c){
    c = ((operacionValidacion(c) +1)*0)+1;
    return operacion(c);
}



int operacionValidacion(int d){
    int a = d + operacionNumero();
    if(a == operacionNumero()){
        return a+operacion1(a);
    }else{
        return a;
    }
}


bool operacionBool(){
    return !false;
}


bool operacionBool2(bool d){
    return !d;
}


int operacion3(int a){
    int c=1;
    bool bandera = false;
    for(int b = 0; b<3;c++){
        b= b+5;
         bandera= false;
        if(operacionBool2(bandera)){
            a=b;
            b=b-5;
           return a;
        }else{
            return operacionValidacion(b);
        }
    }
    return 0;
}