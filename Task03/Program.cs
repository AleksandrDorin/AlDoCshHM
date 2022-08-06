// Найти максимальное из трех чисел

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = 0;

if (a > b && a > c)
{
    max = a;
}

if (b > a && b > c)
{
    max = b;
}

if (c > b && c > a)
{
    max = c;
}

if (c == b && c == a)
{
    max = a;
    Console.WriteLine("Введенные числа равны !");
}

Console.WriteLine("Максимально число: " + max);