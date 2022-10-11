using System;
using System.Globalization;

namespace Thsupreme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Compra Online ---------------");
            Console.WriteLine("");
            Console.WriteLine("--------------- Dados do Usuario ---------------");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu Saldo: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);         
            Console.WriteLine("--------------- Dados do Produdo ---------------");
            Console.WriteLine("");
            Console.Write("Digite o nome do Produto: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Digite o valor do Produto: ");
            double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double saldoFinal = saldo - valorProduto;
            bool compraRealizada = saldoFinal >= 0;

            if (compraRealizada)
            {
                Console.WriteLine("Compra Realizada com Sucesso !!");
            }

            else
            {
                Console.WriteLine("Compra Cancelada");
            }

            Console.ReadKey();

        }
    }
}
