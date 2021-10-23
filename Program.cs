using System;
using System.Collections.Generic;

namespace ProgLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ss = new List<String>();
            ss.Add("Hello");
            ss.Add("World");
            Console.WriteLine(ss[0] + ss[1] + ss.Count);
        }
    }
}
