using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CalcularAreaTrianguloHeron;

namespace WcfCalcularAreaTriangulo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public double GetAreaTriangulo(double lado1, double lado2, double lado3)
        {
            VariablesDelCalculo variables = new VariablesDelCalculo(lado1, lado2, lado3);
            CalcularAreaTriangulo areaTriangulo = new CalcularAreaTriangulo();
            return areaTriangulo.CalculoDelAreaTriangular(variables);
            
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
