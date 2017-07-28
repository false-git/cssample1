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

            Class1 c1 = new Class1(5);
            Class1 c2 = c1;
            Console.WriteLine("initial c1.a = {0}, c2.a = {1}", c1.a, c2.a);
            cfunc(c1);
            Console.WriteLine("after cfunc(c1) c1.a = {0}, c2.a = {1}", c1.a, c2.a);
            c2 = c1;
            cfunc_ref(ref c1);
            Console.WriteLine("after cfunc(c1) c1.a = {0}, c2.a = {1}", c1.a, c2.a);
            c2 = c1;
            cfunc_out(out c1);
            Console.WriteLine("after cfunc(c1) c1.a = {0}, c2.a = {1}", c1.a, c2.a);
        }

        static void func(int v)
        {
            v++;
        }
        static void func_ref(ref int v)
        {
            v++;
        }
        static void func_out(out int v)
        {
            v = 1; // v++; は NG
        }

        static void cfunc(Class1 c1)
        {
            c1.a++;
            c1 = new Class1(10);
        }
        static void cfunc_ref(ref Class1 c1)
        {
            c1.a++;
            c1 = new Class1(20);
        }
        static void cfunc_out(out Class1 c1)
        {
            // c1.a++; NG
            // c1.a = 5; NG
            c1 = new Class1(30);
        }
    }
}
