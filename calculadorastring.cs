using System;

class CalculadoraString
{
    static void Main()
    {
        Console.WriteLine("Introduce una operación (ejemplo: 5 + 3):");
        string entrada = Console.ReadLine();

        try
        {
            double resultado = EvaluarOperacion(entrada);
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static double EvaluarOperacion(string input)
    {
        input = input.Trim();

        if (input.Contains("+"))
        {
            var partes = input.Split('+');
            return double.Parse(partes[0]) + double.Parse(partes[1]);
        }
        else if (input.Contains("-"))
        {
            var partes = input.Split('-');
            return double.Parse(partes[0]) - double.Parse(partes[1]);
        }
        else if (input.Contains("*"))
        {
            var partes = input.Split('*');
            return double.Parse(partes[0]) * double.Parse(partes[1]);
        }
        else if (input.Contains("/"))
        {
            var partes = input.Split('/');
            double divisor = double.Parse(partes[1]);
            if (divisor == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");

            return double.Parse(partes[0]) / divisor;
        }
        else
        {
            throw new FormatException("Formato no válido. Usa operadores como +, -, *, /.");
        }
    }
}
