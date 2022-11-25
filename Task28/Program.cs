// принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int ProductOfDigit(int num)
{
    int productOfDigit = 1;
    for (int i = 1; i <= num; i++)
    {
        productOfDigit = productOfDigit * i;
    }
    return productOfDigit;
}

if (number > 0)
{
    int result = ProductOfDigit(number);
    Console.WriteLine(result);
}
else Console.WriteLine("Требуется ввести натуральное число");