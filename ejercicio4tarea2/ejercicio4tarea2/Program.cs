using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> entrada = new List<string> { "casa", "perro", "mouse" };

        List<string> resultado = EliminarVocales(entrada);

        Console.WriteLine("Entrada: [" + string.Join(", ", entrada) + "]");
        Console.WriteLine("Salida: [" + string.Join(", ", resultado) + "]");
    }

    static List<string> EliminarVocales(List<string> palabras)
    {
        List<string> resultado = new List<string>();

        foreach (var palabra in palabras)
        {
            string palabraSinVocales = EliminarVocalesDePalabra(palabra);
            resultado.Add(palabraSinVocales);
        }

        return resultado;
    }

    static string EliminarVocalesDePalabra(string palabra)
    {
        string vocales = "aeiouAEIOU";

        foreach (char vocal in vocales)
        {
            palabra = palabra.Replace(vocal.ToString(), "");
        }

        return palabra;
    }
}
