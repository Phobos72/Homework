//  1 задание
Console.WriteLine("Input first number");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int b =Convert.ToInt32(Console.ReadLine());

if (a<b)
{
    Console.WriteLine($"max={b}");
}
else
{
    Console.WriteLine($"max={a}");
}

//  2 задание
Console.WriteLine("Input first number");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int b =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
int c =Convert.ToInt32(Console.ReadLine());


if (a>b) 

if (a>c) Console.WriteLine($"max={a}");
else 
{
    Console.WriteLine($"max={c}");
}
else
{
    if (b>c) Console.WriteLine($"max={b}");
    else
    {
        Console.WriteLine($"max={c}");
    }
}
// 3 задание
Console.WriteLine("Input number");
int a =Convert.ToInt32(Console.ReadLine());

if (a % 2 ==1)
  {

    Console.WriteLine($"Число {a} нечётное");
  }  
else
    {
        Console.WriteLine($"Число {a} чётное");
    }
// 4 задание
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int low = -N;

while (low<=N)
{
Console.WriteLine($"{low}");
low = low +1;
}
