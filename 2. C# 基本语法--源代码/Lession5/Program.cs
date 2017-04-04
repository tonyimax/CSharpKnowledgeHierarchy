using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession5
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明一个固定大小的数组，数组长度为5
            var mynumbers = new int[5];
            //给数组元素赋值
            mynumbers[0] = 100;
            mynumbers[1] = 25;
            mynumbers[4] = 12;
            //取数组元素的值
            var k = mynumbers[1];

            Console.WriteLine(k);
            Console.WriteLine(mynumbers[4]);


            //声明一个未知大小的数组
            var mynum_new = new int[] { };

            //数组中数组-初始化未知大小多维数组
            var myddd = new int[][]{
                new int[] { 1,3} ,
                new int[] { 2,6,8,9,7} ,
                new int[] { 2, 6, 8, 9, 7 }
            };
            Console.WriteLine("=============" + myddd[1][1]);

            //数组中数组-固定维数数组
            Console.WriteLine("========================================");
            //声明数组对象
            var mydoubleDig = new int[8][];
            //给数组中的数组赋值
            mydoubleDig[0] = new int[] { 1,2,3,4,5,6,7,8};
            mydoubleDig[1] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            mydoubleDig[2] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            mydoubleDig[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            mydoubleDig[4] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            mydoubleDig[5] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            mydoubleDig[6] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            mydoubleDig[7] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //声明数组并初始化
            var mysupdit = new int[5][] {
                 new int[] { 1,2,3,4,5,6,7,8},
                 new int[] { 1,2,3,4,5,6,7,8},
                 new int[] { 1,2,3,4,5,6,7,8},
                 new int[] { 1,2,3,4,5,6,7,8},
                 new int[] { 1,2,3,4,5,6,7,8}
            };

            Console.WriteLine(mydoubleDig[1][2]);
            Console.WriteLine("========================================");
            //声明多维数组
            int[][] mydoubleDigkkk = { new int[] {1,2 }, new int[] {3,4 } };
            Console.WriteLine(mydoubleDigkkk[1][1]);

           
            //声明数组单维数组 
            var mydit = new int[] { 1, 3, 6, 7, 8, 9, 10 };
            //循环遍历数组并输出值
            for (int i = 0; i < mydit.Length; i++)
            {
                //i为数组中的索引
                Console.WriteLine(mydit[i]);
            }

            //声明二维数组
            string[,] mystrs = { { "aa", "bb", "ff" }, { "cc", "dd", "ee" } };

        }
    }
}
