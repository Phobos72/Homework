
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int lenght = number.Length;

// if (lenght == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - Не палиндром");
//     }
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine ("Введите координату x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double k1 = x1 - x2;
// double k2 = y1 - y2;
// double k3 = z1 - z2;
// double g =Math.Sqrt(k1*k1+k2*k2+k3*k3);
// Console.WriteLine($"Длинна {g}");



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// int N = tabl("Введите число N: ");

// for (int i=1; i <= N; i++)
// {
//     Console.Write($"{i*i*i}");
// }
// int tabl(string tab)
// {
//     Console.Write(tab);
//     return Convert.ToInt32(Console.ReadLine());
// }




