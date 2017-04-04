using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession6
{
    public class myclass<T> : Object where T : Program
    {

    }

    public class MyDigits<T> 
    {
        public T[] digits;
        public T myt;

        public MyDigits()
        {
            digits = new T[5];
        }

        public void MyDigitsKK<myt>(T t)
        {
            Console.WriteLine(t.GetType());
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            var AK = new MyDigits<string>();
            AK.digits[0] = "AAA";
            AK.digits[1] = "BBB";
            AK.digits[2] = "CCC";
            AK.digits[3] = "DDD";
            AK.digits[4] = "EEE";
            AK.MyDigitsKK<string>("dfkdkfk");

            var BK = new MyDigits<int>();
            BK.MyDigitsKK<int>(123);
            

            var k = GetBananerOrApple<string>("HelloWorld");
            var kk = GetBananerOrApple<int>(123);
            var kkk = GetBananerOrApple<float>(1.4f);

            var kkkkkk = GetBananerOrApple("fjkldsljfdsjl");



        }

        public string Bananer()
        {
            return "Bananer";
        }

        public int Apple()
        {
            return 1;
        }

        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argT"></param>
        /// <returns></returns>
        public static T GetBananerOrApple<T>(T argT)
        {
            T t = argT ;
            return t;
        }
        /// <summary>
        /// 普通方法
        /// </summary>
        /// <param name="argT"></param>
        /// <returns></returns>
        public static string GetBananerOrApple(string argT)
        {
           
            return argT;
        }

      
    }
}
