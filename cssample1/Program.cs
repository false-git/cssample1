using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("initial a = {0}", a);
            func(a);
            Console.WriteLine("after func(a) = {0}", a);
            func_ref(ref a);
            Console.WriteLine("after func_ref(a) = {0}", a);
            func_out(out a);
            Console.WriteLine("after func_out(a) = {0}", a);
        }
        static void func(int v)
        {
            v += 1;
        }
        static void func_ref(ref int v)
        {
            v += 1;
        }
        static void func_out(out int v)
        {
            v = 1; // v += 1; は NG
        }
    }
}
