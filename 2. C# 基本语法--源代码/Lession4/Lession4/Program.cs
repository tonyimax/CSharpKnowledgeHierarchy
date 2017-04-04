using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOK = false;
            int age = 20;

            var mydigits = new int[] { 5,12,20,21,49,52,50};
            //string[] mystring = new string[] { "www", "fff", "rrr", "jjj" };
            foreach (var k in mydigits)
            {
                Console.WriteLine(k);

            }
            Console.WriteLine("条件筛选后：==========================");
            foreach (var k in mydigits) {
                if (k <= 20 || k >= 50)
                {
                    Console.WriteLine(k);
                    //三目表达式,问号条件成立，取YES值，否则取No,值，实际是if...else 的简写
                    var kkkk = isOK ? "Yes" : "No";
                }
                else {
                    if (true) { } else { }
                }
                   

            }
            //条件判断语句， if 代表如果条件成立，就执行大括号中的语句  
            ////!=  ==
            if (age <= 20 || age >= 50)
            {
                //Console.WriteLine("为Ture,条件成立");
                Console.WriteLine("可以输身份证");
            }
            else  //否则，就执行下面的语句
            {
                //Console.WriteLine("为False,条件不成立");
                Console.WriteLine("年龄不足20岁，不能办理身份证！");
            }




            //根据所提供的值类型来做判断，每一个case 对应 一个值，然后执行对应 的语句
            switch (10) {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
                //默认情况下执行下面语句
                default:
                    Console.WriteLine("默认动作");
                    break;
            }


            switch ("xxx")
            {
                case "a":
                    Console.WriteLine(1);
                    break;
                case "b":
                    Console.WriteLine(2);
                    break;
                case "c":
                    Console.WriteLine(3);
                    break;
                case "xxx":
                    Console.WriteLine(4);
                    break;
                //默认情况下执行下面语句
                default:
                    Console.WriteLine("默认动作");
                    break;
            }


            bool k2 = false;
            switch (k2)
            {
                case true:
                    Console.WriteLine(1);
                    break;
                case false:
                    Console.WriteLine(2);
                    break;
                //默认情况下执行下面语句
                default:
                    Console.WriteLine("默认动作");
                    break;
            }
        }
    }
}
