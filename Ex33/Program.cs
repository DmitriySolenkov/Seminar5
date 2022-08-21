int [] RandomArray(int length, int min, int max)
{
    int [] array= new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число: ");
int search = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(length, min, max);
Console.WriteLine($"[{String.Join(", ", array)}]");
for (int j = 0; j < array.Length; j++)
{
    if (array[j]==search)
    {
        Console.Write("Искомое число присутствует!");
        break;
    }    
}
int count=0;
for (int k = 0; k < array.Length; k++)
{
    if (array[k]!=search)
    {
    count++;
    }
}
if (count==array.Length)
{
   Console.Write("Искомое число отсутствует!"); 
}