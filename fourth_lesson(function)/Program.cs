/*программа которая с помощью функции запрашивает ввод и выводит цифры через -*/


/*int ReadInt(string text)
{
    System.Console.Write(text);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

int val1 = ReadInt("Введи первое число: ");

int val2 = ReadInt("Введи второе число: ");

int val3 = ReadInt("Введи третье число: ");

int val4 = ReadInt("Введи четвертое число: ");

System.Console.WriteLine($"{val1}-{val2}-{val3}-{val4}");
*/
//-------------------------------------------------------------//


/*Задайте одномерный массив, заполненный случайными
числами. Определите количество простых чисел в этом
массиве.*/
/*
using System.Runtime.Serialization.Formatters;

System.Console.WriteLine("Введи длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random rand = new Random();

for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(10);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();

for(int i = 0; i < size; i++)
{
    if(array[i] % 2 == 0 && array[i] != 0)
    {
        System.Console.Write(array[i] + " ");
    }
}
*/

//-----------------------------------//
//таже задача, только  функциями
//------------------------------------//


// using System.Security.AccessControl;

// int ReadInt(string text){
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine()); //функция ввода
// }

// int[] generatArray(int sizeArray){
//     int[] myArray = new int[sizeArray];
//     Random rand = new Random();

//     for (int i = 0; i < sizeArray; i++)
//     {
//         myArray[i] = rand.Next(10);
//     }
//     return myArray;
// }

// void printArray( int[] arrayForPrint){
//        Console.Write(string.Join(", ", arrayForPrint));
// }

// int size = ReadInt("Введи длинну массива: ");
// int[] array = generatArray(size);
// System.Console.WriteLine();
// printArray(array);
//******************************************************//
// System.Console.WriteLine("ВВеди длинну массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = new int[size];
// Random rand = new Random();

// for (int i = 0; i < size; i++)
// {
//     myArray[i] = rand.Next(100);
// }

// for (int i = 0; i < size; i++)
// {
//     System.Console.Write(myArray[i] +" ");
// }

// int count = 0;

// for (int i = 0; i < size; i++)
// {
//     if(myArray[i] > 20 && myArray[i] < 90)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine(count);
//************************************//

// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 

/*int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Введи длинну массива: ");

int[] generetArray(int sizeArray)
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        newArray[i] = rand.Next(100);
    }
    for (int i = 0; i < sizeArray; i++)
    {
        System.Console.Write(newArray[i] + " ");
    }
    return newArray;
}

int[] array = generetArray(size);

void printArray(int[] arrayForPrint)
{
    int count = 0;
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        if(arrayForPrint[i] > 20 && arrayForPrint[i] < 90)
        {
            count++;
        }
    }
    System.Console.Write(count + " элементов находится в промежутке от 20 до 90");
}
System.Console.WriteLine();
printArray(array);
*/

//****************************************************************//

// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
/*
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Введи длинну массива: ");

int[] generatArray(int sizeArray)
{
    int[] arrayForGenerat = new int[sizeArray];
    Random rand = new Random();
    for (int i = 0; i < sizeArray; i++)
    {
        arrayForGenerat[i] = rand.Next(100);
    }

    for (int i = 0; i < sizeArray; i++)
    {
        System.Console.Write(arrayForGenerat[i] + " ");
    }
    return arrayForGenerat;
}

int[] array = generatArray(size);

void printMyArray(int[] arrayFotPrint)
{
    int count = 0;
    for (int i = 0; i < arrayFotPrint.Length; i++)
    {
        if(arrayFotPrint[i] % 2 == 0)
        {
            count++;
        }
        
    }
    System.Console.Write(count);
    
}
System.Console.WriteLine();
printMyArray(array);
*/

 /*int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Введи длинну массива не больше 8");

int[] generatArray(int sizeArray)
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        newArray[i] = rand.Next(9);
    }

    for (int i = 0; i < sizeArray; i++)
    {
        System.Console.Write(newArray[i] + " ");
    }
    return newArray;
}

int[] myArray = generatArray(size);

int printArray(int[] arrayForPrint)
{
    int number = 0;
    int mult = (int)Math.Pow(10, arrayForPrint.Length-1);

    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        number = arrayForPrint[i] * mult;
        mult = mult / 10;
    }
    return number;
}


System.Console.WriteLine();
printArray(myArray);
System.Console.WriteLine(printArray(myArray));
*/
