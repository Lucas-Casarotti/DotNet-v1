using System;
using System.IO;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Usuários\Lucas\Área de Trabalho\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
