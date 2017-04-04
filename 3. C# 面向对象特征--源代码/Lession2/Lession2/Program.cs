using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession2
{
    /// <summary>
    /// 抽象类，只能够被继承，不能用new来实例化对象
    /// </summary>
    abstract class MYABS
    {
       /// <summary>
       /// 抽象方法
       /// </summary>
       public abstract void mykk();
    }
    /// <summary>
    /// 密封类，不能被继承，可以实例化对象
    /// </summary>
    sealed class mySEA : MYABS
    {
        /// <summary>
        /// 重写之后密封方法
        /// </summary>
        public sealed override void mykk()
        {
           
        }

        
    }


    class a
    {
        public string ak;

       /// <summary>
       /// 运算符重载+
       /// </summary>
       /// <param name="a1"></param>
       /// <param name="a2"></param>
       /// <returns></returns>
        public static a  operator + (a a1,a a2)
        {
            var k = new a();
             k.ak = a1.ak + a2.ak;
            return k;
        }
    }

    class Program
    {


        public static void Add()
        {
            Console.WriteLine(1);
        }
        public static void Add(int a)
        {
            Console.WriteLine(1 + a);
        }
        public static void Add(int a,int b)
        {
            Console.WriteLine(1 + a +b);
        }
        static void Main(string[] args)
        {
            //var cp = new ChinesePerson();
            //cp.ChineseWrite();
           
        }
    }


    interface IPerson
    {
        void 打足球();
        void 打台球(); 
    }
    interface IPerson2
    {
        void 打足球2();
        void 打台球2();
    }
    /// <summary>
    /// 声明人的基类（父类）
    /// </summary>
    public class Person 
    {

        public string TTT { get; set; }
        /// <summary>
        /// 基类的WriteText方法
        /// </summary>
        public void WriteText()
        {
            Console.WriteLine("中文");
        }
        /// <summary>
        /// 基类的WriteText2方法
        /// </summary>
        public static void WriteText2()
        {
            Console.WriteLine("中文2");
        }

        /// <summary>
        /// 基类的虚拟方法WriteText3
        /// </summary>
        public  virtual  void   WriteText3()
        {
            Console.WriteLine("中文3");
        }


    }
    /// <summary>
    /// 声明一个子类，继承于Person基类
    /// </summary>
    public class ChinesePerson : Person,IPerson,IPerson2
    {

        
        /// <summary>
        /// 子类的ChineseWrite方法
        /// </summary>
        public void ChineseWrite()
        {
            //普通类，调用方法
            ////非静态方法调用
            //var p = new Person();
            //p.WriteText();
            ////静态方法调用
            //Person.WriteText2();


            //继承基类之后，可以直接调用基类的方法
            WriteText();
            WriteText2();
            //直接调用基类的方法
            base.WriteText3();
            //先找子类有没这个方法，如果有就执行子类的方法，没有的话就去执行基类的方法 
            WriteText3();
            
        }

        public override void WriteText3()
        {
            //base.WriteText3();
            Console.WriteLine("这是子类重写过的虚方法");
        }
        public void 打台球()
        {
            
        }

        public void 打台球2()
        {
           
        }

        public void 打足球()
        {
            
        }

        public void 打足球2()
        {
           
        }
    }
}
