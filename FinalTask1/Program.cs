
Console.WriteLine("Введите количество элементов массива:");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];

FillArray(array);
PrintArray(array);

string[] arrayLengthThree = RebuildArrayLengthThree(array);
PrintArray(arrayLengthThree);

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива:");
        string element = Console.ReadLine();
        arr[i] = element;
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

string[] RebuildArrayLengthThree(string[] arr)
{
    int ArrayLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            ArrayLength += 1;
        }
    }

    string[] arrThree = new string[ArrayLength];

    for (int i = arr.Length - 1; i > -1; i--)
    {
        if (arr[i].Length <= 3)
        {
            ArrayLength -= 1;
            arrThree[ArrayLength] = arr[i];
        }
    }
    return arrThree;
}
