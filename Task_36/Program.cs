using static System.Console;
Clear();
// 1.Задайте одномерный массив, заполненный случайными числами. 
// 2.Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
WriteLine("Задайте длину массива: ");
int arrLength = int.Parse(ReadLine());

int[] array = MakeArray(arrLength);

WriteLine("[{0}]", string.Join(", ", array));
WriteLine();

SumOddElements(array);

int[] MakeArray(int size)
{
    int[] arr = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

void SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    WriteLine($"Сумма элементов, стоящих на нечётных позициях: \n{sum}");
}