using System;

class Program
{
    static void Main()
    {
        string entrada = "mala sala en la casa";
        string buscar = "ala";
        string reemplazarCon = "opo";

        string resultado = ReemplazarCaracteres(entrada, buscar, reemplazarCon);

        Console.WriteLine($"Entrada: \"{entrada}\"");
        Console.WriteLine($"Reemplazando \"{buscar}\" con \"{reemplazarCon}\"");
        Console.WriteLine($"Salida: \"{resultado}\"");
    }

    static string ReemplazarCaracteres(string input, string buscar, string reemplazarCon)
    {
        string resultado = input.Replace(buscar, reemplazarCon);

        return resultado;
    }
}
