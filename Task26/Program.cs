// на вход число и 
// выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int NumberDigit(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}

int result = NumberDigit(number);
Console.WriteLine(result);
