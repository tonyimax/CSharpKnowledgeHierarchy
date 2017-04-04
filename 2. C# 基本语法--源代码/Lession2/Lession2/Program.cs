using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession2
{
    class Program
    {

        public class myClass1
        {
            public string AK = "Hello";
        }
        static void Main(string[] args)
        {
            //声明字符串变量
            string myname = "我的姓名";
            //声明字符串变量
            var company = "公司名";
            //声明整形变量
            int age = 50;
            //声明布尔值变量
            bool isOK = false;
            //声明对象变量
            object obj1 = new object();
            //声明对象变量
            var k = new System.Object();

            //初始化自己写的类
            var mycls = new myClass1();
            Console.WriteLine(mycls.GetType());
            Console.WriteLine(mycls.ToString());
            Console.WriteLine(myname);
            Console.WriteLine(mycls.AK);
            Console.WriteLine(isOK);
            var result = "Age:" + age.ToString();


            string a = "HELLO";
            string b = "HE" + "LLO";

            if (a == b)
            {
                Console.WriteLine("相等");
            }

            object k1 = (object)a;
            object k2 = (object)b;

            if (k1.Equals(k2))
            {
                Console.WriteLine("相等======");
            }
            Console.WriteLine(result);

            int kkk = 10;
            string k10 = kkk.ToString();


            string jj = "Hello ";
            char mychar = jj[4];
            char[] chars = jj.ToCharArray();
            Console.WriteLine(mychar);


            var s1 = "d:\\myforld\\mtk\\KK1.txt";
            var s2 = @"d:\myforld\mtk\1.txt";
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            if (s2.Contains("KK1"))
            {
                Console.WriteLine("kkkkkk");
            }

            Console.WriteLine(jj.Length);


            Console.WriteLine(jj.IndexOf("l"));

            StringBuilder sb = new StringBuilder();
            Console.WriteLine(sb.Length);

            sb.Append("Hello");
            Console.WriteLine(sb.Length);
            sb.Append("World");
            Console.WriteLine(sb.Length);

            var name = "林生";
            var age1 = 32;
            Console.WriteLine(sb.ToString());
            sb.AppendFormat("名字：{0}\n公司：{1}",name,age1);
            Console.WriteLine(sb.ToString());
        }
    }
}
