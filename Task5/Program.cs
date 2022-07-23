using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array; 
            Console.WriteLine("Ввeдите целочисленное значение N");
            string value = Console.ReadLine();
            if (int.TryParse(value, out int n))
            {
                array = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = ((i % 2 != 0 && j % 2 != 0)|| (i % 2 == 0 && j % 2 == 0)) ? 1 : 0;
                        Console.Write($"{array[i,j]} ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вы ввели не целочисленное значение");
                Console.ReadKey();
            }
        }
    }
}
