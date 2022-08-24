// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

Console.Clear();
int[] array = GetRandomArray(10,1,100);
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
