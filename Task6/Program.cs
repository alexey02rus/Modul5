using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array;
            Console.WriteLine("Ввeдите целочисленное значение N размерности матрицы");
            string value = Console.ReadLine();
            if (int.TryParse(value, out int n))
            {
                array = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n;)
                    {
                        Console.WriteLine($"Ввeдите {j+1} число в строке {i+1}");
                        string value1 = Console.ReadLine();
                        if (int.TryParse(value1, out int number))
                        {
                            array[i, j] = number;
                            j++;
                        }
                        else
                        {
                            Console.WriteLine("Не удалось разобрать значение '{0}', повторите попытку.", value1);
                        }
                    }
                    Console.WriteLine();
                }
                int[] si = new int[n];
                int[] sj = new int[n];
                int[] ss = new int[2];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        si[i] += array[i, j];
                        sj[i] += array[j, i];
                        if (i == j)
                        {
                            ss[0] += array[i, j];
                        }
                        if (i + j == n - 1)
                        {
                            ss[1] += array[i, j];
                        }
                    }
                }
                bool f = false;
                foreach (int a in si)
                {
                    foreach (int b in sj)
                    {
                        foreach (int c in ss)
                        {
                            if (a != b || a != c)
                            {
                                f = true;
                                break;
                            }
                        }
                        if (f)
                            break;
                    }
                    if (f)
                        break;
                }
                if (f)
                {
                    Console.WriteLine("Данная матрица не является магическим квадратом");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ура! Данная матрица является магическим квадратом");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не целочисленное значение");
                Console.ReadKey();
            }

        }
    }
}

