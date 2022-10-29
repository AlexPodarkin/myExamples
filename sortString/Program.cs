Console.Clear();

string[] array = new string[5]; // razmer massiva 
for (int i = 0; i < 5; i++)
{
    Console.Write("Vvedite stroku:");
    array[i] = Console.ReadLine(); // Zapolnenie strokami
}
Console.WriteLine("Nachalo [" + string.Join(", ", array) + "]");
for (int i = 0; i < 4; i++) //razmer massiva -1 
{
    int MinIndex = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[MinIndex].Length > array[j].Length)
            MinIndex = j;
    }
    (array[i], array[MinIndex]) = (array[MinIndex], array[i]);
}
Console.WriteLine("Sort [" + string.Join(", ", array) + "]");