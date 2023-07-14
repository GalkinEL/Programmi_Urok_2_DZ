// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System.Runtime.Serialization;

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value =Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt ("Введите трехзначное число");
if (number < 100 || number >= 1000)
{

    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;

}
Console.WriteLine($"Введеное число '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"вторая цыфра '{secondRank}'");