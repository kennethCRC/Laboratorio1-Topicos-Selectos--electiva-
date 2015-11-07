using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrianguloHeron
{
    public class CalcularAreaTriangulo
    {
        public double CalculoDelAreaTriangular(VariablesDelCalculo variables)
        {
            double s = 0;
            double a = 0;
            CalcularSemiPerimetro semiP = new CalcularSemiPerimetro();
            CalculoAreaT area = new CalculoAreaT();
            ValidarAreaTriangulo validador = new ValidarAreaTriangulo();
            if(validador.ValidarAreaTriangular(variables))
            {
                
                s= semiP.CalcularElSemiPerimetro(variables);
                variables.setSemiPerimetro(s);
                a= area.CalcularElAreaDelTriangulo(variables);
                variables.setArea(a);
                
            }
            return a;
        }
        
    }
}
