using Microsoft.Win32.SafeHandles;
using System.Reflection;
using System.Reflection.Metadata;

namespace ItogRab
{
    internal class FinJob
    {
        private static (string, string, double, bool, string[], string[]) AnketInfo((string Name, string Surname, double Age, bool HasPet, string[] PetName, string[] Colors) User)
        {

            Console.Write("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            User.Surname = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            User.Age = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Есть ли у вас питомец? (Да/Нет) : ");
            string PetInfo = Console.ReadLine();

            switch (PetInfo)
            {
                case "Да":
                    User.HasPet = true;
                    Console.Write("Сколько у вас питомцев: ");
                    int PetQuan = int.Parse(Console.ReadLine());
                    PetQuan = Examination(PetQuan);
                    User.PetName = NameOfPet(PetQuan);
                    break;

                case "Нет":
                    User.HasPet = false;
                    User.PetName = new string[0];
                    break;

                default:
                    Console.WriteLine("Я вас не понял(((");
                    User.HasPet = false;
                    User.PetName = new string[0];
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine("");

            Console.WriteLine("Сколько у вас любимых цветов?");
            int ColorQuan = int.Parse(Console.ReadLine());
            ColorQuan = Examination(ColorQuan);

            User.Colors = NameOfColor(ColorQuan);

            Console.ReadKey();

            return User;

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

        static int Examination(int CorrNum)
        {

            if (CorrNum > 0)
            { return CorrNum; }
            else 
            {
                Console.WriteLine("Данные не коректны... Попробуйте снова");
                CorrNum = int.Parse(Console.ReadLine());
                CorrNum = Examination(CorrNum);
                return CorrNum;
            
            }

        }

        static void AnketСonclusion((string Name, string Surname, double Age, bool HasPet, string[] PetName, string[] Colors) UserInfo) 
        {
            Console.WriteLine($"Имя пользователя: {UserInfo.Name} {UserInfo.Surname}");
            Console.WriteLine($"Возраст пользователя: {UserInfo.Age}");
            Console.WriteLine("");

            if (UserInfo.HasPet)
            {
                Console.WriteLine("Ваши питомцы: ");
                for (int i = 0; i < UserInfo.PetName.Length; i++)
                {
                    Console.WriteLine(UserInfo.PetName[i]);
                }
            }
            else
            { Console.WriteLine("Пожоже у вас питомцев нет"); }

            Console.WriteLine("");

            Console.WriteLine("Ваши любимые цвета: ");
            for (int i = 0; i < UserInfo.Colors.Length; i++)
            {
                Console.WriteLine(UserInfo.Colors[i]);
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            var FinAnkUser = ("Name", "Surname", 1.1, true, new string[0],new string[0]);
            
            FinAnkUser = AnketInfo(FinAnkUser);
            
            Console.WriteLine("");
            Console.WriteLine("");

            AnketСonclusion(FinAnkUser);
        }


    }
}