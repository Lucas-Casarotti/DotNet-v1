using System;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "'Lucas Matheus está trabalhando'";
            Console.WriteLine($"Digite uma palavra para verificar se existe na seguinte frase: \n{frase}");
            Console.Write("Sua palavra:");
            string palavra = Console.ReadLine();

            // há uma sobrecarga de Contains que aceita um argumento adicional do tipo StringComparison
            // permitindo que você especifique como a comparação deve ser feita
            // nessa caso utilizando StringComparison.OrdinalIgnoreCase para ignorar a comparação de letras maiúsculas e minúsculas 

            if (frase.Contains(palavra, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Palavra encontrada");
            }
            else
            {
                Console.WriteLine("Palavra não encontrada");
            }   
        }
    }
}
