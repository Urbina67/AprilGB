// Написать программу замену элементов массива на противоположные
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
       Console.WriteLine($"Элементы массива {-Maks[count]}");
       count++;
    }

}
FullArray(Inga);
PrintArray(Inga);
