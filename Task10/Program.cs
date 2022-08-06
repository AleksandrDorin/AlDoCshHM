// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int res = 0;


if (a % b == 0)
{
    Console.WriteLine("Число кратное");
}

else

{
    res = a % b;
    Console.WriteLine("Число не кратное, остаток: " + res);
}