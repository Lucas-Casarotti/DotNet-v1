using Cadastro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repositorio
{
    public class ClienteRepositorio
    {
        public List<Cliente> Clientes = new List<Cliente>();

        public void GravarDadosClientes()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(Clientes);

            File.WriteAllText("clientes.txt", json);
        }

        public void LerDadosClientes()
        {
            if (File.Exists("clientes.txt"))
            {
                var dados = File.ReadAllText("clientes.txt");
                var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);

                Clientes.AddRange(clientesArquivo);
            }
        }

        public void ImprimirCliente(Cliente cliente)
        {
            Console.WriteLine("ID                 :" + cliente.Id);
            Console.WriteLine("Nome               :" + cliente.Nome);
            Console.WriteLine("Data de Nascimento :" + cliente.DataNascimento);
            Console.WriteLine("Data de Cadastro   :" + cliente.CadastradoEm);
        }

        public void ExibirClientes()
        {
            Console.Clear();

            if (Clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            else
            {
                foreach (var cliente in Clientes)
                {
                    ImprimirCliente(cliente);
                    Console.WriteLine("-----------------------------");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public void CadastrarCliente()
        {
            Console.Clear();

            Console.Write("Nome do cliente: ");
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Data de nascimento (dd/MM/yyyy): ");
            var dataNascimento = DateTime.Parse(Console.ReadLine()).Date;
            Console.Write(Environment.NewLine);

            var cliente = new Cliente();
            cliente.Id = Clientes.Count + 1;
            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.CadastradoEm = DateTime.Now;

            Clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();
        }

        public void EditarCliente()
        {
            Console.Clear();

            Console.Write("Informe o código do cliente: ");
            var codigo = Console.ReadLine();

            var cliente = Clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! [Enteder]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            Console.WriteLine("Nome do cliente: ");
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Data de nascimento (dd/MM/yyyy): ");
            var dataNascimento = DateTime.Parse(Console.ReadLine()).Date;
            Console.Write(Environment.NewLine);

            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.CadastradoEm = DateTime.Now;

            Console.WriteLine("Cliente alterado com sucesso! [Enter]");
            ImprimirCliente(cliente);
            Console.ReadKey();
        }

        public void ExcluirCliente()
        {
            Console.Clear();

            Console.Write("Informe o código do cliente: ");
            var codigo = Console.ReadLine();

            var cliente = Clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado! [Enteder]");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            Clientes.Remove(cliente);

            Console.WriteLine("Cliente excluido com sucesso! [Enter]");
            Console.ReadKey();
        }
    }
}
