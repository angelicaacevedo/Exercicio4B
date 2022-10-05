using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4B
{
    internal class VerificaPares
    {
        public int valor;

        public VerificaPares(int numero)
        {
            valor = numero;
        }

        public bool par()
        {
            if (valor % 2 == 0) return true;
            return false;
        }

        public bool terminou()
        {
            if(valor == 0) return true;

            return false;
        }

        public void progride()
        {
            valor -= 1;        
        }
    }
}
