using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcularAreaTrianguloHeron;

namespace CalcularAreaTrianguloHeron.Test
{
    /// <summary>
    /// Summary description for PruebasUnitariasCalcularAreaTrianguloHeron
    /// </summary>
    [TestClass]
    public class PruebasUnitariasCalcularAreaTrianguloHeron
    {
        public PruebasUnitariasCalcularAreaTrianguloHeron()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PruebaUnitariaLadosTrianguloValidados()
        {
            
            CalcularAreaTrianguloHeron.CalcularAreaTriangulo triangulo = new CalcularAreaTrianguloHeron.CalcularAreaTriangulo();
            VariablesDelCalculo v = new VariablesDelCalculo();
            v.setLado1(5);
            v.setLado2(5);
            v.setLado3(19);
            triangulo.CalculoDelAreaTriangular(v);
        }
        [TestMethod]
        public void PrubaUnitariaMedidasMayoresACero()
        {
            double lado1Esperado =0;
            double lado2Esperado=0;
            double lado3Esperado=0;

            VariablesDelCalculo variables = new VariablesDelCalculo(2,3,0);
            Assert.IsTrue((variables.getLado1() != lado1Esperado) ||
                          (variables.getLado2() != lado2Esperado)||
                          (variables.getLado3() != lado3Esperado));
        }
    }
}
