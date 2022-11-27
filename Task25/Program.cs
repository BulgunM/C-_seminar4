// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int number2 = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
    int degree = 1;
    for (int i = 1; i <= num2; i++)
    {
        degree = degree * num1;
    }
    return degree;
}

if (number2 > 0)
{
    int result = Degree(number1, number2);
    Console.WriteLine(result);
}
else Console.WriteLine("Требуется ввести натуральное число B");