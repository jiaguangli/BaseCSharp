//引用 引用其他命名空间的类
//using 其他命名空间
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using 的使用
using ConsoleApp2;


//命名空间 
//namespace 命名空间的名字
//{

//}
namespace ConsoleApp1
{

    //类
    //class 类名
    internal class Program
    {

        //方法
        //返回值类型 方法名(形参/形参列表)
        //{
        //   方法体
        //}

        //静态的Main函数
        static void Main(string[] args)  //程序入口
        {
            //向控制台输出一个文本
            Console.WriteLine("我是菜鸡");

            //获取控制台输入的内容 等待输入
            var readLine =  Console.ReadLine();
            //向控制台输出一个文本
            Console.WriteLine(readLine);
            //变量不能二次定义
            //var readLine = Console.ReadLine();
            readLine = Console.ReadLine();
            //Program2

            //方法体
        }
    }
}
