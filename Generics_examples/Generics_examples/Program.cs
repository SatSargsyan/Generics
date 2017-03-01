using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_examples
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 4, b = 9;
            Console.WriteLine("before swap a= {0} b={1}", a, b);
            Swap<int>(ref a, ref b);
            //Now b is 4, a is 9
            Console.WriteLine("after swap a= {0} b={1}",a,b);

            string x = "Hello";
            string y = "World";
            Console.WriteLine("before swap x={0} y={1}", x, y);
            Swap<string>(ref x, ref y);
            //Now x is "World", y is "Hello"

            Console.WriteLine("after swap x={0} y={1}",x,y);

            Console.ReadKey();
        }
    }
}