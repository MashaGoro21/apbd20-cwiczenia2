// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a = 1;
int b = 2;

Console.WriteLine("Hello");

int c = 3;

static double GetAverage(int[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

