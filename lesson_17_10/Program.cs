
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
        Console.WriteLine("Введите размеры первой матрицы : ");
        int[,] A = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
        Console.WriteLine("Введите размеры второй матрицы : ");
        int[,] B = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
        Random random = new Random();                 //рандомная матрица

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = random.Next(10);
            }
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = random.Next(10);
            }
        }

        PrintArray(A);
        Console.WriteLine();
        PrintArray(B);


        int sum;
        if (A.GetLength(1) != B.GetLength(0))
        {
            Console.WriteLine("Матрицы нельзя умножить!");
        }

        int[,] C = new int[A.GetLength(0), B.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                sum = 0;
                for (int k = 0; k < B.GetLength(0); k++)
                {
                    sum += A[i, k] * B[j, k];
                }
                C[i, j] = sum;
            }

        }

        PrintArray(C);

    }
}


