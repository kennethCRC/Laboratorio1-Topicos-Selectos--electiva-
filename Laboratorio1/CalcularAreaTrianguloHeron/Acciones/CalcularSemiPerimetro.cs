using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrianguloHeron
{
    public class CalcularSemiPerimetro
    {
        public double CalcularElSemiPerimetro (VariablesDelCalculo variables)
        {
            double resultado = 0;
            resultado =(variables.getLado1() + variables.getLado2() + variables.getLado3()) / 2;
            return resultado;
        }
    }
}
