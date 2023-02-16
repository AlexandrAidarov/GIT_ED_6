
Console.WriteLine("Введите количество элементов массива:");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[3];

FillArray(array);
PrintArray(array);

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
        if(i < arr.Length - 1) Console.Write(arr[i]+ ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}