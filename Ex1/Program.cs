// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

Console.WriteLine($"[{String.Join(", ", array)}]");
int sumPos = 0;
int sumNeg = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] >= 0)
    {
        sumPos += array[j];
    }
    else
    {
        sumNeg += array[j];
    }
}

Console.WriteLine($"Сумма положительных равна {sumPos}, сумма отрицательных равна {sumNeg}");