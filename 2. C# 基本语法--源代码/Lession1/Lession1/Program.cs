using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession1
{
    class Program
    {
        /// <summary>
        /// 手机 
        /// </summary>

        struct Phone
        {
            /// <summary>
            /// 价钱
            /// </summary>
            public int price;
            public string bookname;
            public string factory;
        }

        enum  Month :int
        {
           mon,mon1,mon2
        }
        static void Main(string[] args)
        {
            Phone myphone = new Phone();
            myphone.price = 1000;
            myphone.factory = "HTC";

            Phone myphone1 = new Phone();
            myphone1.price = 2000;
            myphone1.factory = "OPPO";


            Console.WriteLine(myphone1.factory);
            int age = 0;
            age = 10;
            string name = "XYZ";
            int age1 = 10;

            bool ifOK = true;
            ifOK = false;

            bool ifGo, ifRun = false;


            string HEHE;
            var HEHE1 = "";

            string ak = "ldksjfldlkfj";


            decimal mydd = 1M;


            double myd = 0.09f;

            float MYDDDD = 9.8F;
        }
    }
}
