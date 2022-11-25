// выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
// 0, 0, 0, 0, 0, 0, 0, 0 значения в массиве
// 0  1  2  3  4  5  6  7  индекс элемента

// array[0] = 345;
// array[1] = 44;
// array[6] = 87;
// array[9] = 1233;

void FillArray(int[] arr)
{
    // Random rnd = new Random(); это будет в ООП
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2); // rnd.Next(0,2)
    }
}

void PrintArray(int[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"{arr1[i]} ");
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);


// int[] array1 = {1,4,5,5,8};
// int[] array2 = new int[5] {4,6,7,9,0};
