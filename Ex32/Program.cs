int [] RandomArray(int length, int min, int max)
{
    int [] array= new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int [] ReverseArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i]= -array[i];
}
return array;
}



Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(length, min, max);
Console.WriteLine($"[{String.Join(", ", array)}]");
int [] RevArray= ReverseArray(array);
Console.WriteLine($"[{String.Join(", ", RevArray)}]");