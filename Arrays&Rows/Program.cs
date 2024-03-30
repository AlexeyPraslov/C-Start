// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 

//**первая реализация**//
// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string str = new string(chars);

// System.Console.WriteLine(chars);

//**вторая реализация**//
// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string str = ""; //бъявляем строку. и выделяем ей место в памяти (она пока пустая)
// for (int i = 0; i < chars.Length; i++)
// {
//     str += chars[i]; //к строке прибавляем символ каждую итерацию
// }
// System.Console.WriteLine(chars);

//**третья реализация**//
// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string str = ""; //бъявляем строку. и выделяем ей место в памяти (она пока пустая)

// foreach(var letter in chars) // foreach (для каждой) буквы var letter или char letter в массиве букв chars, мы делаем следующие действия
// {
//     str += letter; //мы к строке прибавляем букву
// }
// System.Console.WriteLine(str);

//int - точная типизация
//double - точная типизация 
//var - неточная типизация. var attay = new int[2, 3] 

// char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string str = ""; //бъявляем строку. и выделяем ей место в памяти (она пока пустая)

// foreach(var letter in chars) // для каждой буквы в массиве
// {
//     System.Console.Write(letter + " ");
// }

//**четвертая реализация**//
//**метод конкат**//
// char[] letters = {'a', 'b', 'c', 'd'};
// string str = string.Concat<char>(letters);//метод конкат соддержит буквы (char) в массиве letters
// //она конкотенирует все элементы массива в одну строчку, для этого указываем тип данных который находится в массиве и сам массив
// System.Console.WriteLine(str);


//-----------------------------------------------------------------//
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

// string str = "Hello!";
// //char[] chars = new char[str.Length];
// // for (int i = 0; i < str.Length; i++)
// // {
// //     chars[i] = str[i];
// // }
// Console.WriteLine("[" + string.Join(", ", chars) + "]");

//-----------------------------------------------------------------------//
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// string? str = Console.ReadLine()?.ToLower();
// char[] letters = {'a', 'e', 'i', 'o', 'u', 'y'};
// int count = 0;

// for (int i = 0; i < str!.Length; i++)
// {
//     for (int j = 0; j < letters.Length; j++)
//     {
//         if (str[i] == letters[j])
//         {
//             count++;
//             break;
//         }
//     }
// }
// System.Console.WriteLine(count);

//***************************************************************//

// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// char[,] array = {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'}
// };

// string str = "";

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         str += array[i,j];
//     }
// }
// System.Console.Write(str);

//**************************************************//

// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

// System.Console.WriteLine("введи строку с разным регистром: ");

// string str = Console.ReadLine()!.ToLower();
// System.Console.WriteLine(str);

//******************************************************//

// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

// string str = "121!"; // Замените на любую строку
// int start = 0;
// int end = str.Length - 1;
// bool isPalindrome = true;

// while (start < end)
// {
//     // Пропускаем символы, которые не являются буквенно-цифровыми
//     if (!char.IsLetterOrDigit(str[start]))
//     {
//         start++;
//         continue;
//     }
//     if (!char.IsLetterOrDigit(str[end]))
//     {
//         end--;
//         continue;
//     }

//     // Сравниваем символы в нижнем регистре
//     if (char.ToLower(str[start]) != char.ToLower(str[end]))
//     {
//         isPalindrome = false;
//         break;
//     }

//     start++;
//     end--;
// }

// Console.WriteLine(isPalindrome ? "Да" : "Нет");
