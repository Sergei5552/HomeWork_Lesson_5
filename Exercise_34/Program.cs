Random random = new Random();
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
}

Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count ++;
    }
}

Console.WriteLine($"\nКоличество чётных чилел: {count}");
