// See https://aka.ms/new-console-template for more information

Console.Write("Введите полную дату рождения: ");
string DateBrd = Console.ReadLine();

Console.Write("Введите имя: ");
string name = Console.ReadLine();

Console.Write("Введите возраст: ");
byte age = byte.Parse(Console.ReadLine());

Console.WriteLine($"Пользователь: имя-{name},\tвозраст-{age}");
Console.WriteLine("Дата рождения: " + DateBrd);
