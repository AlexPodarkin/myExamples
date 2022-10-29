
int[] array = { 3, 1, 5, 0, 7, 9, 8 };
Console.WriteLine("Initial Massive [ " + string.Join(" , ", array) + " ]");

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if(array[j] > array[j+1])
        (array[j],array[j+1]) = (array[j+1],array[j]);
    }
}
Console.WriteLine("Sort Massive [ " + string.Join(" , ", array) + " ]");
