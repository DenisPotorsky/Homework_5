using static System.Console;
Clear();

// 1. Задайте массив, заполненный случайными 
//    положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет 
//    количество чётных чисел в массиве.
//
//    [345, 897, 568, 234] -> 2

WriteLine("Задайте длину массива: ");
int arrLength = int.Parse(ReadLine());

int[] array = CreatIntArray(arrLength);

WriteLine("[{0}]", string.Join(", ", array));

WriteLine();

PrintEvenElements(array);

int[] CreatIntArray(int size)
{
    int[] arr = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintEvenElements(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    WriteLine($"Количество четных элементов массива: \n{counter}");
}

