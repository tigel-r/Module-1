// See https://aka.ms/new-console-template for more information


int[] arr = new int[] { 5, -6, 9, -1, -2, 3, -4 };

int Val;
int summ = 0;
int PosNum = 0;

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            Val = arr[i];
            arr[i] = arr[j];
            arr[j] = Val;
        }
    }
    if (arr[i] >= 0)
    { PosNum++; }


    summ += arr[i];

}
Console.WriteLine("Количество положительных значений: " + PosNum);






