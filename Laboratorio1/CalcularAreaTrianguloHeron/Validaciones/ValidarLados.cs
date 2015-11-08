using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrianguloHeron
{
    class ValidarLados
    {
        public bool ValidarLosLados(VariablesDelCalculo v)
        {
            bool resultado = false;
            if (v.getLado1() != 0 && v.getLado2() != 0 && v.getLado3() != 0)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
