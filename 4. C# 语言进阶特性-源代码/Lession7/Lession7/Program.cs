using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Lession7
{

    [System.AttributeUsage(
        System.AttributeTargets.Class | //此特性只能给类用
        System.AttributeTargets.Struct) //此特性只能给结构用
     ]
    public class Author : System.Attribute //声明自定义特性时一定要继承Attribute基类
    {
        private string name;
        public double version;

        public Author(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }

    [Author("MetroX")] //给book结构添加特性Author
    struct book
    {
        string bookName;
    }




    [Author("MetroX")] //给Program类添加特性Author
    class Program
    {
        static void Main(string[] args)
        {
            ShowMsg();
            ShowMsg1();
        }
        [Obsolete("该方法已经过时",false)]
        public static void ShowMsg()
        {
            Console.WriteLine("正常情况下MSG");
        }

        /// <summary>
        /// 加了程序运行条件判断特性，如果是DEBUG模式，下面的方法才能执行
        /// </summary>
        [Conditional("DEBUG")]
        public static void ShowMsg1()
        {
            Console.WriteLine("DEBUG情况下MSG");
        }

        [Author("dfksjkfjd")]
        public static void 自定义特性测试方法()
        {
            Console.WriteLine("自定义特性测试方法");
        }
    }
}
