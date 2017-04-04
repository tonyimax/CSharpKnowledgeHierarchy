using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"d:\1.txt");
            //要捕获异常的代码块
            try
            {
                var lines = sr.ReadToEnd();
                Console.Write(lines);
            }
            //捕获系统异常--文件找不到
            catch (FileNotFoundException e)
            {
                //输出异常信息
                Console.WriteLine(e.Message);
                //直接抛出异常，程序终止
                //throw new Exception(e.Message);
                //写系统日志
            }
            //文件打不开
            catch ( IOException e)
            {
                Console.WriteLine(e.Message);
            }
            //释放内存
            finally
            {
                //关闭流
                sr.Close();
            }
            Console.WriteLine("HelloWorld");
            Console.ReadKey();
        }
    }
}
