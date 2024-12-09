using System;

namespace Aula02
{
    public static class Substring
    {
        public static void UtilizandoSubstring(string frase)
        {
            string retorno = frase.Substring(0, 3);
            Console.WriteLine("Extraindo os três primeiros caracteres da frase utilizando o Substring: " + retorno);
        }
    }
}
