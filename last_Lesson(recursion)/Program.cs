// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5
// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintNumbers(int n)
// {
//     if(n < 1) return;
//     PrintNumbers(n-1);
//     System.Console.Write(n + " ");
// }

// int n = ReadInt("введи максимальное число: ");
// PrintNumbers(n);

//вторая реализация этой программы от числа М до числа Н
// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintNumbers(int m, int n) //вызвали функцию. которая принимает в себя два числа
// {
//     if(n < m) return; //цикл, если наибольшее число становится меньше наименьшего числа, то мы останавливаем функцию.
//     System.Console.Write(m + " "); //выводим наименьшее число
//     PrintNumbers(m+1, n); //вызываем нашу функцию, и прибавляем к наименьшему числу +1
// }

// int n = ReadInt("введи максимальное число: ");
// int m = ReadInt("введи минимальное число: ");
// PrintNumbers(m, n);
/*рекурсионная функция, это та функция которая вызывает саму себя, 
там должна быть обязательно остановка. чтобы цикл не был бесконечным*/

//*******************************************************************//
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

// using System.Globalization;

// int RedInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int digit = RedInt("Введите число: ");

// int sumNumber(int digit)
// {
//     if(digit == 0) return 0;
//     return digit % 10 + sumNumber(digit / 10);
// }

//*****************************************************//
/*напишите программу, которая на вход принимает два числа А и В, 
и выводит А в степени В*/

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int pow (int a, int b)
// {
//     if(b == 0) return 1; //условие остановку рекурсии(когда В = 0, то мы возвращаем еденицу)
//     return a * pow(a, b - 1);
// }


// int a = ReadInt("Введи число А: ");
// int b = ReadInt("Введи число B: ");
// int result = pow(a, b);
// System.Console.WriteLine(result);

/***********************************************************/

// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// int ReadInt (string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void print(int N, int M)
// {
//     if(N <= M) 
//     System.Console.Write(N + " ");
//     print(N+1, M);
// }

// int N = ReadInt("введи число N: ");
// int M = ReadInt("введи число M: ");

// print(N, M);

/*****************************************************************/
// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

using System;

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size)
{
    Random rand = new Random();
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = rand.Next(30);
    }
    return myArray;
}

void PrintArray(int[] printArray)
{
    Console.Write(string.Join(", ", printArray));
}

void PrintArrayBackwards(int[] printArray)
{
    if (printArray.Length > 0)
    {
        Console.Write(printArray[printArray.Length - 1]);
        PrintArrayBackwards(Array.Copy(printArray, 0, new int[printArray.Length - 1]));
    }
}

int size = ReadInt("введите длинну массива: ");
int[] newArray = GenerateArray(size);
PrintArray(newArray);
PrintArrayBackwards(newArray);