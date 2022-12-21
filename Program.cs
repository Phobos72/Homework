
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int deletenumber (int num) 
{

    int ed = num / 10;
    int sum = ed % 10;
    return sum;
}
int randomnum = new Random().Next(100,1000);
Console.WriteLine(randomnum);
int result = deletenumber (randomnum);
Console.WriteLine(result);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int thirdnum(int num)
{
    int sum = num % 10;
    return sum;

}
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(thirdnum(num));


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int week(int num)
{
    if (num > 5)
    {
        Console.WriteLine($"{num} - да");
        return num;
    }
    else
    {
        Console.WriteLine($"{num} - нет");
        return num;
    }

}

Console.WriteLine("Введите цифру от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(week(num));