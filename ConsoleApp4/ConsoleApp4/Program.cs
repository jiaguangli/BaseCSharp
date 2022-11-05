// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//数据类型
//bool 类型
bool b = true;
bool b2 = false;
byte by = 255; //1-255
sbyte sby = -1;
short sby2 = -1;
ushort usg = 1;
uint ui= 1; //无符号

int i = -10; 
long l = -10; 
ulong  ul=  11;
char ch = 'a';
decimal d = 123.2222M;  //M后缀
double dou = 1234.22;
float fl = 123.11F; //F后缀
//占用内存大小 sizeof 
//在不同平台上会有差异 windows linux macOS 
//Console.WriteLine(sizeof(int));
//Console.WriteLine(sizeof(long));


Book book = new Book();
Console.WriteLine(book.Id);
Book2.SetId(book);
Console.WriteLine(book.Id); 
Console.WriteLine("----------------------------");
int id = 0;
Book2.SetIntValue(id);
Console.WriteLine(id);

bool a = id.GetType().IsClass;

//
//顶级语句中，在定义类以后就不能写东西了
//分割----
class Book 
{
    public int Id = 0;
    //int 返回值类型
    public int SetId() 
    {
        //只能返回规定的类型的变量-信息
        return -0;

    }
}

static class Book2
{
    //public int Id = 0;
    //int 返回值类型
    //修改了内存块里的数据
    public static void SetId(Book book)
    {
        //只能返回规定的类型的变量-信息
        book.Id = 1;

    }

    //新建了一个变量
    public static void SetIntValue(int book)
    {
        //只能返回规定的类型的变量-信息
        book = 1;

    }
}

//引用类型
//一块地址




