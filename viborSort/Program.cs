Console.Clear();

int[] UserArray()
{
    Console.Write("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = array[i];
        for (int j = i; j < array.Length; j++)
        {
            if (min > array[j])
            {
                min = array[j];
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
    Console.WriteLine(" ]");
}

int[] array = UserArray();
PrintArray(array);
SortArray(array);
Console.WriteLine("Отсортированный мвссив:");
PrintArray(array);


