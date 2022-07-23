using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            double s = 0;
            double[] array = new double[n];
            for (int i = 0; i < n;)
            {
                Console.WriteLine($"Ввeдите {i + 1} число из {n}");
                string value = Console.ReadLine();
                if(Double.TryParse(value, out double number))
                {
                    array[i] = number;
                    s += number;
                    i++;
                }    
                else
                {
                    Console.WriteLine("Не удалось разобрать значение '{0}'", value);
                }
            }
            Console.WriteLine("Среднее арифметическое введенных чисел: {0}", s/n);
            Console.ReadKey();
        }
    }
}
