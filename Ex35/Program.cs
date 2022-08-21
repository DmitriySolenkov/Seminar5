int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 501);
}
Console.WriteLine($"[{String.Join(", ", array)}]");
int count=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >=10 && array[i]<=99)
    {
        count++;
    }
}
Console.WriteLine(count);