// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите любое трехзначное число");
int a = int.Parse(Console.ReadLine());

int b = int.Parse(a.ToString().Remove(1, 1));
Console.WriteLine("Мы удалили вторую цифру введенного трехзначного числа ");
Console.WriteLine("Получилось число: " + b);