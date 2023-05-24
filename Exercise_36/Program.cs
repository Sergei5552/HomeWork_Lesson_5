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

int sum = 0;
for (int i = 0; i < array.Length; i += 2)
{
    sum += array[i];
}

Console.WriteLine($"\nCумма элементов, стоящих на нечётных позициях {sum}");