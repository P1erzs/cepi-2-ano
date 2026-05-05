using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Funcionario: " + func);
            Console.WriteLine("");
            Console.Write("Deseja aumentar o salario em qual porcentagem");
            double porcent = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcent);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizaos: " + func);
        }
    }
}

