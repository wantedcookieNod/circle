using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            int a; Double s; Double p;
            Console.WriteLine("please type the sircle's radius :");
            a = Convert.ToInt16(Console.ReadLine());
            s = 2 * a * 3.14;
            p = (a ^ 2) * 3.14;
            Console.WriteLine("s = " + s);
            Console.WriteLine("p = " + p);
            Console.WriteLine("thank you for using this program");
        }
    }
}
