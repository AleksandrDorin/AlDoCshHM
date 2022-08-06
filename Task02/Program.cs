// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

string monday = "Понедельник";
string tuesday = "Вторник";
string wednesday = "Среда";
string thursday = "Четверг";
string friday = "Пятница";
string saturday = "Суббота";
string sunday = "Воскресенье";
    
if (a == 1)
Console.WriteLine(monday);
if (a == 2)
Console.WriteLine(tuesday);
if (a == 3)
Console.WriteLine(wednesday);
if (a == 4)
Console.WriteLine(thursday);
if (a == 5)
Console.WriteLine(friday);
if (a == 6)
Console.WriteLine(saturday);
if (a == 7)
Console.WriteLine(sunday);
