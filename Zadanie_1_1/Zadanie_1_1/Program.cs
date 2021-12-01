using System;

namespace Zadanie_1_1
{
    class Program
    {
        static double sum(double fM, double diff, int N)
        {
            double lM = fM + (N - 1) * diff;
            return ((2*fM+diff*(N-1))/2)*N;
        }
        static void Main(string[] args)
        {
            double firstMember, diff, amount;
            int count;
            try
            {
                Console.Write("Введите первый член: ");
                firstMember = Double.Parse(Console.ReadLine());
                Console.Write("Введите разницу: ");
                diff = Double.Parse(Console.ReadLine());
                Console.Write("Введите количество членов: ");
                count = int.Parse(Console.ReadLine());
                amount = sum(firstMember, diff, count);
                Console.WriteLine("Сумма прогрессии: {0}", amount);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
        }
    }
}
