class Program
{
    static void Main()
    {
        
        List<int> entrada = new List<int> { 10, 10, 2, 6, 70, 5 };

        
        var resultado = ContarOcurrencias(entrada);

        
        foreach (var ocurrencias in resultado)
        {
            Console.WriteLine($"[{ocurrencias.Key}, {ocurrencias.Value}]");
        }
    }

    static Dictionary<int, int> ContarOcurrencias(List<int> lista)
    {
        var conteo = new Dictionary<int, int>();

        foreach (var elemento in lista)
        {
            if (conteo.ContainsKey(elemento))
            {
                conteo[elemento]++;
            }
            else
            {
                conteo[elemento] = 1;
            }
        }

        return conteo;
    }
}