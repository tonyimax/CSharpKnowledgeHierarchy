using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession4
{
    class Program
    {
        //声明委托
        delegate double MathAction(double num);


        //匹配委托的方法
        static double Double(double input)
        {
            //返回参数的积
            return input * input;
        }

        //匹配委托的方法
        static double Double2(double input)
        {
            //返回参数乘2的积
            return input * 2;
        }
        //实例化静态委托变量，并赋值方法名
        static MathAction ma1 = Double2;

        static void Main(string[] args)
        {
            //实例化委托变量，并赋值方法名
            MathAction ma = Double;
            //调用委托方法
            var k = ma(10);
            //输出值
            Console.WriteLine(k);

            //调用委托方法
            var k1 = ma1(10);
            //输出值
            Console.WriteLine(k1);


        }
    }
}
