// See https://aka.ms/new-console-template for more information



int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
double x = int.Parse(Console.ReadLine());
double y = int.Parse(Console.ReadLine());

bool c = a < b ^ x > y;

Console.WriteLine(c);

Console.ReadKey();