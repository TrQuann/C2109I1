using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut;
internal class UseRedOut
{
    //expression body
    //khi 1 phương thức chỉ có 1 câu lệnh duy nhất 
    public void ShowInfo() =>
        Console.WriteLine("Thông tin về class");
    public static void ChangeNumber(ref int a, ref int b)
    {
        int tam = a;
        a = b;
        b = tam;
        Console.WriteLine($"ChangeNumber : {nameof(a)} = {a}, {nameof(b)} = {b}");
    }
}

