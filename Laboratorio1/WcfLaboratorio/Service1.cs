using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfLaboratorio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetQueDeseaCalcular(int value)
        {
            string resultado ="";
            if (value != 0)
            {
                if (value == 1)
                {
                    resultado = string.Format("{0}. Calcular perimetro", value);
                }
                if (value == 2)
                {
                    resultado = string.Format("{0}. Calcular área", value);
                }
            }
            else
            {
                resultado = "Cero no es un número válido";
            }
            return resultado;
            
        }

        double CalcularAreaTrianguloHeron(double lado1, double lado2, double lado3)
        {
            double semiPerimetro = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(semiPerimetro*(semiPerimetro - lado1)*(semiPerimetro - lado2)*
                                        (semiPerimetro - lado3));
            return area;
        }
        
    }
}
