/* Знакомство с языками программирования (семинары)
Урок 2. Базовые алгоритмы
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    //Console.WriteLine(number + " -> " + ((number % 1000) / 100));
    int result = number;
    while (result > 999 ) result /= 10;
    Console.WriteLine(number + " -> " + (result % 10) + " " + result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}