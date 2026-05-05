using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            double salario_medio = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("Salario medio = " +salario_medio);

            Console.WriteLine("primeiro funcionario: " +f1.nome);
            Console.WriteLine("primeiro funcionario: " + f2.nome);


        }
    }
}

