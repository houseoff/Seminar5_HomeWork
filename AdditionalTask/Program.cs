// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, 
// чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, 
// а по четным – четверки. Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, 
// чтобы оценить, сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. 
// Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

// Входные данные
// В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100). 
// Вторая строка содержит N чисел, представляющих заданный массив. Каждый элемент массива – натуральное число от 1 до 31. Все элементы массива разделены пробелом.

// Выходные данные
// В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев, в которые Вася получил тройки, 
// а во второй строке соответственно расположить числа месяца, в которые Вася получил четверки. 
// В третьей строке нужно вывести «YES», если Вася может рассчитывать на четверку и «NO» в противном случае. 
// В каждой строчке числа следует выводить в том же порядке, в котором они идут во входных данных. При выводе числа отделяются пробелом.


// Блок 1. Код для запуска в Visual Studio Code
internal class Program
{
    private static void Main(string[] args)
    {
        bool IsFour(string[] array)
        {

            int CountOfFours = 0, CountOfThrees = 0;
            foreach (string e in array)
            {
                if (int.Parse(e) % 2 == 0)
                    CountOfFours++;
                else
                    CountOfThrees++;
            }

            if (CountOfFours >= CountOfThrees)
                return true;
            else
                return false;
        }

        Console.Clear();
        Console.Write("Введите дни месяца через запятую: ");
        string[] array = Console.ReadLine()!.Split(',');

        if (IsFour(array) == true)
            Console.WriteLine("Петя получит четверку");
        else
            Console.WriteLine("Петя получит тройку");
    }
}

// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=703&ins=1#solution

// using System;
// using System.IO;

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         StreamReader sr = new StreamReader("input.txt");
//         StreamWriter sw = new StreamWriter("output.txt");
        
//         int n = int.Parse(sr.ReadLine());
//         string[] array = sr.ReadLine().Split();
//         int CountOfFours = 0, CountOfThrees = 0;
//         string LineThreeDays = string.Empty, LineFourDays = string.Empty;
        
//         foreach (string e in array)
//         {
//             if (int.Parse(e) % 2 == 0)
//             {
//                 CountOfFours++;
//             	   LineFourDays = LineFourDays + string.Format("{0} ", e);
//             }
//             else
//             {
//                 CountOfThrees++;
//             	   LineThreeDays = LineThreeDays + string.Format("{0} ", e);
//             }
//         }
        
//         sw.WriteLine(LineThreeDays);
//         sw.WriteLine(LineFourDays);

//         if (CountOfFours >= CountOfThrees)
//             sw.WriteLine("YES");
//         else
//             sw.WriteLine("NO");
        
//         sr.Close();
//         sw.Close();
//     }
// }