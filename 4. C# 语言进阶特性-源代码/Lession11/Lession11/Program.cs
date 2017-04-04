using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession11
{
    class Program
    {
        public delegate void AK(int a);

        public static void AS(int b)
        {
        }

        static void Main(string[] args)
        {
            AK myak = AS;
            AK myakk = new AK(AS);

            AS(10);
            AK mybk = delegate (int c)
            {

            };

            var v = new { Amount = 108, Message = "Hello" };
            Console.WriteLine(v.Message);

            AK MYKKKK = (X) => {

                
            };
        }
    }
}
