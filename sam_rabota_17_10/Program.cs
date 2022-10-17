using System;

public class Program
{
    public static void Main()
    {
        //int[] arr = { 0, 33, 66, 90, 1000, 90 };
        
        Random random = new Random();
        int[] arr = new int[random.Next(10)];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(10);
        }
        
        Console.Write(Test(arr));
    }

    public static int Test(int[] arr)
    {
        int max_idx = 0;
        int min_idx = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                max_idx = i;
            }
            if (arr[i] < min)
            {
                min = arr[i];
                min_idx = i;
            }
        }
        int start_idx = Math.Min(max_idx, min_idx);
        int end_idx = Math.Max(max_idx, min_idx);
        int answer = 0;
        for (int i = start_idx + 1; i < end_idx; i++)
        {
            answer += arr[i];
        }
        return answer;
    }
}