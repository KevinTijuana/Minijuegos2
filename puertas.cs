using System;

class puertasmagicas
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al reto de las puertas mágicas");

        Console.WriteLine("Primera puerta: escribe el símbolo @ para abrirla");
        Console.Write("Escribe un carácter: ");
        string simbolo = Console.ReadLine();

        if (simbolo == "@")
        {
            Console.WriteLine("La puerta 1 se abre");
        }
        else
        {
            Console.WriteLine("No se abre la puerta 1");
            return;
        }

        Console.WriteLine("Segunda puerta: escribe la palabra secreta en mayúsculas (clave: MISTERIO)");
        Console.Write("Palabra secreta: ");
        string clave = Console.ReadLine();

        if (clave == "MISTERIO")
        {
            Console.WriteLine("La puerta 2 se abre");
        }
        else
        {
            Console.WriteLine("No se abre la puerta 2");
            return;
        }

        Console.WriteLine("Tercera puerta: escribe un número par entre 20 y 50 inclusive");
        Console.Write("Escribe el número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 20 && numero <= 50 && numero % 2 == 0)
        {
            Console.WriteLine("La puerta 3 se abre. ¡Has ganado!");
        }
        else
        {
            Console.WriteLine("No se abre la puerta 3");
        }
    }
}
