/*
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

// Массивы:

// Метод рандомной генерации массива:
/*
int[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/

// Домашнее задание:
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int StepNum(int numA, int numB)
{
    int step = 1;
    for(int i = 1; i <= numB; i++)
    {
        step = step * numA;
    }
return step;
}

Console.Write("Input a number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int step = StepNum(numA, numB);


Console.WriteLine($"{numA} in degree {numB} = " + StepNum(numA, numB));

*/

 // Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
 int SumNum(int num)
{
    int result = 0;
    while(num > 1)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}    

Console.Write("Input a number N: ");

Console.WriteLine("Sum is " + SumNum(Convert.ToInt32(Console.ReadLine())));
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] MyArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write($"Input a namber {i} element ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] Array = MyArray(length);

ShowArray(Array);
*/