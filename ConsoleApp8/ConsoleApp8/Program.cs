// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//算术运算符
//+ - * / % ++ -- 
// 1+1=2

//int a = 1;
//int b = 2;
//int c = a+b;
int d = 20;
int e = 3;

// 20%3 = 20- 18 (3*6) =2  取余
Console.WriteLine(d % 3);

Console.WriteLine(d++); //20
//先取值，后运算
Console.WriteLine(++d); //22
//先运算，后取值
d = d + 1;


//先取值，后运算  
Console.WriteLine(e--); //3 
//先运算，后取值  
Console.WriteLine(--e); //1
e = e - 1;


//关系运算符  返回的是布尔值
//== != < > <= >=
bool b = 1 == 1;
bool b2 = 1 != 1;
Console.WriteLine(b);
Console.WriteLine(b2);

//逻辑运算符
//与 或 非
//&& || ！
// 两者全部为真 返回值是真
bool bb = 1 == 1 && 2==2;
//两者一者为真 返回值是真
bool bb2 = 1 == 1 || 2 != 2;
//取反 本来是真 返回值就是假
bool bb3 = !(1 == 1);
Console.WriteLine(bb);
Console.WriteLine(bb2);
Console.WriteLine(bb3);



//位运算符
// 后面讲
//赋值运算符 = += -=  带个=的 
//右值付给左值

int num1 = 1;
num1 += 2; //(num1 = num1+2)
Console.WriteLine(num1);

string strrr = "!";


//其他运算符 
//这个类型占用多少内存
var x= sizeof(bool);
Console.WriteLine(x);

var type = typeof(string);
Console.WriteLine(type);



//三目运算符  三元表达式
//如果条件为真? 则为 X : 否则为 Y

var str = false ? "1" : "2";
Console.WriteLine(str);
Console.ReadLine();

bool isint = num1 is int;
// as 将 Object -> StringReader as 不会抛出异常

Object obj = new StringReader("Hello"); 

StringReader r = obj as StringReader;
//强制转换失败会有异常
StringReader r2 = (StringReader)obj;
//使用() 去处理运算符优先级
