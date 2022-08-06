//Показать числа от -N до N
Console.WriteLine("Введите -N число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N число");
int b = int.Parse(Console.ReadLine());

while (a < b)
{
    Console.WriteLine(a++);
}
