using System;

class Program
{
    static void Main(string[] args)
    {
        //Task 1


        //float[] A = new float[5];
        //float[,] B = new float[3, 4];


        //Console.WriteLine("Введите 5 чисел для массива A:");
        //for (int i = 0; i < A.Length; i++)
        //{
        //    Console.Write($"A[{i}] = ");
        //    A[i] = float.Parse(Console.ReadLine());
        //}


        //Random random = new Random();
        //Console.WriteLine("\nДвумерный массив B (случайные числа):");
        //for (int i = 0; i < B.GetLength(0); i++)
        //{
        //    for (int j = 0; j < B.GetLength(1); j++)
        //    {
        //        B[i, j] = (float)(random.NextDouble() * 100); 
        //        Console.Write($"{B[i, j]:F2}\t"); 
        //    }
        //    Console.WriteLine();
        //}


        //Console.WriteLine("\nМассив A:");
        //Console.WriteLine(string.Join(", ", A));


        //float max = A[0];
        //float min = A[0];
        //float sumA = 0;
        //float product = 1;
        //float sumEvenA = 0;

        //for (int i = 0; i < A.Length; i++)
        //{
        //    sumA += A[i];
        //    product *= A[i];


        //    if (i % 2 == 0)
        //    {
        //        sumEvenA += A[i];
        //    }

        //    if (A[i] > max) max = A[i];
        //    if (A[i] < min) min = A[i];
        //}


        //float sumOddColumnsB = 0;

        //for (int j = 1; j < B.GetLength(1); j += 2) 
        //{
        //    for (int i = 0; i < B.GetLength(0); i++)
        //    {
        //        sumOddColumnsB += B[i, j];
        //    }
        //}


        //Console.WriteLine($"\nОбщий максимальный элемент: {max}");
        //Console.WriteLine($"Общий минимальный элемент: {min}");
        //Console.WriteLine($"Общая сумма всех элементов массива A: {sumA}");
        //Console.WriteLine($"Общее произведение всех элементов массива A: {product}");
        //Console.WriteLine($"Сумма четных элементов массива A: {sumEvenA}");
        //Console.WriteLine($"Сумма нечетных столбцов массива B: {sumOddColumnsB}");

        //Task 2

        //int[,] arr = new int[5, 5];
        //Random rand = new Random();


        //Console.WriteLine("Двумерный массив:");
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        arr[i, j] = rand.Next(-100, 101); 
        //        Console.Write(arr[i, j] + "\t");
        //    }
        //    Console.WriteLine();
        //}


        //int minVal = int.MaxValue;
        //int maxVal = int.MinValue;
        //int minRow = -1, minCol = -1;
        //int maxRow = -1, maxCol = -1;

        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        if (arr[i, j] < minVal)
        //        {
        //            minVal = arr[i, j];
        //            minRow = i;
        //            minCol = j;
        //        }

        //        if (arr[i, j] > maxVal)
        //        {
        //            maxVal = arr[i, j];
        //            maxRow = i;
        //            maxCol = j;
        //        }
        //    }
        //}


        //int sum = 0;


        //int startRow = minRow < maxRow ? minRow : maxRow;
        //int endRow = minRow > maxRow ? minRow : maxRow;
        //int startCol = minCol < maxCol ? minCol : maxCol;
        //int endCol = minCol > maxCol ? minCol : maxCol;


        //for (int i = startRow; i <= endRow; i++)
        //{
        //    for (int j = startCol; j <= endCol; j++)
        //    {
        //        if (!(i == minRow && j == minCol) && !(i == maxRow && j == maxCol)) 
        //        {
        //            sum += arr[i, j];
        //        }
        //    }
        //}


        //Console.WriteLine($"\nМинимальный элемент: {minVal} (позиция: [{minRow}, {minCol}])");
        //Console.WriteLine($"Максимальный элемент: {maxVal} (позиция: [{maxRow}, {maxCol}])");
        //Console.WriteLine($"Сумма элементов между минимальным и максимальным элементами: {sum}");


        //Task 3

        //Console.WriteLine("Введите арифметическое выражение (например: 5 + 3 - 2):");
        //string input = Console.ReadLine();

        //string[] parts = input.Split(' ');
        //int result = int.Parse(parts[0]);

        //for (int i = 1; i < parts.Length; i += 2)
        //{
        //    string operation = parts[i];
        //    int number = int.Parse(parts[i + 1]);

        //    if (operation == "+")
        //        result += number;
        //    else if (operation == "-")
        //        result -= number;
        //}

        //Console.WriteLine($"Результат: {result}");

        //Task 4

        string inputText = "To be, or not to be, that is the question,\n" +
                           "Whether 'tis nobler in the mind to suffer\n" +
                           "The slings and arrows of outrageous fortune,\n" +
                           "Or to take arms against a sea of troubles,\n" +
                           "And by opposing end them? To die: to sleep;\n" +
                           "No more; and by a sleep to say we end\n" +
                           "The heart-ache and the thousand natural shocks\n" +
                           "That flesh is heir to, 'tis a consummation\n" +
                           "Devoutly to be wish'd. To die, to sleep";

        string badWord = "die";
        string replacement = new string('*', badWord.Length);
        int replaceCount = 0;

        
        string outputText = inputText;
        int index = outputText.IndexOf(badWord, StringComparison.OrdinalIgnoreCase);

        while (index != -1)
        {
            outputText = outputText.Remove(index, badWord.Length).Insert(index, replacement);
            replaceCount++;
            index = outputText.IndexOf(badWord, index + replacement.Length, StringComparison.OrdinalIgnoreCase);
        }

        Console.WriteLine("Результат работы:");
        Console.WriteLine(outputText);
        Console.WriteLine($"\nСтатистика действий:\nКоличество замен: {replaceCount}");


    }
}

