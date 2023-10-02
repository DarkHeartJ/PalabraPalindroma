namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            Console.Write("Introduce una palabra: ");
            palabra = Console.ReadLine();

            if (palabra != null)
            {
                palabra = palabra.ToLower();
                palabra = palabra.Replace(" ", "");

                int longitud = palabra.Length;
                bool igual = true;
                int contador = 0;

                for (int i = longitud - 1; i >= 0; i--)
                {
                    if (palabra[i] != palabra[contador])
                    {
                        igual = false;
                        break;
                    }

                    contador++;
                }

                if (igual == true)
                {
                    Console.WriteLine($"La palabra {palabra}, es palindroma.");
                }
                else
                {
                    Console.WriteLine($"La palabra {palabra}, no es palindroma.");
                }

                Console.ReadKey();
            }
        }
    }
}