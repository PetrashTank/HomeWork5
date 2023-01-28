/*
Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0                             

*/

int [] CreateArray()
{
int [] Array = new int [5];
Random number = new Random();
for (int i = 0; i < Array.Length; i++)
{
Array[i] = number.Next(-999,999);
}
return Array;
}

int [] a = CreateArray();
void SummOdd(int [] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 != 0)
    {
        a=array[i]+a;
    }
   Console.WriteLine(a);
}
Console.Write($"Массив [{a[0]},{a[1]},{a[2]},{a[3]},{a[4]}] -> ");
SummOdd(a);