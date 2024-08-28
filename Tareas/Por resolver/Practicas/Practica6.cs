

//Respiracion profunda
//Pomodoros
//Espacio de concentracion
//Vasito con agua

//Resolver problemas de conocimientos
//Preguntas en analogias
//Estar confundido está bien
    
    int Metodo1(int numero)
    {
        return numero + 1;
    }

    int Metodo2(int numero)
    {
        return numero - 2;
    }
    
    int Metodo3(int numero)
    {
        return numero + 2;
    }

    int Metodo4(int numero)
    {
        return numero - 1;
    }
    
    int Metodo5(int numero)
    {
        return numero + 0;
    }

    // Ordenar metodos para que de como resultado 0
    int resultado = 0;

    resultado = Metodo1(resultado);
    resultado = Metodo2(resultado);
    resultado = Metodo4(resultado);
    resultado = Metodo5(resultado);
    resultado = Metodo3(resultado);

    Console.WriteLine("Resultado final (esperado 0): " + resultado);

    // Ordenar metodos para que de como resultado 3

    resultado = 0;
    resultado = Metodo5(resultado);
    resultado = Metodo1(resultado);
    resultado = Metodo4(resultado);
    resultado = Metodo2(resultado);
    resultado = Metodo3(resultado);

    Console.WriteLine("Resultado final (esperado 3): " + resultado);

    //ESTA NO SALE 3 Y VA A SALIR :

    /*

    -2 + 2 SE ANULAN

    int Metodo2(int numero)
    {
        return numero - 2;
    }
    
    int Metodo3(int numero)
    {
        return numero + 2;
    }

    
    SE ANULAN -1 Y + 1
    int Metodo4(int numero)
    {
        return numero - 1;
    }

    int Metodo1(int numero)
    {
        return numero + 1;
    }

    int Metodo5(int numero)
    {
        return numero + 0;
    }

    */