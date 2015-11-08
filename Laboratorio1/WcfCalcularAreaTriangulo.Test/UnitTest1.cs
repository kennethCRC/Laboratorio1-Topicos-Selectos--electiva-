using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcularAreaTrianguloHeron;

namespace WcfCalcularAreaTriangulo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaWcfCorrecto()
        {
            double semiPerimetroEsperado = 6;
            double areaEsperado = 36;
            CalcularAreaTrianguloHeron.VariablesDelCalculo v = new VariablesDelCalculo();
            v.setLado1(3);
            v.setLado2(4);
            v.setLado3(5);
            CalcularAreaTrianguloHeron.CalcularAreaTriangulo triangulo = new CalcularAreaTriangulo();
            triangulo.CalculoDelAreaTriangular(v);
            Assert.IsTrue((semiPerimetroEsperado == v.GetSemiPerimetro()) ||
                          (areaEsperado == v.getArea()));
        }
    }
}
