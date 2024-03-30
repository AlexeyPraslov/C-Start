/* двухмерный массив
int[,] matrix = { //создаем двумерный массив
//   0  1  2  3  4

    {0, 3, 4, 5, 7}, //0
    {8, 9, 4, 3, 1}, //1
    {7, 3, 2, 1, 5}, //2
    {3, 6, 8, 9, 0}  //3
};

System.Console.WriteLine(matrix[3, 1]); // 3 - строка, 1 - столбец
// показывает элемент массива по адресу
*/
//*********************************//
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// System.Console.Write("введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, cols]; //объявляем двухмерный массив 3 - количество строк, 5 - столбцов
// Random rand = new Random();


// //заполняем массив случайными числами
// for (int i = 0; i < matrix.GetLength(0); i++)//GetLenght(0) обращается к колиеству строк
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) //GetLenght(1) обращается к колиеству столбцов
//     {
//         matrix[i,j] = rand.Next(10);
//     }
// }

// //выводим массив
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write(matrix[i,j] + "\t");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// //ищем четные элементы массива и заменяем элементы на их корень (умножаем элемент сам на себя)
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if(i % 2 == 0 && j % 2 == 0)
//         {
//             matrix[i,j] = matrix[i,j] * matrix[i,j];   
//         }

//         System.Console.Write(matrix[i,j] + "\t");
//     }
//     System.Console.WriteLine();
// }
//------------------------------------------------//
//теперь таже задача, только с использованием функций

// using System.Runtime.ConstrainedExecution;

// int RaedInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int rows = RaedInt("Введите колиство строк: ");
// int cols = RaedInt("Введите колиство столбцов: ");

// int[,] GeneratMatrix(int rows, int cols, int leftRange, int rightRange)//leftRange и rightRange - диапазон генерируемых чисел который мы вписываем в rand.Next
// {
//     int[,] tempMatrix = new int[rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < tempMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempMatrix.GetLength(1); j++)
//         {
//             tempMatrix[i,j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }
//     return tempMatrix;
// }

// int[,] matrix = GeneratMatrix(rows, cols, 0, 11); //0 и 10 это leftRange и rightRange

// void printMatrix(int [,] matrixForPrint)
// {
//     for (int i = 0; i < matrixForPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixForPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixForPrint[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();

//     //ищем четные элементы массива и заменяем элементы на их корень (умножаем элемент сам на себя)
//     for (int i = 0; i < matrixForPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixForPrint.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0)
//             {
//                 matrixForPrint[i,j] = matrixForPrint[i,j] * matrixForPrint[i,j];   
//             }
//             System.Console.Write(matrixForPrint[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// printMatrix(matrix);
//*********************************************************//
//*********************************************************// 

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.

// int RaedInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int rows = RaedInt("Введите колиство строк: ");
// int cols = RaedInt("Введите колиство столбцов: ");

// int[,] GeneratMatrix(int rows, int cols, int leftRange, int rightRange)//leftRange и rightRange - диапазон генерируемых чисел который мы вписываем в rand.Next
// {
//     int[,] tempMatrix = new int[rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < tempMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempMatrix.GetLength(1); j++)
//         {
//             tempMatrix[i,j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }
//     return tempMatrix;
// }

// int[,] matrix = GeneratMatrix(rows, cols, 0, 11); //0 и 10 это leftRange и rightRange

// void printMatrix(int [,] matrixForPrint)
// {
//     for (int i = 0; i < matrixForPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixForPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixForPrint[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int sumElements(int [,] matrix)
// {
// int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i == j) sum += matrix[i,j]; 
//         }
//     }
//     return sum; 
// }


// System.Console.WriteLine(sumElements(matrix));
// printMatrix(matrix);

//******************************************************//
//------------------------------------------------------//
//******************************************************//

// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GeneratMatrix(int rows, int cols, int leftDigit, int rightDigit)
// {
//     int[,] tempArrayMatrix = new int[rows, cols];
//     Random rand = new Random();

//     for (int i = 0; i < tempArrayMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempArrayMatrix.GetLength(1); j++)
//         {
//             tempArrayMatrix[i, j] = rand.Next(leftDigit, rightDigit);
//         }
//     }
//     return tempArrayMatrix;
// }

