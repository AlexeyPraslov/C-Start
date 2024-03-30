// string str = "r123";
// int.TryParse(str, out int number);//внутрь подается строка и объявляется переменная out int...
// System.Console.WriteLine(number);

/*tryparse принимает в себя строку и птыается его сконвертировать
если у него это получается, то он внутри метода, в переменную number 
записыыват наше значение, но если у него не получилось, то он записывает значение нуля*/

string str = "123";
if (int.TryParse(str, out int number))
{
    System.Console.WriteLine("число сконвертировано");
}
else{
    System.Console.WriteLine("число не сконвертрованно");
}