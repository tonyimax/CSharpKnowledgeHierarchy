using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Lession10
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");
            var k = reg.IsMatch("A238-111-4192");
            Console.WriteLine(k);
        }
    }
}
