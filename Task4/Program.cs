using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write($"{array[i]} ");
            }
            int m = 0;
            for (int i = 1; i < n; i+=2)
            {
                if (array[i]%2 != 0 && array[i]>0)
                {
                    m++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Количество нечетных положительных элементов, стоящих на четных местах: {m}");
            Console.ReadKey();
        }
    }
}
