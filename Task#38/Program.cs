// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int[] array = Random(10,1,100);
Console.WriteLine($"[{String.Join(", ", array)}]");
int min = array[0];
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
        min=array[i];
    }
}
Console.WriteLine($"The difference between the maximum and minimum array elements: {max-min}");
