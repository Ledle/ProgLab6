using System;
using System.Collections.Generic;

namespace ProgLab6
{ 
    class Program {
        static void Main(string[] args)
        {
            Discipline d = new Discipline("Math");
            Test t = new Test("Test");
            try
            {
                d.addtest(null);
            }
            catch
            {
                d.addtest(t);
            }
            d.show();
            d.Tests[0].show();
        }
    }
}