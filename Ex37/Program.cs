Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 10);
}
Console.WriteLine($"[{String.Join(", ", array)}]");

if (length % 2 == 0)
{
    for (int i = 0; i < length / 2; i++)
    {
        Console.Write($"{array[i] * array[length - i - 1]}, ");
    }
}
else
{
for (int i = 0; i < length / 2; i++)
    {
        Console.Write($"{array[i] * array[length - i - 1]}, ");
    }
    Console.Write($"{array[length/2]}");
}