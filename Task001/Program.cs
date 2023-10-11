// /* // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  */
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

using System.Globalization;

Random rnd = new Random();
int num = (int)rnd.Next(100,1000);

int leftnum = num / 100;
int rightnum = num % 10;
int res = (leftnum*10)+rightnum;

Console.WriteLine($"{num} {res}");