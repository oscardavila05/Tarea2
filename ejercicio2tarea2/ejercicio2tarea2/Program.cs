class Program
{
    static void Main()
    {
        string palabra = "abba";
        bool esPalindromo = EsPalindromo(palabra);

        if (esPalindromo)
        {
            Console.WriteLine("La palabra '{palabra}' es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra '{palabra}' no es un palíndromo.");
        }
    }

    static bool EsPalindromo(string palabra)
    {
        palabra = palabra.ToLower();

        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}