// See https://aka.ms/new-console-template for more information


(string name, int age, string DateBrd) Anketa;
Console.Write("Введите полную дату рождения: ");
Anketa.DateBrd = Console.ReadLine();

Console.Write("Введите имя: ");
Anketa.name = Console.ReadLine();

Console.Write("Введите возраст: ");
Anketa.age = byte.Parse(Console.ReadLine());

Console.WriteLine($"Пользователь: имя-{Anketa.name},\tвозраст-{Anketa.age}");
Console.WriteLine("Дата рождения: " + Anketa.DateBrd);

Console.Read();
