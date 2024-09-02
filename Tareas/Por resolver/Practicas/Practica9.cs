

string texto = new string();

bool EsNumero(string texto)
{
    for (int i = 0; i < texto.Length; i++)
    {
        if (!char.IsDigit(texto[i]))
        {
            return false;
        }
    }
    return true;
}

EsNumero("0999");
EsNumero("09s9");



void DeterminarPar(int numero)
{
    if ((numero % 2 == 0))
    {
        Console.WriteLine($"{numero} es par. ");
    }
  
}

void DeterminarImpar(int numero){
    if ((numero % 2 == 1))
    {
        Console.WriteLine($"{numero} es impar. ");
    }
}


DeterminarImpar(7);  
DeterminarPar(8);


int SumarArreglo(int[] numeros)
{
    int suma = 0;
    foreach (int numero in numeros)
    {
        suma += numero;
    }
    return suma;
}

int[] numeros = { 1, 2, 3, 4, 5 };
Console.WriteLine(SumarArreglo(numeros));


void SumarNumeros(int numero)
{
    int suma = 0;
    for (int i = 0; i <= numero; i++)
    {
        Console.Write("Introduce un número: ");
        int numero = int.Parse(Console.ReadLine());
        suma += numero;
    }
    Console.WriteLine($"La suma de los números es: {suma}");
}

SumarNumeros(4);


 void CalcularPromedio()
{
    double suma = 0;
    for (int i = 0; i < 4; i++)
    {
        Console.Write("Introduce una calificación: ");
        double calificacion = double.Parse(Console.ReadLine());
        suma += calificacion;
    }
    double promedio = suma / 4;
    Console.WriteLine($"El promedio es: {promedio}");
    if (promedio >= 6)
    {
        Console.WriteLine("Aprobado");
    }
    else
    {
        Console.WriteLine("Reprobado");
    }
}

CalcularPromedio();


void EncontrarMayor()
{
    Console.Write("Introduce el primer número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Introduce el segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.Write("Introduce el tercer número: ");
    int num3 = int.Parse(Console.ReadLine());

    int mayor = num1;
    if (num2 > mayor)
    {
        mayor = num2;
    }
    if (num3 > mayor)
    {
        mayor = num3;
    }
    Console.WriteLine($"El número mayor es: {mayor}");
}

EncontrarMayor();


 void TablaMultiplicar()
{
    Console.Write("Introduce un número para la tabla de multiplicar: ");
    int numero = int.Parse(Console.ReadLine());

    for (int i = 1 ; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}

TablaMultiplicar();


void InvertirCadena()
{
    Console.Write("Introduce una cadena de texto: ");
    string texto = Console.ReadLine();
    char[] caracteres = texto.ToCharArray();
    Array.Reverse(caracteres);
    string textoInvertido = new string(caracteres);
    Console.WriteLine($"Cadena invertida: {textoInvertido}");
}

InvertirCadena();


public void ContarVocales()
{
    Console.Write("Introduce una cadena de texto: ");
    string texto = Console.ReadLine();
    int conteo = 0;

    foreach (char c in texto.ToLower())
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            conteo++;
        }
    }

    Console.WriteLine($"Número de vocales: {conteo}");
}

ContarVocales();


public void OrdenarArreglo()
{
    int[] numeros = { 5, 2, 9, 1, 5, 6 };
    int temp;

    for (int i = 0; i < numeros.Length - 1; i++)
    {
        for (int j = 0; j < numeros.Length - i - 1; j++)
        {
            if (numeros[j] > numeros[j + 1])
            {
                temp = numeros[j];
                numeros[j] = numeros[j + 1];
                numeros[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("Arreglo ordenado:");
    foreach (int numero in numeros)
    {
        Console.Write(numero + " ");
    }
    Console.WriteLine();
}

OrdenarArreglo();