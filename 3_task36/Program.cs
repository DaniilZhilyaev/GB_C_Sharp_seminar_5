// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetArray(12, -100, 100);
Console.WriteLine($"[{String.Join(",", array)}]");

int nechSum(int[] arr)
{
    int result = 0;
    int j = 1;
    while (j < arr.Length)
    {
        result = result + arr[j];
        j = j +2;
    }
    return result;
}

Console.WriteLine($"Сумма чисел с нечетным индексом:  {nechSum(array)}");

// Общий метод для создания одномерного массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
