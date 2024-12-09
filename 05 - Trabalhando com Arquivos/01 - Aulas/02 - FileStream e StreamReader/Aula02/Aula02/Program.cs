using System;
using System.IO;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Usuários\Lucas\Área de Trabalho\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                // Lê o arquivo inteiro e retorna uma string
                string line = sr.ReadToEnd();

                // Lê a primeira linha completa
                //string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // É necessário fechar, pois enquanto um FileStream ou StreamReader está aberto,
                // ele mantém um "bloqueio" (lock) sobre o arquivo, impedindo que outros processos o acessem. 
                // Fechar a stream libera o arquivo para que outras operações possam ser executadas.
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            // Maneira mais resumida, utilizando a classe File

            //string path2 = @"E:\Usuários\Lucas\Área de Trabalho\file1.txt";
            //StreamReader sr2 = null;
            //try
            //{
            //    // Já instancia o FileStream
            //    sr2 = File.OpenText(path2);

            //    string line = sr2.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Erro!");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //}
        }
    }
}
