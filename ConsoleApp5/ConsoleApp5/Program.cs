// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//类型转换  把类型a->类型b
//隐式类型转换 
int a = 1;
double b = 2.1;
double c = a + b;
Console.WriteLine(c);
// int -> double  隐式转换
// 在进行运算时     *系统自动进行转换 隐式转换
//显式类型转换 
// 手动进行转换的 方式    *显式类型转换 
string str =  b.ToString();
int aa = (int)b;
Console.WriteLine(aa);
Console.ReadLine();


string str2 = "true1";
var x = Convert.ToBoolean(str2);
Console.WriteLine(x);

