using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrianguloHeron
{
    public class CalculoAreaT
    {
        public double CalcularElAreaDelTriangulo(VariablesDelCalculo v)
        {
            double resultado = 0;
            resultado = Math.Sqrt(v.GetSemiPerimetro() * (v.GetSemiPerimetro() - v.getLado1()) * 
                (v.GetSemiPerimetro() - v.getLado2()) * (v.GetSemiPerimetro() - v.getLado3()));
            return resultado;
        }
    }
}
