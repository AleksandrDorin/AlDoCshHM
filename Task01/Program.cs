// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int c = a * a;

if (b == c)

{

    Console.Write("Первое число не является квадратом второго");
}

else
{

    Console.Write("Первое число является квадратом второго !");
}