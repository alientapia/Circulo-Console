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
            Circulo circulo = new Circulo(radio);
            Console.WriteLine("El perimetro es:  "+ circulo.Perimetro());
            Console.ReadLine();
        }
    }
}
