using System;
class Program
{
static void Main()
    {
Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero == 5)
        {
            numero += numero; // Sumar el valor a sí mismo
        }
        else if (numero > 5)
        {
            numero += numero / 2; // Sumar la mitad del valor ingresado
        }

        Console.WriteLine($"Resultado:{numero}");
    }
}

------- ejercicio_4 ------- 

using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine()); // Parse sirve áea converti la cadena de texto en consola por numerica

        int sumaTotal = SumarNumerosHasta(numero);  // Llamar al método para sumar

        Console.WriteLine($"La suma de los números del 1 al {numero} es: {sumaTotal}");
    }
    static int SumarNumerosHasta(int numero)
    {
        int suma = 0;
        for (int i = 1; i <= numero; i++)  // Un Bucle en el for para sumar desde 1 hasta el número ingresado
        {
            suma += i;  // Para acumular la suma
        }

        return suma;  // Da la suma total
    }
}

---------ejercicio_5--------
int numero1 = 10;
int numero2 = 10;
int numeroFinal = 0;

numero2 = numero1 + numero1;  // numero2 = 10 + 10 => numero2 = 20
numero1 = numero1 + numero2;  // numero1 = 10 + 20 => numero1 = 30
numero2 = numero1 + numero1;  // numero2 = 30 + 30 => numero2 = 60
numero2 = numero2 + numero1;  // numero2 = 60 + 30 => numero2 = 90
numero1 = numero2 + numero2;  // numero1 = 90 + 90 => numero1 = 180
numeroFinal = numero1 + numero2;  // numeroFinal = 180 + 90 => numeroFinal = 270

Console.WriteLine(numeroFinal);

--------- ejercicio_6-------
using System;

class Program
{
    static void Main()
    {
        // Solicitar las edades de las personas
        Console.Write("Ingrese la edad de la persona 1: ");
        int edadPersona1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la edad de la persona 2: ");
        int edadPersona2 = int.Parse(Console.ReadLine());

        // Comparar las edades
        if (edadPersona1 == edadPersona2)
        {
            // Si las edades son iguales, sumar la edad de persona1 5 veces de forma iterativa
            for (int i = 0; i < 5; i++)
            {
                edadPersona1 += edadPersona1;
            }

            Console.WriteLine($"Las edades son iguales. La edad de la persona 1 multiplicada iterativamente es: {edadPersona1}");
        }
        else
        {
            // Si las edades no son iguales, restar la edad de persona2 hasta que tenga 5 años
            while (edadPersona2 > 5)
            {
                edadPersona2--;
            }

            Console.WriteLine($"Las edades no son iguales. La edad de la persona 2 se ha reducido a: {edadPersona2}");
        }
    }
}