/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"     */

Console.Clear();

int start = GetNumberFromUser("Введите целое положительное число: ","Ошибка ввода!");

Console.Write($"N = {start} -> ");
PrintNaturalNumbers(start, 1);

////////////////
void PrintNaturalNumbers(int start, int finish)
{
    if(start > finish)
    {
        Console.Write($"{start}, ");
        PrintNaturalNumbers(start - 1, finish);
    }
    else if (start == finish)
    {
        Console.Write($"{start}");
    }
}

////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}
