// Единичная матрица
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

    static bool isUnitMatrix(int[,] array)
    {
        bool flag = true;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (!(((i == j) && array[i, j] == 1) || ((i != j) && (array[i, j] == 0))))
                {
                    flag = false;
                    break;
                }
            }
            if (!flag)
            {
                break;
            }
        }
        return flag;
    }

    static bool isUpperTriangleMatrix(int[,] array)
    {

        bool flag = true;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (!((i > j && array[i, j] == 0) || (i <= j && array[i, j] != 0)))
                {
                    flag = false;
                    break;
                }
            }
            if (!flag)
            {
                break;
            }
        }
        return flag;
    }
    public static void Main(string[] args)
    {

        // // Единичная Матрица с размером N

        //int n = int.Parse(Console.ReadLine());
        //int n = 4;
        //int[,] matrix_E = new int[n, n];
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        if (i == j)
        //        {
        //            matrix_E[i, j] = 1;
        //        }
        //    }
        //}

        Random random = new Random();                 //рандомная матрица
        int n = 5;
        int m = 5;
        int[,] random_array = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                random_array[i, j] = random.Next(10);
            }
        }

        //PrintArray(array);
        //Console.WriteLine($"Матрица единичная : {isUnitMatrix(array)}"); // 1. проверка единичная ли матрица

        // 2. проверка верхнетреугольная ли матрица
        //PrintArray(random_array);
        //Console.WriteLine(isUpperTriangleMatrix(random_array));

        int n = 5;
        int k;




        int[,] matrix_E = new int[n, n];                              // единичная матрица 
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    matrix_E[i, j] = 1;
                }
            }
        }




        int[,] matrix_A = new int[n, n];                   // нижнетреугольная матрица A
        for (int i = 0; i < n; i++)
        {
            k = 1;
            for (int j = 0; j < n; j++)
            {
                if (i >= j)
                {
                    matrix_A[i, j] = k;
                    k++;
                }
            }
        }




        int[,] matrix_B = new int[n, n];                  // верхнетреугольная матрица B
        for (int i = 0; i < n; i++)
        {
            k = 1;
            for (int j = 0; j < n; j++)
            {
                if (i <= j)
                {
                    matrix_B[i, j] = k;
                    k++;
                }
            }
        }

        static int Sum_one(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || i == arr.GetLength(0) - 1 || j == 0 || j == arr.GetLength(1) - 1)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }


        static int Sum_two(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == j) || (i + j == 4 && i != j))
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;


        }

        //static int Sum_three(int[,] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
                   
        //        }
            
        //    }
        //    return sum;
        //}
        static int[,] Rotate(int[,] array)
        {
            int[,] rotated_array = new int[array.GetLength(1),array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    rotated_array[j,array.GetLength(0)-1-i]=array[i,j]; 
                }
            }
            return rotated_array;
        }

        PrintArray(matrix_E);
        Console.WriteLine();
        PrintArray(Rotate(matrix_E));
    }
}
        











    
