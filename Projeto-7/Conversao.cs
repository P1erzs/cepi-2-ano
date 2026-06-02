using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    internal class Conversao
    {
        public static double IoF = 0.06;

        public static double DolarParaReal (double quantia,
            double cotacao)
        {
            double total = quantia * cotacao;

            return total + total * IoF;
        }
    }
}
