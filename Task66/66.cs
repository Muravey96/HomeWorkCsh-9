/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

int m = GetNumberFromUser("Введите первое целое положительное число:  ","Ошибка ввода!");
int n = GetNumberFromUser("Введите второе целое положительное число:  ","Ошибка ввода!");

int numSum = FindNumbersSum(m, n);

Console.WriteLine($"M = {m}, N = {n} -> {numSum}");

/////////////
int FindNumbersSum(int num1, int num2)
{
    if(num1 == num2) return num1;
    else return num1 + FindNumbersSum(num1 + 1, num2);
}


/////////////
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
