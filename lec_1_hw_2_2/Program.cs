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
            int N, M;
            InputData(out N, out M);
            int[][] matrix = InitMatrix(N, M);
            ShowMatrix(matrix);
            int[] minimals = GetMinimalsInRows(matrix);
            ShowReverseOfSortingMinimals(minimals);
        }
        
        static void InputData(out int N, out int M)
        {
            N = 0;
            M = 0;
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
        }        

        static int[][] InitMatrix(int N, int M)
        {
            int[][] matrix = new int[N][];
            for (int i = 0; i < N; i++)
                matrix[i] = new int[M];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    matrix[i][j] = rnd.Next(0, 999);
            return matrix;
        }

        static void ShowMatrix(int[][] matrix)
        {
            Console.WriteLine("Содержимое матрицы");
            for (int i = 0; i < matrix.Length; i++)
            {
                foreach (int j in matrix[i])
                    Console.Write("{0,5:d}", j);
                Console.WriteLine();
            }
        }

        static int[] GetMinimalsInRows(int [][] matrix)
        {
            int[] mins = new int[matrix.Length];
            for (int i = 0; i < mins.Length; i++)
                mins[i] = matrix[i].Min();
            return mins;
        }

        static void ShowReverseOfSortingMinimals(int[] minimals)
        {
            Array.Sort(minimals);
            Console.WriteLine("Минимальные элементы строк матрицы в порядке убывания");
            for (int i = minimals.Length - 1; i >= 0; i--)
                Console.Write("{0,5:d}", minimals[i]);
            Console.WriteLine();
        }
    }
}
