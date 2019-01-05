using System;
using System.Collections.Generic;
using System.Text;

namespace Circulo
{
    class Circulo
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }
        public Circulo()
        {
            radio = 0;
        }
        public Circulo(double r)
        {
            radio = r;
        }
        public double Perimetro()
        {

            double pi, perimetro;
            pi = Convert.ToDouble(3.1416);
            perimetro = 2 * this.radio * pi;
            return perimetro;
        }
        public double Area()
        {
            double pi=Convert.ToDouble(3.1416) ;
            double area;
            area = pi * Math.Pow(radio, 2);
            return area;
       }
    }
}
