// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int EvenNumbers(int[] array)
{
    int count = 0;
    foreach (int e in array)
    {
        if (e % 2 == 0)
            count++;
    }
    return count;
}

Console.Clear();
int[] array = new int[6];
FillArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Кол-во четных чисел в массиве: {EvenNumbers(array)}");