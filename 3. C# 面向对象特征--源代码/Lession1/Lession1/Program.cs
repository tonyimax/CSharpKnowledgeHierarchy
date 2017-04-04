using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession1
{

    public class Phone
    {
        /// <summary>
        /// 声明属性
        /// </summary>
       public  string Name { get; set; }

        private int _age = 56;
        /// <summary>
        /// /声明属性
        /// </summary>
        public int Age
        {
            get {
                return _age;
            }
            set {
                _age = value;
            }
        }
    }

    class a {
        public static int ak;
        public int bk;
    }

    class b {
        public void tt() {
            var k = a.ak;
            var mya = new a();
            var kkk = mya.bk;
        }
        
     }

    /// <summary>
    ///声明一个公有类
    /// </summary>
    public class my
    {
        /// <summary>
        /// 声明没有返回类型的方法
        /// </summary>
        public void t4() {
            //调用类Program的静态成员变量mykk;
            var k = Program.mykk;
            //实例化Program类对象的变量myclass
            var myclass = new Program();
            //声明变量k1并赋值Program类中的成员变量kk值
            var k1 = myclass.kk;
            //调用类的非静态方法
            myclass.test();
            //调用类的静态方法
            Program.test2();
        }
    }
    /// <summary>
    /// 类Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// 声明私有成员mypp
        /// </summary>
        private int mypp;
        /// <summary>
        /// 声明公有成员kk;
        /// </summary>
        public int kk;
        /// <summary>
        /// 声明静态公有成员mykk
        /// </summary>
        public static int mykk;
        /// <summary>
        /// 声明没有返回类型的方法
        /// </summary>
        public void test() {
             
        }
        /// <summary>
        /// 类的静态方法，可直接调用，不需要初始化对象
        /// </summary>
        public static void test2()
        {

        }
        /// <summary>
        /// 应用程序入口点方法，程序启动时默认加载的方法，该方法为静态方法，用static关键字声明
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var phone = new Phone();
            //写入属性值
            phone.Name = "OPPO";
            //读出属性值
            Console.WriteLine(phone.Name);
            phone.Age = 88;
            Console.WriteLine(phone.Age);

            //顺序循环
            for (int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
            //倒序循环
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
