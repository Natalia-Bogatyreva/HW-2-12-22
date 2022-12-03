// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число, обозначающее день недели (от 1 - понедельник, до 7 - воскресение):");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    switch(day)
    {
    case  1 :
        Console.WriteLine("Это понедельник. Рабочий день.");
        break;
 
    case 2:
        Console.WriteLine("Это вторник. Рабочий день.");
        break;
    case 3:
        Console.WriteLine("Это среда. Рабочий день.");
        break;
    case 4:
        Console.WriteLine("Это четверг. Рабочий день.");
        break;
    case 5:
        Console.WriteLine("Это пятница. Рабочий день.");
        break;
    case 6:
        Console.WriteLine("Это суббота. Ура! Выходной!");
        break;
    case 7:
        Console.WriteLine("Это воскресение. Ура! Выходной!");
        break;
    }
}
else
{
    Console.WriteLine("В неделе нет такого дня.");
}