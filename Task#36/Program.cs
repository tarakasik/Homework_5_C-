// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
int sum=0;
for (int i = 1; i < array.Length; i+=2)
{
    sum+=array[i];
}
Console.WriteLine($"The sum of the elements standing in odd positions: {sum}");