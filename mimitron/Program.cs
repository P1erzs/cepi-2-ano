using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroprojeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            int y = int.MaxValue;
            int z = int.MinValue;
            long x = 2147483648L; //<- por padrão coloca L no final
            Console.WriteLine(a);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(x);

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float f = 3.6f; //<-- por padrao coloar o f ao final
            double f2 = 3.6;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(f);
            Console.WriteLine(f2);

            //-----------------------------------------

            string nome;
            nome = "Maria";
            Console.WriteLine(nome);

            object obj1 = "Aldenor Neto";
            object obj2 = 1.0;

            Console.Write(obj1); //<- nao pula linha
            Console.WriteLine(obj2);

        }
    }
}
