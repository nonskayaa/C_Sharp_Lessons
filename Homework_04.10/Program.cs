int k = 0;
double kth_term;
double sum = 0;
double eps = double.Parse(Console.ReadLine());
do
{
    kth_term = 2 * Math.Sqrt(3) * Math.Pow(-1, k) / (Math.Pow(3, k) * (2 * k + 1));
    sum += kth_term;
    k++;
} while (Math.Abs(kth_term) >= eps);
Console.WriteLine(sum);