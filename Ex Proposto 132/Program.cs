using System;
using System.Collections.Generic;
using System.Globalization;
using Ex_Proposto_132.Entidades;
using Ex_Proposto_132.Entidades.Enums;
using System.Text;

namespace Ex_Proposto_132
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string clienteNome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do pedido: ");
            Console.Write("Status: ");

            StatusPedido status = (StatusPedido)Enum.Parse(typeof(StatusPedido), "Processando");

            Console.Write("Quantos items para este pedido? ");
            int n = int.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(clienteNome, email, dataNascimento);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine($"Entre {i} com o dads do item: ");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preço = double.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeProduto, preço);

                Console.Write("Quantidade: ");
                int quantiade = int.Parse(Console.ReadLine());

                ItemPedido itemPedido = new ItemPedido(quantiade, preço, produto);

                pedido.AddItem(itemPedido);
            }
            Console.WriteLine();
            Console.WriteLine("Resumo do pedido: ");
            Console.WriteLine(pedido);
        }
    }
}
