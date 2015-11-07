using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrianguloHeron
{
    public class ValidarAreaTriangulo
    {
        public bool ValidarAreaTriangular(VariablesDelCalculo variables)
        {
            bool resultado = false;
            if ((variables.getLado1() + variables.getLado2()) > variables.getLado3())
            {
                if ((variables.getLado1() + variables.getLado3()) > variables.getLado2())
                {
                    if ((variables.getLado2() + variables.getLado3()) > variables.getLado1())
                    {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }
    }
}
