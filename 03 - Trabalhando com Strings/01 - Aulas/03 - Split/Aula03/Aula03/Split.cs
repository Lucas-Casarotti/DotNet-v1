using System;

namespace Aula03
{
    public static class Split
    {
        public static void UtilizandoSplit(string frase)
        {
            string[] partes = frase.Split(' ');

            foreach (string parte in partes)
            {
                Console.WriteLine("Separando os nomes: " + parte);
            }
        }
    }
}
