// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите два числа, чтобы узнать является ли одно число - квадратом другого:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 <= num2 )
{
    if (num2 == num1*num1)
    {
        Console.WriteLine($"Да. Число {num2} является квадратом числа {num1}");
    }
    else
    {
        Console.WriteLine($"Нет. Число {num2} не является квадратом числа {num1}");
    }
}
else
{
    if (num1 == num2*num2)
    {
        Console.WriteLine($"Да. Число {num1} является квадратом числа {num2}");
    }
    else
    {
        Console.WriteLine($"Нет. Число {num1} не является квадратом числа {num2}");
    }
}
