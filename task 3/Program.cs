using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число від 0 до 1");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine($"Число в десятковій системі: {num}");
            Console.Write("Число в двійковій системі: 0,");
            const int digits = 20;
            const int Base = 2;
            for (int i = 0; i < digits; ++i)
            {
                num *= Base;
                int cile = (int)num;
                Console.Write(cile);
                num -= cile;


            }
            Console.WriteLine();






            //////////////////////////////////TASK 3///////////////////////////////////////////////
            Console.WriteLine("---------------------------------------TASK 3---------------------------------------");
            int[,] A = new int[,]
        {
            { 1, -2, 3, -4, 5, -6 },
            { 7, -8, 9, -10, 11, -12 },
            { 13, -14, 15, -16, 17, -18 },
            { 19, -20, 21, -22, 23, -24 },
            { 25, -26, 27, -28, 29, -30 },
            { 31, -32, 33, -34, 35, -36 },
            { 37, -38, 39, -40, 41, -42 }
        };
    
            int[] b = new int[A.GetLength(1)];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > 0)
                    {
                        b[j]++;
                    }
                }
            }

            Console.WriteLine("Вектор b:");
            for (int j = 0; j < b.Length; j++)
            {
                Console.WriteLine(b[j]);
            }

            int maxIndex = 0;
            for (int j = 1; j < b.Length; j++)
            {
                if (b[j] > b[maxIndex])
                {
                    maxIndex = j;
                }
            }
            Console.WriteLine($"Номер максимального елемента вектора b: {maxIndex}");






        }



    }
}