// void printMatrixArray(int[,] printMatrix)
// {
//     for (int i = 0; i < printMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < printMatrix.GetLength(1); j++)
//         {
//             System.Console.Write(printMatrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// double[] generatMatrixInArry(int[,] matrixArray)
// {
//     double[] doublMatrix = new double[matrixArray.GetLength(0)];
//     for (int i = 0; i < matrixArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixArray.GetLength(1); j++)
//         {
//             doublMatrix[i] += matrixArray[i, j];
//         }
//         doublMatrix[i] = doublMatrix[i] / matrixArray.GetLength(1);
//     }
//     return doublMatrix;
// }

// void PrintArray(double[] array)
// {
//      System.Console.WriteLine($"[ {string.Join(" | ", array)} ]");
// }


// //---------------------------------------------//
// int rows = ReadInt("введии количество строк: ");
// int cols = ReadInt("введи количество колонок:");

// int[,] newMatrix = GeneratMatrix(rows, cols, 5, 11);

// printMatrixArray(newMatrix);
// PrintArray(generatMatrixInArry(newMatrix));

// //*******************************************************//
// //********************************************************//
// // Напишите программу, которая на вход
// // принимает позиции элемента в двумерном массиве, и
// // возвращает значение этого элемента или же указание,
// // что такого элемента нет.

// int ReadInt (string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int rows = ReadInt("Введи кооличество строк: ");
// int cols = ReadInt("Введи кооличество столбцов: ");
// int positionRows = ReadInt("Введи позицию элемента в строке: ");
// int positionCols = ReadInt("Введи позицию элемента в колонке: ");

// int[,] generatMatrixArray(int rows, int cols)
// {
//     int[,] tempArray = new int[rows, cols];
//     Random rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             tempArray[i,j] = rand.Next(10);
//         }
//     }
//     return tempArray;
// }

// int[,] myArray = generatMatrixArray(rows, cols);

// void PrintArray(int[,]printArraay)
// {
//     for (int i = 0; i < printArraay.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArraay.GetLength(1); j++)
//         {
//             System.Console.Write(printArraay[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// PrintArray(myArray);

// if(positionRows > 0 && positionRows <= myArray.GetLength(0) && positionCols > 0 && positionCols <=myArray.GetLength(1))
// {
//     System.Console.WriteLine(myArray[positionRows, positionCols]);
// }
// else
// {
//     System.Console.WriteLine("такого элемента нет");
// }

//****************************************************//
// задайте двухмерный массив из целых исел. напишите программу которая удлит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. под удалением
// понимается создание нового двухмерного массива

// using System.Globalization;
// using System.Net;
// using System.Runtime.CompilerServices;

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GeneratArray(int rows, int cols)
// {
//     int[,] tempArray = new int[rows, cols];
//     Random rand = new Random();

//     for (int i = 0; i < tempArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempArray.GetLength(1); j++)
//         {
//             tempArray[i,j] = rand.Next(11);
//         }
        
//     }
//     return tempArray;
// }

// void printArray(int[,] arrayForPrint)
// {
//     for (int i = 0; i < arrayForPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayForPrint.GetLength(1); j++)
//         {
//             System.Console.Write(arrayForPrint[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] firstNumberIndex (int[,] matrixArray)
// {
//     int[] minNumberposition = new int[2];

//     for (int i = 0; i < matrixArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixArray.GetLength(1); j++)
//         {
//             if(matrixArray[i, j] < matrixArray[minNumberposition.GetLength(0), minNumberposition.GetLength(1)])
//             {
//                 minNumberposition[0] = i;
//                 minNumberposition[1] = j;
//             }
            
//         }
//     }
//     return minNumberposition;
// }

// int[,] deleteRowAndCol(int[,] oldMatrix, int[] indexes)
// {
//     var newMatrix = new int[oldMatrix.GetLength(0) - 1, oldMatrix.GetLength(1) - 1];
    
//     for (int i = 0; x = 0; i < oldMatrix.GetLength(0); i++)
//     {
//         if(i == indexes[0]) continue;
//         for (int j = 0; y = 0; j < oldMatrix.GetLength(1); j++)
//         {
//             if(j == indexes[1]) continue;
//             newMatrix[x, y] = oldMatrix[i, j];
//             y++;
//         }
//         x++;
//     }
//     return oldMatrix;
// }

// int rows = ReadInt("Введи количество строк: ");
// int cols = ReadInt("Введи количество столбцов: ");

// int[,] myArray = GeneratArray(rows, cols);
// printArray(myArray);

// System.Console.WriteLine();

// var minNumberposition = firstNumberIndex(myArray);

System.Console.Write("ВВеди текст: ");
string? str = Console.ReadLine();

System.Console.Write(str);

