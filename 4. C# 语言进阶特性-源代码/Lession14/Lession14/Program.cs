using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession14
{
    /// <summary>
    /// 学生名字类
    /// </summary>
    public class StudentName
    {
        /// <summary>
        /// 姓
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string LastName { get; set; }

        public StudentName()
        {

        }
        /// <summary>
        /// 重载构造函数
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        public StudentName(string fname,string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
        /// <summary>
        /// 重写ToString()方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "你的姓为：" + this.FirstName + "\n" + "你的名字为：" + this.LastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //调用Student类
            var k = new StudentName("Hello", "World");
            Console.WriteLine(k);

            var kkk = new StudentName();
            kkk.FirstName = "akak";
            kkk.LastName = "ddd";
        }
    }
}
