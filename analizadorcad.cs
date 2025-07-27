using System;

class AnalizadorCadena
{
    static void Main()
    {
        Console.WriteLine("Ingresa una cadena:");
        string entrada = Console.ReadLine();

        AnalizarCadena(entrada);
    }

    static void AnalizarCadena(string texto)
    {
        int cantidadVocales = ContarVocales(texto);
        string textoInvertido = InvertirCadena(texto);
        bool esPalindromo = EsPalindromo(texto);

        Console.WriteLine($"Cantidad de vocales: {cantidadVocales}");
        Console.WriteLine($"Cadena invertida: {textoInvertido}");
        Console.WriteLine($"¿Es palíndromo?: {(esPalindromo ? "Sí" : "No")}");
    }

    static int ContarVocales(string texto)
    {
        int contador = 0;
        string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";
        foreach (char c in texto)
        {
            if (vocales.Contains(c))
                contador++;
        }
        return contador;
    }

    static string InvertirCadena(string texto)
    {
        char[] arreglo = texto.ToCharArray();
        Array.Reverse(arreglo);
        return new string(arreglo);
    }

    static bool EsPalindromo(string texto)
    {
        string limpio = texto.Replace(" ", "").ToLower();
        string invertido = InvertirCadena(limpio);
        return limpio == invertido;
    }
}
