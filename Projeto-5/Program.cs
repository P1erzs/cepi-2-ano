using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Mimete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e Altura do retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

