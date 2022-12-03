//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    Console.WriteLine("Введите число, чтобы узнать какая цифра в нем - третья:");
    string str = Console.ReadLine();
int i = str.Length;
int num;
bool Num;

if (Num = Int32.TryParse(str, out num))
{
    if (i > 2)
    {
        Console.WriteLine("Третья цифра числа - > " + str[2]);
    }
    else
    {
        Console.WriteLine("Вы ввели число, в котором нет третьей цифры.");
    }
}
else
{
    Console.WriteLine("Вы ввели не число, а буквенные символы.");
}

