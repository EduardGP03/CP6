
int[] array = new int[10] { 3, 6, 2, 7, 4, 8, 9, 0, 1, 5 };
// BubbleSort(array);
// foreach (var element in array)
//     Console.WriteLine(element);

Console.WriteLine(BinarySearch(array, -1));

static void Swap(int[] array, int x, int y)
{
    int aux = array[x];
    array[x] = array[y];
    array[y] = aux;
}

static void BubbleSort(int[] array)
{
    bool flag = true;

    for (int i = 0; i < array.Length && flag; i++)
    {
        flag = false;

        for (int j = 0; j < array.Length - i - 1; j++)
            if (array[j] > array[j + 1])
            {
                Swap(array, j, j + 1);
                flag = true;
            }
    }
}

static int BinarySearch(int[] array, int n)
{
    BubbleSort(array);

    int left = 0, center, right = array.Length - 1;

    while (left <= right)
    {
        center = (left + right) / 2;
        if (n == array[center])
            return center;

        else if (n < array[center])
            right = center - 1;

        else
            left = center + 1;
    }

    return -1;
}


