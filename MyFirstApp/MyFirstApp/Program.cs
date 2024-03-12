// See https://aka.ms/new-console-template for more information

static double GetAvg(int[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

int[] numbers = {1, 2, 3, 4, 5};
double avg = GetAvg(numbers);
Console.WriteLine(avg);