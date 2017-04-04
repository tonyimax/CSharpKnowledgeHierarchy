using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lession8
{
    #region 我自己定的类
    public class myClass
    {
        public void myMethod()
        {
        }
        public string myAttrib { get; set; }
    }
    #endregion
    #region 程序函数入口点类
    class Program
    {
        static void Main(string[] args)
        {
            //通过全类名来反射
            Type t = Type.GetType("Lession8.myClass");
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace);

            foreach (var m in t.GetMembers())
            {
                Console.WriteLine("成员名：" + m.Name + "|成员类型:" + m.MemberType);
            }

            //用typeof关键字来反射
            Type k = typeof(StringBuilder);
            Console.WriteLine(k.FullName);
            foreach (var m in k.GetMembers())
            {
                Console.WriteLine("成员名：" + m.Name + "|成员类型:" + m.MemberType);
            }

            //实例化类后调用GetType来反射
            var kk = new myClass();
            Type ak = kk.GetType();
        }
    } 
    #endregion
}
