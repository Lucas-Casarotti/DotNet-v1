using System;
using System.IO;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"E:\Usuários\Lucas\Área de Trabalho\file1.txt";
            string targePath  = @"E:\Usuários\Lucas\Área de Trabalho\file2.txt";

            try {
                string [] lines = File.ReadAllLines(sourcePath);

                // AppendText vai acrescentar as strings no final do arquivo
                using (StreamWriter sw = File.AppendText(targePath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            } 
            catch (IOException ex) { 
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
