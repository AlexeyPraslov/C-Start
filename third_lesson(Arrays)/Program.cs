// задаем массив

/*string[] array = {"Иванов", "Петров", "Сидоров"};

array[0] = "Скворцов"; //Переназначаем нулевой элемент массива. был Иванов, стал Скворцов

System.Console.WriteLine(array[0]);
*/

//----------------------------------------------------------//

//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве. Программа
//должна выдать ответ: Да/Нет.

/*System.Console.WriteLine("введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Random rand = new Random(); //
int[] array = new int [size];

for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(-10, 11);
}

for(int i = 0; i < size; i++)
{
    System.Console.Write(array[i] + " ");
}

System.Console.Write("\nВведите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

for( int i = 0; i < size; i++)
{
    if (array[i] == number)
    {
    System.Console.WriteLine("да вы нашли число");
    return;
    }
}
System.Console.WriteLine("вы не нашли число");
*/
//------------------------------------------------------//

//Задайте массив из 10 элементов, заполненный числами из
//промежутка [-10, 10]. Замените отрицательные элементы на
//положительные, а положительные на отрицательные

/*System.Console.WriteLine("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rand.Next(-10, 11);
}
for (int i = 0; i < size; i++)
{
    System.Console.Write(array[i] + " ");
}
for(int i = 0; i < size; i++)
{
    array[i] = -array[i];
    System.Console.WriteLine();
}
for (int i = 0; i < size; i++)
{
    System.Console.Write(array[i] + " ");
}
*/

//----------------------------------------------------------//

//Найдите произведения пар чисел в одномерном массиве. Парой
//считаем первый и последний элемент, второй и предпоследний и
//т.д. Результат запишите в новый массив.

/*System.Console.WriteLine("введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size]; //создали массив с длинной size
Random rand = new Random(); //создали класс для заполнения рандомными числами

for (int i = 0; i < size; i++) //цикл фор
{
    array[i] = rand.Next(10);//заполнили массив случайными числами от 0 до 10
}
for (int i = 0; i < size; i++)
{
    System.Console.Write(array[i] + " ");// вывод массива
}
System.Console.WriteLine(); // пробел между выводами

int[] num = new int[size / 2]; //создали новый массив который в два раза меньше первого
for ( int i = 0; i < size/2; i++)
{
    num[i] = array[i] * array[size-1 - i]; //первое значение нового массива = первое значение старого массива * на последний элемент старого массива 
}
for (int i = 0; i < size/2; i++)
    System.Console.Write(num[i] + " "); // вывод

if (int i = 0; i < size/2; i++) System.Console.Write($"\nЭлемент {array[size/2]} не имеет пары");
*/
//---------------------------------------------------------------------//
//Задайте одномерный массив из 10 целых
//чисел от 1 до 100. Найдите количество элементов
//массива, значения которых лежат в отрезке [20,90].


/*System.Console.WriteLine("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random rand = new Random();
int count = 0; 

for(int i = 0; i < size; i ++)
{
    array[i] = rand.Next(101);
    System.Console.Write(array[i] + ", ");
}
System.Console.WriteLine();
for(int i = 0; i < size; i ++)
{
    if(array[i] >= 20 && array[i] <= 90)
    {
        count++;
        System.Console.Write(array[i] + ", ");
    }
}
   
System.Console.Write( count + " - " + "элементов в промежутке от 20 до 90");
*/

//Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет
//количество чётных чисел в массиве.

/*System.Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random rand = new Random();

for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(15);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
int count = 0;

for(int i = 0; i < size; i++)
{
    if(array[i] % 2 == 0 && array[i] != 0)
    count++;
}
System.Console.WriteLine();
System.Console.WriteLine("Четных чисел в этом массиве " + count);
*/
//--------------------------------------------------------------------//

//Задайте массив из вещественных чисел с
//ненулевой дробной частью. Найдите разницу между
//максимальным и минимальным элементов массива. 

/*System.Console.WriteLine("Введите длинну массива: ");
double size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[(int)size];
Random rand = new Random();

for(int i = 0; i < size; i++)
{
    array[i] = Math.Round(rand.NextDouble(), 2); //заполняем массив с числами с дробной частью, где 2 числа после точки
    
    System.Console.Write(array[i] + " , "); // выводим массив чисел через запятую
}
double max = array[0]; // новые перемеенные с присваиванием нулевого значения
double min = array[0];
for(int i = 0; i < size; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
}
System.Console.WriteLine();
System.Console.Write("Масимальное число " + max);

for(int i = 0; i < size; i++)
{
    if(array[i] < min)
    {
        min = array[i];  
    }
}
System.Console.WriteLine();
System.Console.Write("Минимальное число " + min);
System.Console.WriteLine();
System.Console.WriteLine("разница между максимальным и минимальным число: " + (max - min));
*/