using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a>max)
                {
                    max = a;
                }
                if (a<min)
                {
                    min = a;
                }
            }
            Console.WriteLine("Сумма максимального и минимального элементов массива: {0}", max+min);
            Console.ReadKey();
        }
    }
}
