using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write($"{array[i]} ");
            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (array[i]> array[j]&&i<4&&j<5)
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                    else if(array[i] < array[j]&&i>4&&j>5)
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.ReadKey();
        }
    }
}
