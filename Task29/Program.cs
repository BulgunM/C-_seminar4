// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] arr2)
{
    Console.Write("[");
    for (int i = 0; i < arr2.Length - 1; i++)
    {
        Console.Write($"{arr2[i]}, ");
    }
    Console.Write(arr2[arr2.Length - 1]);
    Console.Write("]");
}

FillArray(array);
PrintArray(array);