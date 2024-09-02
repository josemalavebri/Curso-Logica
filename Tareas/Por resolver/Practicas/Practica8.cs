using System;
using System.Collections.Generic;


TiendaVideojuegos.programa();

class TiendaVideojuegos
{
    private static List<string> juegosDisponibles = new List<string>()
        {
            "The Legend of Zelda: Breath of the Wild",
            "Super Mario Odyssey",
            "Minecraft",
            "Fortnite",
            "Call of Duty: Modern Warfare"
        };
    private static List<string> carrito = new List<string>();

    public static void programa()
    {
        // Lista de videojuegos disponibles en la tienda
        
        // Lista para almacenar los juegos que el usuario ha agregado al carrito
        int opcion = 0;

        while (opcion != 5)
        {
            Console.WriteLine("\n--- Tienda de Videojuegos ---");
            Console.WriteLine("1. Ver juegos disponibles");
            Console.WriteLine("2. Agregar juego al carrito");
            Console.WriteLine("3. Ver carrito de compras");
            Console.WriteLine("4. Eliminar juego del carrito");
            Console.WriteLine("5. Finalizar compra y salir");
            Console.Write("Seleccione una opción: ");
//
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Mostrar los juegos disponibles
               mostrarJuegos();
            }

            else if (opcion == 2)
            {
                // Agregar un juego al carrito
                mostrarJuegos();
                Console.Write("\nIngrese el número del juego que desea agregar al carrito: ");
                int juegoSeleccionado = int.Parse(Console.ReadLine());
                if (juegoSeleccionado >= 1 && juegoSeleccionado <= juegosDisponibles.Count)
                {
                    string juego = juegosDisponibles[juegoSeleccionado - 1];
                    carrito.Add(juego);
                    Console.WriteLine($"El juego '{juego}' ha sido agregado al carrito.");
                }

                else
                {
                    Console.WriteLine("Selección no válida.");
                }
            }
            
            else if (opcion == 3)
            {
                // Ver los juegos en el carrito
                mostrarCarrito();
                
            }

            else if (opcion == 4)
            {
                mostrarCarrito();
                // Eliminar un juego del carrito
                if (carrito.Count > 0)
                {
                    Console.Write("\nIngrese el número del juego que desea eliminar del carrito: ");
                    int numeroJuegoAEliminar = Convert.ToInt32(Console.ReadLine());
                    if (numeroJuegoAEliminar >= 1 && numeroJuegoAEliminar <= carrito.Count)
                    {
                        string juego = carrito[numeroJuegoAEliminar - 1];
                        carrito.RemoveAt(numeroJuegoAEliminar - 1);
                        Console.WriteLine($"El juego '{juego}' ha sido eliminado del carrito.");
                        Console.WriteLine("Estos son tus juegos en tu carrito actual");
                        mostrarCarrito();
                    }
                }
             }   
            else if (opcion == 5)
            {
                // Finalizar compra y salir
                if (carrito.Count > 0)
                {
                    Console.WriteLine("\n--- Compra Finalizada ---");
                    Console.WriteLine("Juegos comprados:");
                    foreach (string juego in carrito)
                    {
                        Console.WriteLine($"- {juego}");
                    }
                    Console.WriteLine("Gracias por su compra.");
                }
                else
                {
                    Console.WriteLine("No ha comprado ningún juego.");
                }
            }

            else
            {
                Console.WriteLine("Opción no válida");
            }
        }
        static void  mostrarJuegos(){
            Console.WriteLine("\n--- Juegos Disponibles ---");
            for (int i = 0; i < juegosDisponibles.Count; i++)
            {
                    Console.WriteLine($"{i + 1}. {juegosDisponibles[i]}");
            }
        }

        static void mostrarCarrito(){
            if (carrito.Count > 0)
                {
                    Console.WriteLine("\n--- Carrito de Compras ---");
                    for (int i = 0; i < carrito.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {carrito[i]}");
                    }
                }
            else
            {
                Console.WriteLine("El carrito está vacío.");
            }
        }
    }

   
    static string cadena = "cadena";

    int cantidadCadena = ContarCaracteres(cadena);

    static int ContarCaracteres(string cadena){
        return cadena.Length;
    }


}




