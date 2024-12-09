using System;
using System.IO;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"E:\Usuários\Lucas\Área de Trabalho\file1.txt";
            string targetPath = @"E:\Usuários\Lucas\Área de Trabalho\file2.txt";

            try
            {
                // Utilizando o File
                File.Copy(sourcePath, targetPath);


                // Utilizando o FileInfo
                // Instanciando um objeto do tipo FileInfo, associado ao arquivo da variável sourcePath
                //FileInfo fileInfo = new FileInfo(sourcePath);
                // Copiando o conteúdo do file1 para o file2
                //fileInfo.CopyTo(targetPath);



                // Qual a diferença?

                //File é uma classe estática, então seus métodos podem ser usados diretamente sem precisar criar um objeto.
                //Isso é conveniente para operações simples e rápidas de arquivos, sem a necessidade de instanciar uma classe.

                // FileInfo é uma classe que exige a criação de uma instância associada a um arquivo específico no sistema.
                // Depois que uma instância é criada, ela mantém informações sobre o arquivo, como seu nome, diretório
                // e data de modificação, permitindo que o código reutilize essas informações sem ter que acessar
                // o sistema de arquivos repetidamente.

            }
            catch (IOException e) 
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
