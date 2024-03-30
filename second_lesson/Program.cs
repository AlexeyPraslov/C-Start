//программа которая программа которая принимает трехначное число и удаляет вторую цифру

/*System.Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99 && n < 1000)
{
    int ThirdNumber = n % 10;
    int firstNumber = n / 100;
    Console.Write(firstNumber + "" + ThirdNumber);
} 
else 
{
    System.Console.WriteLine("неорректный ввод");
}

//чтобы получить целое число, мы вводим еще одну переменную

int result = firstNumber*10 + ThirdNumber
*/

/*----------------------------------------------------------*/

 //программа которая принимает три числа и возводит второе число в степень равную третьему числу

 /*Console.WriteLine("Введите трехначное число: ");
string data = Console.ReadLine(); // получаем данные от пользователя
int number = Convert.ToInt32(data);

if(number < 100 || number >= 1000) // проверяем корректность введенных данных
{
Console.WriteLine("Вы ввели не верное число"); // выводим сообщение об ошибке
return; // прерываем работу метода
}

int third = number % 10;
int second = number / 10 % 10;
int pow = 1;

while(third != 0)
{
pow = pow * second;

--third; // third = third - 1
}

Console.WriteLine($"результат возведения в степень: {pow}");
*/
//------------------------------------------------------------------//
//программа которая принимае на вход 2 числа, и вовыодит является ли второе число кртно первому, если нет, то выводит ответ - остаток от деления

/*System.Console.WriteLine("Введите двухзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n < 10 || n > 99) // проверяем корректность введенных данных
{
Console.WriteLine("Вы ввели не верное число"); // выводим сообщение об ошибке
return; // прерываем работу метода
}

int firstDigit = n / 10;
int secondDigit = n % 10;
int run = firstDigit % secondDigit;

if (firstDigit % secondDigit == 0)
{
    System.Console.WriteLine(firstDigit + " кратно " + secondDigit);
}
else{
    System.Console.WriteLine(run);
}
*/
/*----------------------------------------------------------------*/

//программа которая выводит третью цифру заданного числа или сообщает, что таой нет

/*System.Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int nun = 0;
if (digit < 100)
{
    System.Console.WriteLine("некорректное число");
    return;
}
else if (digit > 100 && digit < 1000)
{
    int num = digit % 10;
    System.Console.WriteLine(num);
}
else if (digit > 1000 && digit < 10000)
{
    int num = digit % 100 / 10;
    System.Console.WriteLine(num);
}
*/

//---------------------------------------------------------------------//

//программа которая на вход принимает два числа и провереяет, кратно ли оно одновременно 7 и 23

/*System.Console.WriteLine("введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit % 7 == 0 && digit % 23 == 0)
{
    System.Console.WriteLine("число " + digit + " кратно 7 и 23");
}
else
{
    System.Console.WriteLine("число " + digit + " не кратно 7 и 23");
}
*/

//----------------------------------------------------------------------//

//програма котороя принимает на вход координаты точки (х и y)
//и выдает в какой плоскости они находятся

/*System.Console.WriteLine("Введите координаты Х: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("вы находитесь в первой координатнй плоскости");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("вы находитесь во второй координатнй плоскости");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("вы находитесь в третей координатнй плоскости");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("вы находитесь в четвертой координатнй плоскости");
}
else
{
    System.Console.WriteLine("вы находитесь на оси координат");
}
*/
//------------------------------------------------------------------------------------//
// программа которая принимает на вход число от 10 до 99 и показывает наибольшую цифру ччисла

/*System.Console.WriteLine("Введите число от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int num1 = number / 10;
    int num2 = number % 10;
    if (num1 > num2)
    {
        System.Console.WriteLine("макимальное число " + num1);
    }
    else if (num1 == num2)
    {
        System.Console.WriteLine("числа одинаковые");
    }
    else
    {
        System.Console.WriteLine("макимальное число " + num2);
    }
}
else
{
    System.Console.WriteLine("некорректный ввод");
}
*/