// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10, 99);

Console.WriteLine("Случайное число из отрезка [10, 99] " + a);

string str = a.ToString(); 

int numA = int.Parse(str[0].ToString());
int numB = int.Parse(str[1].ToString());
int max = int.Parse(str[0].ToString());

if (numA > numB)
{
    max = numA;
}
else
{
    max = numB;
}

Console.WriteLine("Наибольшая цифра = " + max);