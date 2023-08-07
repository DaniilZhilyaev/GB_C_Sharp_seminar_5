// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76

int[] array = GetArray(12, 1, 999);
Console.WriteLine($"[{String.Join(",", array)}]");

int maxmin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int result = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (max < arr[j]) {max = arr[j];}
        if (min > arr[j]) min = arr[j];
    }
    result = max - min;
    return result;
}

Console.WriteLine($"Разница между максимальным и минимальным элементов массива:  {maxmin(array)}");

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
