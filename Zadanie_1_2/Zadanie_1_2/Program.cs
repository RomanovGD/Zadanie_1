using System;

namespace Zadanie_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            try
            {
                Console.Write("Введите a: ");
                a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                b = Double.Parse(Console.ReadLine());
                Console.Write("Введите c: ");
                c = Double.Parse(Console.ReadLine());
                Console.WriteLine(a==b||a==c||c==b?"Треугольник равнобедренный":"Треугольник не равнобедренный");
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
        }
    }
}
