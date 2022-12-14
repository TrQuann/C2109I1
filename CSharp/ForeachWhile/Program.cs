using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
String[] arrs = { "loi", "cho", "gay" };

//foreach(var item in arrs)
//{
//    Console.WriteLine($"{item} co chieu dai {item.Length}");
//}

//int i = 0;
//while (i<arrs.Length)
//{
//    Console.WriteLine($"{arrs[i]} co chieu dai {arrs[i].Length}");
//    i++;
//}

IEnumerator e = arrs.GetEnumerator();
while (e.MoveNext())
{
    string s = (string)e.Current;
    Console.WriteLine($"{s} co chieu dai {s.Length}");
}
