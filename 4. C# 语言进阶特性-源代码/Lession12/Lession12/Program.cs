using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession12
{
    static class Program
    {
        /// <summary>
        ///扩展方法，1.方法的参数一定加this关键字，后面加上扩展类型如String,而且只能在静态中添加
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string AddDot(this String str)
        {
            return str + "!!!";
        }
        static void Main(string[] args)
        {
            //声明一个数组
            int[] scores = new int[] { 92, 97, 81, 60 };

            //通过Linq表达式返回结果集合
            IEnumerable<int> scoreQuery =
                                            from k in scores   //循环scores数组
                                            where k > 80  //判断条件
                                            orderby k descending  //排序 加上descending为倒序
                                            select k;   //添加结果到集合
            Console.WriteLine(scoreQuery);

            //通过Foreach循环来返回集合
            List<int> list = new List<int>();
            foreach (var k in scores)
            {
                if (k>80)//条件
                {
                    list.Add(k);//添加结果到集合
                }
            }

            Console.WriteLine(list);
            //lambda表达的方式返回集合
            var resutl = scores.Where(k => k > 80).OrderByDescending(k =>k);


            var kkk = "HelloWorld";
            //调用扩展方法并输出结果
            Console.WriteLine(kkk.AddDot());

        }
    }
}
