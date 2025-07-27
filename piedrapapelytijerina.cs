using System;

class PiedraPapelTijera
{
    static void Main()
    {
        string[] opciones = { "piedra", "papel", "tijera" };
        Random rnd = new Random();
        string jugador;

        int victorias = 0;
        int derrotas = 0;
        int empates = 0;

        Console.WriteLine("Bienvenido a Piedra, Papel o Tijera Edición grasosa!");

        while (true)
        {
            Console.Write("Escribe piedra, papel, tijera o salir: ");
            jugador = Console.ReadLine().ToLower();

            if (jugador == "salir")
            {
                Console.WriteLine("\nGracias por jugar, campeón interdimensional.");
                Console.WriteLine("Ganadas: " + victorias);
                Console.WriteLine("Perdidas: " + derrotas);
                Console.WriteLine("Empates: " + empates);
                break;
            }

            if (Array.IndexOf(opciones, jugador) < 0)
            {
                Console.WriteLine("¿Eso esel nombre de una cerveza? Esa opción no existe.");
                continue;
            }

            string compu = opciones[rnd.Next(opciones.Length)];
            Console.WriteLine("La computadora eligió: " + compu);

            if (jugador == compu)
            {
                Console.WriteLine("Empate... Ni tú ni la máquina quisieron sobresalir.");
                empates++;
            }
            else if ((jugador == "piedra" && compu == "tijera") ||
                     (jugador == "tijera" && compu == "papel") ||
                     (jugador == "papel" && compu == "piedra"))
            {
                Console.WriteLine("¡Ganaste! Tu poder es más fuerte que el WiFi de la compu.");
                victorias++;
            }
            else
            {
                Console.WriteLine("Perdiste... hasta un plátano con WiFi lo haría mejor.");
                derrotas++;
            }

            Console.WriteLine("Marcador → Ganadas: " + victorias + " | Perdidas: " + derrotas + " | Empates: " + empates);
            Console.WriteLine();
        }
    }
}
