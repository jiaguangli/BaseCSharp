// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//万物皆对象
//所有代码的编写应该以对象为基本单位
//对象 由类型实例化获得
//book 基于Book类型实例化的对象  new() 对象
Book book= new Book();
//book._name;
//使用实例化后的对象里的方法
//book.ShuChuName();
//static 
var abc = 11;
//类型
//Book.ShuChuName();

//程序运行时，全局缓存的一个东西
//静态类中不能有普通方法,必须为静态方法、
//普通类中可以有静态方法
class Book 
{
    //成员变量
    //
    public static string _name = "滑稽半夏";
    //方法
    public void ShuChuName() 
    {
        Console.WriteLine(_name);
    }
    
}