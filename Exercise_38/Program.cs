Random random = new Random();
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 100);
}

Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int maxNumber = array[1];
int minNumber = array[1];
for (int i = 0; i < (array.Length); i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }

    if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}

Console.WriteLine($"\nРазница между максимальным и минимальным элементом массива {maxNumber - minNumber}");
