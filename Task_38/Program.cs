using static System.Console;
Clear();
//1. Задайте массив вещественных чисел. 
//2. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
WriteLine("Задайте длину массива: ");
int arrLength = int.Parse(ReadLine());
double[] array = MakeArray(arrLength);

double[] MakeArray(int size)
{
    double[] arr = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next();
    }
    return arr;
}

void SearchDifferenceMinMax(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    WriteLine($"Количество четных элементов массива: \n{result}");
}