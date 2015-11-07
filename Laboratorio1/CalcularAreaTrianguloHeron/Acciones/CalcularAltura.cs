using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrianguloHeron
{
    public class CalcularAltura
    {
        public double CalculoDeLaAlturaEnA (VariablesDelCalculo v)
        {
            ValidarAltura vH = new ValidarAltura();
            double resultado = 0;
            resultado = ((2 / v.getLado1()) * v.getArea());
            if(vH.ValidarLaAltura(resultado, v))
            {
                v.setAlturaEnA(resultado);
                
            }
            return resultado;

        }
        public double CalculoDeLaAlturaEnB(VariablesDelCalculo v)
        {
            ValidarAltura vH = new ValidarAltura();
            double resultado = 0;
            resultado = ((2 / v.getLado2()) * v.getArea());
            if (vH.ValidarLaAltura(resultado, v))
            {
                v.setAlturaEnB(resultado);

            }
            return resultado;
        }
        public double CalculoDeLaAlturaEnC(VariablesDelCalculo v)
        {
            ValidarAltura vH = new ValidarAltura();
            double resultado = 0;
            resultado = ((2 / v.getLado3()) * v.getArea());
            if (vH.ValidarLaAltura(resultado, v))
            {
                v.setAlturaEnC(resultado);

            }
            return resultado;
        }
    }
}
