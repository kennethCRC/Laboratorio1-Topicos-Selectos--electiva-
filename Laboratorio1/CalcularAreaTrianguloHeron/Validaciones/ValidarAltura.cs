using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrianguloHeron
{
    public class ValidarAltura
    {
        public bool ValidarLaAltura(double h, VariablesDelCalculo v)
        {

            bool resultado = false;
             if (h > 0.0)
            {
                resultado = true;
            }
             
            return resultado;
        }
        
        
    }
}
