// See https://aka.ms/new-console-template for more information

Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите возраст: ");
byte age = byte.Parse(Console.ReadLine());
Console.WriteLine($"Пользователь: имя-{name},\tвозраст-{age}");
Console.Write("Какой ваш любимый день недели? ");

DayOfWeek BestDay = (DayOfWeek)byte.Parse(Console.ReadLine());

Console.WriteLine("Ваш любимый день недели " + BestDay);
Console.ReadKey();

