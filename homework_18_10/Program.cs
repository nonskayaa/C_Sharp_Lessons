using System;

class Program
{
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите размеры  матрицы : ");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        if (n != m)
        {
            Console.WriteLine("Ошибка! Матрица должна быть квадратная!");
        }
        else
        {
            int[,] A = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = random.Next(10);
                }
            }
            PrintArray(A);
            Console.WriteLine("Введите степень матрицы");
            int k=int.Parse(Console.ReadLine());
            int[,] A_term = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A_term[i, j] = A[i, j];
                }
            }
            int sum = 0;
            
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        sum = 0;
                        for (int l = 0; l < n; l++)
                        {
                            sum += A_term[i, l] * A[j, l];
                        }
                        A_term[i, j] = sum;
                    }

                }
            
            PrintArray(A);
            PrintArray(A_term);
            
        }
    }
}