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
        for (int j = i + 1; j < array.Length; j++)
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


void SortButckamp()
{
    Console.Write("Введите кол-во элементов массива:");
    int n = Convert.ToInt32(Console.ReadLine());
    // Заполнение массива
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
    // Cортировка
    for (int i = 0; i < n - 1; i++)
    {
        int MinIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (array[j] < array[MinIndex])
                MinIndex = j;
        }
        (array[MinIndex], array[i]) = (array[i], array[MinIndex]); /* int temp;
                                                               temp = array[MinIndex];
                                                               array[MinIndex] = array[i];
                                                               array[i] = temp; */
    }
    Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
}

SortButckamp();

