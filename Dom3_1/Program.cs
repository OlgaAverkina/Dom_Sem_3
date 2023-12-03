﻿// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 
// массив [10 21 14 93 23] => 2

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
Console.Write(array[i] + " ");
}
int count = 0;
foreach (int element in array)
{
if ((20 <= element) && (element <= 90)) 
count ++;
}
Console.WriteLine(" ");
Console.Write($"{count}");