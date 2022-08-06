// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите любое трехзначное число: ");
int a = int.Parse(Console.ReadLine());

string b = a.ToString();

if (a / 100 > 0)
{
    Console.WriteLine("Третья цифра числа " + b + " является: " + b[2]);
}
else
{
    Console.WriteLine("У числа " + b + " нет третьей цифры");
}