// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число, чтобы узнать какая цифра в нем - вторая:");
string str = Console.ReadLine();
int i = str.Length;
int num;
bool Num;
if (Num = Int32.TryParse(str, out num))
{
if (i == 3)
{
    Console.WriteLine("Вторая цифра числа - > " + str[1]);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число. В следующий раз, пожалуйста, будьте внимательнее.");
}
}
else
{
    Console.WriteLine("Вы ввели не число, а буквенные символы.");
}