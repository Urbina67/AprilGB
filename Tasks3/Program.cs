//Задать массив из 12 элементов, заполненных числами из [0,9].
//Найти сумму положительных/отрицательных элементов массива
//

int[] Inga=new int[12];
void FullArray(int[] Maks)
{
    int index=0;
    int lenght=Maks.Length;

    while(index<lenght)
    {
        Maks[index]=new Random().Next(0,10);
        index++;
    }

}
void PrintArray(int[] Maks)
{
    int count=0;
    int lenght=Maks.Length;
    
    while(count<lenght)
    {
       Console.WriteLine($"Элементы массива {Maks[count]}");
       count++;
    }

}
FullArray(Inga);
PrintArray(Inga);

int Sum(int[] Massive)
{
    int length = Massive.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (Massive[i] > 0)
        {
            sum = sum + Massive[i];
        }
    }
    return sum;
}
int SumNegative(int[] Massive)
{
    int length = Massive.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (Massive[i] < 0)
        {
            sum = sum + Massive[i];
        }
    }
    return sum;
}

int[] negative = {-3, 0, 4, 8, -6, -7};
//int resultN = SumNegative(negative);
//
//int result = Sum(Inga);
System.Console.WriteLine();
System.Console.WriteLine(Sum(Inga));
System.Console.WriteLine(SumNegative(negative));

