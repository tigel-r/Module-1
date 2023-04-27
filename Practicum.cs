// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.Clear();

    (string Name, string Surname, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

    User.HasPet = true;

    Console.Write("Введите логин: ");

    User.Login = Console.ReadLine();
    User.LoginLength = User.Login.Length;

    Console.Write("Введите имя: ");
    User.Name = Console.ReadLine();

    Console.Write("Введите фамилию: ");
    User.Surname = Console.ReadLine();

    Console.Write("Есть ли у вас питомец? (Да/Нет) : ");
    string PetInfo = Console.ReadLine();

    switch (PetInfo)
    {
        case "Да":
            User.HasPet = true;
            break;

        default:
            User.HasPet = false;
            break;
    }

    Console.Write("Введите свой возраст: ");
    User.Age = double.Parse(Console.ReadLine());

    Console.WriteLine("Укажите три ваших любимых цвета: ");
    User.favcolors = new string[3];

    for (int i = 0; i < User.favcolors.Length; i++)
    {
        User.favcolors[i] = Console.ReadLine();
    }

    Console.WriteLine("");
    Console.WriteLine("");

    Console.WriteLine("Логин пользователя: {0} \t(Кличество символов: {1})", User.Login, User.LoginLength);
    Console.WriteLine("Имя пользователя: {0} {1}\tВозраст: {2}", User.Name, User.Surname, User.Age);
    Console.WriteLine($"Ваши любимые цвета: {User.favcolors[0]}, {User.favcolors[1]}, {User.favcolors[2]}");

    if (User.HasPet)
    { Console.WriteLine("У вас есть питомец!"); }
    else
    { Console.WriteLine("У вас нет питомца!"); }

    Console.ReadLine();

}

