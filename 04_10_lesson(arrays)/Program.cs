

using System.Runtime.InteropServices;

class Program
{
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($" {array[i]},");
        }
    }

    static bool AreAscending(int[] array)
    {

        bool flag = true;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                flag = false;
                break;
            }
        }
        return flag;
    }

    static bool AreDescending(int[] array)
    {
        bool flag = true;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                flag = false;
                break;
            }
        }
        return flag;

    }
    public static void Main(string[] args)
    {
        //1 инвертировать массив
        int temp;
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 0; i < a.Length / 2; i++)
        {
            temp = a[i];
            a[i] = a[(a.Length - 1 - i)];
            a[a.Length - 1 - i] = temp;
        }
        PrintArray(a);

        //2 сдвинуть массив на k шагов влево ---

        int[] b = { 1, 2, 3, 4, 5 };
        int[] c = b;
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < b.Length; i++)
        {
            if ((i + k) > b.Length) ;
            {
                break;
            }
            b[i + k] = c[i];
            if (i < k)
            {
                b[i] = 0;
            }

        }
        PrintArray(b);


        //3 проверить массив по убыванию/ возрастанию?

        int[] a = { 5, 4, 3, 2, 1 };
        Console.WriteLine(AreAscending(a));
        Console.WriteLine(AreDescending(a));


        ////4 Union arrays

        int[] a = { 2, 3, 4, 9 };
        int[] b = { 1, 5, 6, 7, 8 };
        int[] c = new int[a.Length + b.Length];
        int i = 0, j = 0, k = 0;
        while (i < a.Length && j < b.Length)
        {
            if (a[i] <= b[j])
            {
                c[k] = a[i];
                i++;
                k++;
            }
            if (b[j] < a[i])
            {
                c[k] = b[j];
                j++;
                k++;
            }
        }
        if (i == a.Length)
        {
            for (i = j; i < b.Length; i++)
            {
                c[k++] = b[i];
                k++;
            }
        }
        if (j == b.Length)
        {
            for (j = i; j < a.Length; j++)
            {
                c[k++] = a[j];
                k++;
            }

        }
        PrintArray(c);

        //5 intersection


        int[] a = { 2, 3, 4, 5, 9 };
        int[] b = { 1, 3, 4, 5, 6, 7, 9 };
        int[] c = new int[Math.Min(a.Length, b.Length)];
        int k = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j])
                {
                    c[k] = a[i];
                    k++;
                }
            }

        }
        PrintArray(c);

        //6 difference

        int[] a = { 2, 3, 4, 5, 9 };
        int[] b = { 1, 3, 4, 6, 7, 9 };
        int[] c = new int[a.Length];
        int k = 0;
        bool flag;
        for (int i = 0; i < a.Length; i++)
        {
            flag = true;
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                c[k] = a[i];
                k++;
            }
        }
        PrintArray(c);





    }



}