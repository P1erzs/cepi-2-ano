using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("");

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado do Estoque ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("");
            qte = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            p.RemoverProdutos(qte);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}

