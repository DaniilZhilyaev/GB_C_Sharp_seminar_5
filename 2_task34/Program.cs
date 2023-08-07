// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetArray(4, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}]");

int result = 0;
foreach (int el in array)
{
    result += el % 2 == 0 ? 1 : 0;
}

Console.WriteLine($"Колличество четных чисел {result}");

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
