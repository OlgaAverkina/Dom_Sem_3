// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
Console.Write(array[i] + " ");
}
int max = array[0];
int min = array[0];
int result = 0;
for (int i = 1; i < array.Length; i++)
{
if (array[i] > max)
max = array[i];
}
for (int j = 1; j < array.Length; j++)
{
if (array[j] < min)
min = array[j];
}
result = max - min;
Console.WriteLine(" ");
Console.Write($"{result}");