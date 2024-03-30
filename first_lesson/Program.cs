// Задача: программа которая принимает число и на выход выдает ответ число умноженное само на себя

//Console.WriteLine("введи значение: ");
//int i = Convert.ToInt32(Console.ReadLine());
//i = i * i;
//System.Console.WriteLine(i);

//________________________________________________________

//Напишите программу, которая на вход
//принимает два целых числа и проверяет,
//является ли первое число квадратом второго

//Console.WriteLine("введи значение a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine("введи значение b: ");
//int b = Convert.ToInt32(Console.ReadLine());
//
//if (a % b == 0){
//    System.Console.WriteLine("da");
//}
//else
//{
//    System.Console.WriteLine("net");
//}

//--------------------------------------------------------

//программа которая будет выдавать дни недели по заданному числу

//Console.WriteLine("введи номер дня недели: ");
//int day = Convert.ToInt32(Console.ReadLine());
//
//if (day == 1){
//    System.Console.WriteLine("понедельник");
//}
//else if (day == 2){
//    System.Console.WriteLine("вторник");
//}
//else if (day == 3){
//   System.Console.WriteLine("среда");
//}
//else if (day == 4){
//    System.Console.WriteLine("четверг");
//}
//else if (day == 5){
//   System.Console.WriteLine("пятница");
//}
//else if (day == 6){
//    System.Console.WriteLine("суббота");
//}
//else if (day == 7){
//    System.Console.WriteLine("воскресенье");
//}
//else {
//   System.Console.WriteLine("такого дня не недели не существует");
//}


//---------------------------------------------------------------

//Программа которая на вход принимает целое число Н, а на выходе показывает все целые числа в промежутке от -Н до Н

/*Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = -n;
while (i <= n){
    System.Console.Write(i + " ");
    i = i + 1;
}
*/

//та же задача, только с циклом фор

/*Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = -n; i <= n; i = i + 1 ){
    System.Console.Write(i + " ");
}
*/
//--------------------------------------------------------
//Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.

/*using System.Runtime.ExceptionServices;

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99 && n < 1000){
int firstnumber = n % 10;
int secondnumber = n / 100;

int sum = firstnumber + secondnumber;

System.Console.WriteLine(sum);
}
else{
    System.Console.WriteLine("некорректный ввод");
}  
*/
//-------------------------------------------------------------
//Напишите программу кторая на вход принимает два числа и выдает какие из них больше

/*Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b){
    System.Console.WriteLine("первое чило больше");
}
else if(a < b){
    System.Console.WriteLine("второе число больше");
}
else
{
    System.Console.WriteLine("числа равны");
}
*/
//--------------------------------------------------------

//программа которая принимает на вход 3 числа и выдает максимальное число из этих 3 числел

/*Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
    
int a = n % 10; //последняя цифра
int b  = n / 100; //первая цифра
int c = n / 10 % 10; //средняя цифра
int max = a;
if (b > max) max = b;
if (c > max) max = c;
System.Console.Write(max);
*/
//---------------------------------------------------------//
//напишите программу, является ли числ четным

/*Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 == 0){
    System.Console.WriteLine("число четное");
}else{
    System.Console.WriteLine("число не четное");
}
*/
//------------------------------------------------------------------//
//напишите программу которая на вход принимает Н, а на выходе показывает числа от 1 до Н

/*Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
while(i <= n){
    System.Console.Write(n + " ");
    n = n - 2;
}
*/

