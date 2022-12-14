//format code ctrl K + D

double a = 0.1;
double b = 0.2;

Console.WriteLine(a+b==0.3?"true":"false");

decimal c = 0.1M;
decimal d = 0.2M;

Console.WriteLine(c + d == 0.3M ? "true" : "false");

//?: => ternary operator

//? nullable value type
string? fullname = null;
// int i = null; => error vì kiểu số ko thể null
//c# cũ
//Nullable<int> i = null;
//c# mới
//bool? check = null;

//int? lenght = fullname is not null ? fullname.Length : null;

//null-conditional operator ?
//tương tự !=, fullname mà khác mull thì trả về vế sau.
int? lenght = fullname?.Length;

// null-coalescing operator ??
// tương tự như dấu == , fullname = null thì trả về vế sau
int? chieudai = fullname?.Length ?? 0;

