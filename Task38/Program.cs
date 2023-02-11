// Задайте массив вещественных (дробных) чисел. Найдите разницу между максимальным и минимальным элементом массива

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round((new Random().NextDouble()), 2);
}

double Diff(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    foreach (double e in array)
        if (e < min)
            min = e;
        else if (e > max)
            max = e;
    
    diff = Math.Round(max - min, 2);
    return diff;
}

Console.Clear();
double[] array = new double[5];
FillArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между максимумом и минимумом: {Diff(array)}");
