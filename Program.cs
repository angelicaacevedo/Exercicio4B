using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VerificaPares teste = new VerificaPares(10);

             

            while(!teste.terminou())
            {
                if (teste.par())
                {
                    Console.WriteLine("{0} é par", teste.valor);
                }

                teste.progride();
            }

            Console.WriteLine("FIM");
        }
    }
}
