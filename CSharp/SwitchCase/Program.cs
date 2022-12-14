//using System.Text;

using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int number1 = Random.Shared.Next(0,9);

int number2 = Random.Shared.Next(0, 9);
Console.WriteLine($"{nameof(number1)} = {number1}");
Console.WriteLine($"number2 =  = {number2}");

Console.WriteLine("Vui long nhap dấu : ");
var pheptoan = Console.ReadLine();
switch(pheptoan)
{
    case "+" when number1 > 0 && number2 > 0:
        Console.WriteLine(number1 + number2);
        break;
    case "-" when number1 >= number2: 
        Console.WriteLine(number1 - number2);
        break;
    case "*": Console.WriteLine(number1 * number2);
        break;
    case "/": Console.WriteLine(number1 / number2);
        break;  
    default: Console.WriteLine("het"); break;
}

Console.WriteLine(
       pheptoan switch
       {
           "+" when number1 > 0 && number2 > 0 => number1 + number2,
           "-" when number1 >= number2 => number1 - number2,
           "*" => number1 * number2,
           "/" when number2!=0 => number1 / number2,
           _ => "loi ngu"
       }
);
