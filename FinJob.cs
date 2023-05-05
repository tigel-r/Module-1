﻿namespace ItogRab
{
    internal class Program
    {
        static void AnketInfo()
        {
            while (true)
            {
                Console.Clear();

                (string Name, string Surname, double Age, bool HasPet, int PetQuan, string[] PetName, int ColorQuan) User;


                Console.Write("Введите имя: ");
                User.Name = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                User.Surname = Console.ReadLine();

                Console.Write("Введите свой возраст: ");
                User.Age = double.Parse(Console.ReadLine());

                Console.Write("Есть ли у вас питомец? (Да/Нет) : ");
                string PetInfo = Console.ReadLine();

                switch (PetInfo)
                {
                    case "Да":
                        User.HasPet = true;
                        Console.Write("Сколько у вас питомцев: ");
                        User.PetQuan = int.Parse(Console.ReadLine());
                        User.PetName = NameOfPet(User.PetQuan);
                        break;

                    case "Нет":
                        User.HasPet = false;
                        Console.WriteLine("У вас нет питомцев");
                        break;

                    default:
                        Console.WriteLine("Я вас не понял((( Повторите попытку");
                        Console.ReadKey();
                        continue;
                }

                Console.WriteLine("Сколько у вас любимых цветов?");
                User.ColorQuan = int.Parse(Console.ReadLine());

                NameOfColor(User.ColorQuan);

                Console.ReadKey();

            }

        }

        static string[] NameOfPet(int PetQuan)
        {
            string[] PetName = new string[PetQuan];

            for (int i = 0; i < PetName.Length; i++)
            {
                Console.WriteLine($"Укажите кличку {i+1} питомца");
                PetName[i] = Console.ReadLine();

            }

            return PetName;
        }

        static string[] NameOfColor(int ArrSiz)
        {
            string[] Colors = new string[ArrSiz];

            for(int i = 0; i < ArrSiz ; i++) 
            {
                Console.WriteLine("Ведите цвет: ");
                Colors[i] = Console.ReadLine();
            }

            return Colors;
        }

        static void Examination()
        {
        
        }

        static void Main(string[] args)
        {
            AnketInfo();

        }


    }
}