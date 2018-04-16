using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_1_hw_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, M = 0;
            do
            {
                try
                {
                    Console.Write("Введите размерность N матрицы:");
                    N = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(N <= 0 ? "Размерность не может быть <= 0" : "");
                    Console.Write("Введите размерность M матрицы:");
                    M = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(M <= 0 ? "Размерность не может быть <= 0" : "");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Не корректное число!!!");
                }
            } while (N <= 0 || M <= 0);
            int[][] matrix = new int[N][];
            for (int i = 0; i < N; i++)
                matrix[i] = new int[M];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    matrix[i][j] = rnd.Next(0, 999);
            Console.WriteLine("Содержимое матрицы");
            for (int i = 0; i < N; i++)
            {
                foreach (int j in matrix[i])
                    Console.Write("{0,5:d}",j);
                Console.WriteLine();
            }
            int[] minimums = new int[N];
            for (int i = 0; i < N; i++)
                minimums[i] = matrix[i].Min();
            Array.Sort(minimums);
            Console.WriteLine("Минимальные элементы строк матрицы в порядке убывания");
            for (int i = minimums.Length - 1; i >= 0; i--)
                Console.Write("{0,5:d}", minimums[i]);
            Console.WriteLine();
        }
                
    }
}
