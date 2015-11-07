using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrianguloHeron
{
    public class VariablesDelCalculo
    {
        double lado1 =0;
        double lado2 =0;
        double lado3 =0;
        double semiPerimetro = 0;
        double area = 0;
        double altura = 0;
        int cantidadLados = 0;
        public VariablesDelCalculo()
        {

        }
        public VariablesDelCalculo(double l1, double l2, double l3)
        {
            lado1 = l1;
            lado2 = l2;
            lado3 = l3;
        }
        
        public void setLado1 (double l1)
        {
            lado1 = l1;
        }
        public double getLado1()
        {
            return lado1;
        }
        public void setLado2(double l2)
        {
            lado2 = l2;
        }
        public double getLado2()
        {
            return lado2;
        }
        public void setLado3(double l3)
        {
            lado3 = l3;
        }
        public double getLado3()
        {
            return lado3;
        }
        public void setSemiPerimetro(double s)
        {
            semiPerimetro = s;
        }
        public double GetSemiPerimetro()
        {
            return semiPerimetro;
        }
        public void setArea(double a)
        {
            area = a;
        }
        public double getArea()
        {
            return area;
        }
        public void setAltura(double h)
        {
            altura = h;
        }
        public double getAltura()
        {
            return altura;
        }
        public void setCantidadLados (int num)
        {
            cantidadLados = num;
        }
        public int GetCantidadLados()
        {
            return cantidadLados;
        }
    }
}
