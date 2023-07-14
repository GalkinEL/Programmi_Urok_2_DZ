// Напишите программу, которая выводит третью цифру заданного числа.
// 645 -> 5
/// 78 -> третьей цифры нет
/// 32679 -> 6

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10; 
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цыфры нет");
        return false;
    }
    return true;    
} 

int number = Prompt("Введите число >");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));    
}
