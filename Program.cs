
// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Create2DRandomArray(int rows, int columns)
// {
//     double[,] newArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(-99,99)/10.0;
//         }
//     }
//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray(m, n);
// Show2DArray(myArray);

//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.
//  Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] num = new int[6, 8];
// FillArray2D(num);
// PrintArray2D(num);
// if (rows < num.GetLength(0) && columns < num.GetLength(1))
// Console.WriteLine(num[rows, columns]);
// else 
// Console.WriteLine($"{rows}{columns} -> такого числа в массиве нет");
// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
