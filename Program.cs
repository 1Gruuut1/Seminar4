﻿/*
int GetSum(int num)
{
    int sum = 0;
    // Первый вариант:

    for(int current = 1; current <= num; current++)
    {
        sum += current;
    }
    // Второй вариант:

    //int current = 1;
    //while(current <= num)
    //{
    //    sum += current;
    //    current++;
    //}
    return sum;
}

Console.Write("Input a positive namber: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine($"Sum of elements form 1 to {a} is {result}");
*/
// 
/*
int a;

do
{
    Console.Write("Input a positive number: ");
    a = Convert.ToInt32(Console.ReadLine());
}
while(a < 0);
*/

// Задача 1: Напишите программу, которая выдаёт колличество цифр в числе.

/*
int DigitCount(int number)
{
    int count = 0;
    while(number != 0)
    {
        count++;
        number /= 10;
        
    }
    return count;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of digits in a number {number} = " + DigitCount(num));
*/
// задача 2: Напишите программу, кторая принимает число N и вы даёт произведение чисел от 1 до N.
/*
int Factorial(int num)
{
    int result = 1;
    for(int i = 1; i <= num; i++)
        result *= i;
    return result;
}

Console.Write("Input a number N: ");
int namberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Factorial is " + Factorial(namberN));
*/
/*
int Factorial(int num)
{
    int result = 1;
    while(num > 1)
        result *= num--;
        
    return result;
}

Console.Write("Input a number N: ");
//int namberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Factorial is " + Factorial(Convert.ToInt32(Console.ReadLine())));
*/