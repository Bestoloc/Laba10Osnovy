using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10Osnovy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Формирование матрицы
            Random r = new Random();
            int[,] B = new int[12, 12];

            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                    B[i, j] = r.Next(-10, 11);

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    
                    Console.Write($"{B[i, j]} \t");
                }
                Console.WriteLine();
            }

            


            // Найти в заштрихованной области матрицы количество элементов, равных 4. 

            int q = 0;
            int w = 0;

            for (int i = 0; i < 6; i++)
                for (int j = i; j < 12 - i; j++)
                {
                    
                    q = B[i, j] == 4 ? q += 1 : q;
                    w = B[i, j] > 0 ? w += 1 : w;
                }

            Console.WriteLine();
            Console.WriteLine($"1) Ответ: {q}");
            Console.ForegroundColor = ConsoleColor.White;



            // Сформировать одномерный массив K из положительных элементов заштрихованной области матрицы. 
            int[] K = new int[w];
            int e = 0;
            for (int i = 0; i < 6; i++)
                for (int j = i; j < 12 - i; j++)
                    if (B[i, j] > 0)
                    {
                        K[e] = B[i, j];
                        e++;
                    }
            Console.Write($"2) Одномерный массив K: "); Console.Write("{ "); Console.Write(String.Join(", ", K)); Console.Write(" }");
            //foreach (var item in K)
            //    Console.Write($"{item} ");
            Console.WriteLine();


            // Сформировать одномерный массив F из сумм элементов каждой строки заштрихованной области. 
            int[] F = new int[6];
            int S;
            for (int i = 0; i < 6; i++)
            {
                S = 0;
                for (int j = i; j < 12 - i; j++)
                {
                    S += B[i, j];
                }
                F[i] = S;
            }

            Console.Write($"2) Одномерный массив F: "); Console.Write("{ "); Console.Write(String.Join(", ", F)); Console.Write(" }");
            //foreach (var item in F)
            //    Console.Write($"{item} ");
            Console.WriteLine();

            // Вычислить среднее арифметическое отрицательных элементов в нижней половине матрицы.
            double S2 = 0;
            int y = 0;
            for (int i = 6; i < 12; i++)
                for (int j = 0; j < 12; j++)
                    if (B[i, j] < 0)
                    {
                        S2 += B[i, j];
                        y++;
                    }
            double Sr = S2 / y;
            Console.WriteLine($"4) Ответ: {Sr}");



        }
    }
}
