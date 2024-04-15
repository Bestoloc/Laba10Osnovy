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

            int Result = 0;
            int PolozhitElementy = 0;

            for (int i = 0; i < 6; i++)
                for (int j = i; j < 12 - i; j++)
                {
                    Result = B[i, j] == 4 ? Result += 1 : Result;
                    PolozhitElementy = B[i, j] > 0 ? PolozhitElementy += 1 : PolozhitElementy;
                }

            Console.WriteLine();
            Console.WriteLine($"1) Количество элементов, равных 4.: {Result}");
            



            // Сформировать одномерный массив K из положительных элементов заштрихованной области матрицы. 
            int[] K = new int[PolozhitElementy];
            int e = 0;
            for (int i = 0; i < 6; i++)
                for (int j = i; j < 12 - i; j++)
                    if (B[i, j] > 0)
                    {
                        K[e] = B[i, j];
                        e++;
                    }
            Console.Write($"2) K = "); Console.Write("{ "); Console.Write(String.Join(", ", K)); Console.Write(" }");
            //foreach (var item in K)
            //    Console.Write($"{item} ");
            Console.WriteLine();


            // Сформировать одномерный массив F из сумм элементов каждой строки заштрихованной области. 
            int[] F = new int[6];
            int SummElementov = 0;
            for (int i = 0; i < 6; i++)
            {
                SummElementov = 0;
                for (int j = i; j < 12 - i; j++)
                {
                    SummElementov += B[i, j];
                }
                F[i] = SummElementov;
            }

            Console.Write($"2) F = "); Console.Write("{ "); Console.Write(String.Join(", ", F)); Console.Write(" }");
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
            double SredArifmed = S2 / y;
            Console.WriteLine($"4) Ответ: {SredArifmed}");



        }
    }
}
