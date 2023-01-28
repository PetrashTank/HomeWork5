/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int [] CreateArray()
{
int [] Array = new int [5];
Random number = new Random();
for (int i = 0; i < Array.Length; i++)
{
Array[i] = number.Next(100,999);
}
return Array;
}
int [] a = CreateArray();
void DivByTwo(int [] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    {
        a++;
    }
   Console.WriteLine(a);
}
Console.Write($"Массив [{a[0]},{a[1]},{a[2]},{a[3]},{a[4]}] -> ");
DivByTwo(a);