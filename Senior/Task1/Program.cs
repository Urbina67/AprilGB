// Задать массив из 8 элементов и вывести их на экран
int[] Sheb = new int[8];
void Tararam(int[] Ququ)
{
    int index=0;
    int length=Ququ.Length;
    while (index<length)
    {
        Ququ[index]=new Random().Next(0,9);
        index++;
    }
}

void OnPrint(int[] Ququ)
{
    int count=0;
    int length=Ququ.Length;
    
    while(count<length)
    {
       Console.WriteLine($"{count} элемент массива {Ququ[count]}");
       count++;
    }

}

Tararam(Sheb);
OnPrint (Sheb);
