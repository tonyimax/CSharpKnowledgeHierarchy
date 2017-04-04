using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lession2
{
    class Program
    {
        static void Main(string[] args)
        { 
            //文件的路径
            var myfile = @"d:\1.txt";
            //判断文件是否存在
            if (File.Exists(myfile))
            {
                Console.WriteLine("文件存在！");
                //声明一个只读文件流，来读取文件中的内容
                StreamReader sr = new StreamReader(myfile);
                //将文件中的内容全部读取出来并放到K中
                var k = sr.ReadToEnd();
                //输出文件的内容到控制台
                Console.WriteLine(k);

            }
            else
            {
                Console.WriteLine("文件不存在！");
            }


            //文件的路径
            var mydir = @"d:\Android";
            //判断文件是否存在
            if (Directory.Exists(mydir))
            {
                Console.WriteLine("文件夹存在！");
                //得到文件夹中的所有文件
                foreach (var file in Directory.GetFiles(mydir))
                {
                    //输出文件夹中的文件名到控制台
                    Console.WriteLine(file);
                }
                

            }
            else
            {
                Console.WriteLine("文件不存在！");
            }

            //文件的路径
            var mytxt = @"d:\1.txt";
            var f = new FileInfo(mytxt);
            Console.WriteLine( "文件名：" +f.Name);
            Console.WriteLine("创建日期：" + f.CreationTime);
            Console.WriteLine("文件大小：" + f.Length);


        }
    }
}
