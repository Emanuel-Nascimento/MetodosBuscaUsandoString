using System;

namespace MetodosBuscaUsandoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var outroParagrafo = "C# é uma linguagem moderna de versátil." +
                "Com C# consigo desenvolver para web, DeskTop, Jogos, " +
                "Mobile, entre outros. ";

            // IndexOf
            var IndexOf = outroParagrafo.IndexOf("C#");

            // LastIndexOf
            var lasIndexOf = outroParagrafo.LastIndexOf("C#");

            // StartWith
            var startWith = outroParagrafo.StartsWith("C#");

            // Substring
            var indexOfMobile = outroParagrafo.IndexOf("Mobile");
            var substringMobile = outroParagrafo.Substring(indexOfMobile, 6);

            // Constains 
            var containsJogos = outroParagrafo.Contains("Jogos", StringComparison.OrdinalIgnoreCase);
            var containsJogosExact = outroParagrafo.Contains("Jogos");
            var containsRuim = outroParagrafo.Contains("Ruim");
            Console.ReadKey();
        }
    }
}
