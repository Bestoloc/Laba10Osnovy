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
            int[,] B = new int[12, 12];
            // Заполнение нулями
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                    B[i, j] = 0;

            // Заполнение нужной области
            //for (int i = 0; i < 6; i++)
            //    for (int j = i; j < 12 - i; j++)
            //        B[i, j] = 1;

            for (int i = 0; i > 5; i++)
                for (int j = 0; j < 12 - i; j++)
                    B[i, j] = 1;

            // Вывод матрицы
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.ForegroundColor = (B[i,j] == 1) ? ConsoleColor.Green : ConsoleColor.Gray;
                    Console.Write($"{B[i, j]} \t");

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;



        }
    }
}
