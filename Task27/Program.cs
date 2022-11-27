// принимает на вход число
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int SumNumbers(int num)
{
    int sum = 0;
    int count = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
        count++;
    }
    return sum;
}

int result = SumNumbers(number);
Console.WriteLine(result);
