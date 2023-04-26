// See https://aka.ms/new-console-template for more information


(string Name, string Type, double Age, int NameCount) Pet;
Console.Write("Ввведите имя питомца: ");
Pet.Name = Console.ReadLine();

Console.Write("Введите вид питомца: ");
Pet.Type = Console.ReadLine();

Console.Write("Введите возраст питомца: ");
Pet.Age = double.Parse(Console.ReadLine());

Pet.NameCount = Pet.Name.Length;

Console.WriteLine();
Console.WriteLine("Ваш питомец {0}, Его имя {1}", Pet.Type, Pet.Name);
Console.WriteLine("Возраст вашего питомца: " + Pet.Age);
Console.WriteLine($"Его имя состоит из {Pet.NameCount} символов");

Console.Read();