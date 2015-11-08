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
            ValidarLados vL = new ValidarLados();
            double resultado = 0;
            if (vL.ValidarLosLados(variables))
            {
                resultado = (variables.getLado1() + variables.getLado2() + variables.getLado3()) / 2;
            }
            return resultado;
        }
    }
}
