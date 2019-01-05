using System;

namespace Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;
            Console.WriteLine("Hello entre el radio del circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());
            var circulo = new Circulo(radio);
            Console.WriteLine("El perimetro es:  "+ circulo.Perimetro());
            Console.WriteLine("El Area es:  " + circulo.Area());
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
