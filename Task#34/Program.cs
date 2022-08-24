// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
int[] array = new int [7];
Random rand = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100,1000);
    Console.Write($"{array[i]}, ");

    if (array[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine($"This array have '{count}' even numbers.");
