// //Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// //Найдите сумму отрицательных и положительных элементов массива.
// int[] array = GetArray(12, -9, 9);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int positiveSum = 0;
// int negativeSum = 0;

// foreach (int el in array)
// {
//     positiveSum += el > 0 ? el : 0;
//     negativeSum += el < 0 ? el : 0;
// }

// Console.WriteLine($"Позитивная сумма = {positiveSum}, сумма отрицательных = {negativeSum}");

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

// //Задача 1: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// //[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] something = GetArray(4, -8, 8);

// Console.WriteLine($"[{String.Join(",", something)}]");
// for (int i = 0; i < something.Length; i++)
// {
//     something[i] *= -1;
// }

// Console.WriteLine($"[{String.Join(",", something)}]");

// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да


// int[] array = GetArray(5, 1, 33);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine("Введите искомое число: ");
// int number = int.Parse(Console.ReadLine()!);
// string result = "";

// foreach (int el in array){
// result = el == number ? "Да" : "Нет";
// }

// Console.WriteLine(result);

/*Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2] -> 0

[10, 11, 12, 13, 14] -> 5*/

// int[] arr = array_random(11, -1000, 1000);

// Console.WriteLine($"[{String.Join(",", arr)}]");

// int sum = 0;

// for (int i = 0; i < arr.Length; i++){
// sum += (arr[i] >= 10 && arr[i] <= 99) ? 1 : 0;
// }
// Console.WriteLine(sum);


// int[] array_random(int size, int minValue, int maxValue) {
// int[] result = new int[size];
// for (int i = 0; i < size; i++){
// result[i] = new Random().Next(minValue, maxValue + 1);
// }
// return result;
// }

// Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] haha = GetArray(6, 1, 10);
int[] hoho = new int[haha.Length / 2];
Console.Write($"[{String.Join(",", haha)}]");
for (int i = 0; i < (haha.Length / 2); i++)
{
    hoho[i] = haha[i] * haha[haha.Length - 1 - i];
}
Console.Write($"[{String.Join(",", hoho)}]");
