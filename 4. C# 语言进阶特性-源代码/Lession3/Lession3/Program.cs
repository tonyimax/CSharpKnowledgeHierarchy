using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession3
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new Digits();
            //将数组中的第一个值改变
            k[0] = 10;
            k[4] = 50;
            //循环输出值
            Console.WriteLine(k[0]);
            Console.WriteLine(k[1]);
            Console.WriteLine(k[2]);
            Console.WriteLine(k[3]);
            Console.WriteLine(k[4]);


            var k1 = new Person();
            //将数组中的第一个值改变
            k1[0] = "Hello";
            k1[4] = "World";
            //循环输出值
            Console.WriteLine(k1[0]);
            Console.WriteLine(k1[1]);
            Console.WriteLine(k1[2]);
            Console.WriteLine(k1[3]);
            Console.WriteLine(k1[4]);
        }
    }

    /// <summary>
    /// 定义一个人员的类
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 人员的姓名属性
        /// </summary>
        public string Name { get; set; }

        int _age;
        /// <summary>
        /// 声明一个属性
        /// </summary>
        public int Age
        {
            get {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

       


        //声明一个字符串数组
        string[] persons = new string[10];
        //数组的索引器，用来操作上面的字符串数组
        public string this[int index]
        {
            get
            {
                //要取那个位置的值 
                return persons[index];
            }
            set
            {
                //要更改那个位置的值
                persons[index] = value;
            }
        }



        /// <summary>
        /// 类的构造函数，在类的实例化时候，默认执行的方法
        /// </summary>
        public Person()
        {
            // Console.WriteLine("类的构造函数，在类的实例化时候，默认执行的方法");
            Name = "管理员";
           
            for (int i=0;i<persons.Length;i++)
            {
                persons[i] = Name + i.ToString();
            }
        }
    }

    public class Digits
    {
        //声明一个数组
        int[] mydigits = new int[] { 1, 3, 5, 7, 9 };
        //数组的索引器，用来操作上面的整形数组
        public int this[int index]
        {
            get
            {
                //要取那个位置的值 
                return mydigits[index];
            }
            set
            {
                //要更改那个位置的值
                mydigits[index] = value;
            }
        }

    }
}
