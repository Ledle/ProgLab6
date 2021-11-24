using System;
using System.Collections.Generic;

namespace ProgLab6
{ 
    class Program {
        static void change(int a, out int b, ref int c) 
        {
            a = 3;
            b = 4;
            c = 5;
        }
        static void Main(string[] args)
        {
            int a = 0,c = 1;
            change(a, out int b, ref c);//b объявляется в 
            Console.WriteLine($"a:{a} b:{b} c:{c}");
		}
    }
}