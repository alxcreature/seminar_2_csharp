// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if ((secondNumber == (firstNumber*firstNumber)) || (firstNumber == (secondNumber * secondNumber)))
{
    Console.WriteLine("Одно число являются квадратом другого");
}
else
{
    Console.WriteLine("Одно число не является квадратом второго");
}