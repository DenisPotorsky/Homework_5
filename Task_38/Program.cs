using static System.Console;
Clear();

//1. Задайте массив вещественных чисел. 
//2. Найдите разницу между максимальным 
//   и минимальным элементов массива.
//   [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

WriteLine("Задайте длину массива: ");
int arrLength = int.Parse(ReadLine());
double[] array = MakeArray(arrLength);
WriteLine("[{0}]", string.Join("; ", array));
WriteLine();

double min = SearchMin(array);
WriteLine($"Минимальный элемент массива: \n{min}");
WriteLine();

double max = SearchMax(array);
WriteLine($"Максимальный элемент массива: \n{max}");
WriteLine();

SearchDifference();

double[] MakeArray(int size)
{
    double[] arr = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * 100), 1);
    }
    return arr;
}

double SearchMin(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double SearchMax(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

void SearchDifference()
{
    double result = max - min;
    WriteLine($"Разница между максимальным и минимальным элементами массива: \n{Math.Round(result, 1)}");
}