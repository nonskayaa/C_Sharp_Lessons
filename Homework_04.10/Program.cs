Console.WriteLine("Введите ваше число: ");
int k = 0;
double kth_term;
double sum = 0;
double eps = double.Parse(Console.ReadLine());
int x1 = -1;
int x2 = 1;
do
{
    if (k % 2 == 0)
    {
        x1 = 1;
    }
    else
    {
        x1 = -1;
    }

    kth_term = 2 * Math.Sqrt(3) * x1 / (x2 * (2 * k + 1));
    sum += kth_term;
    k++;
    x2 *= 3;
} while (Math.Abs(kth_term) >= eps);
Console.WriteLine(sum);
