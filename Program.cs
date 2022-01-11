using System;
using System.Collections.Generic;

namespace ProgLab6
{ 
    class Program {
        static void Main(string[] args)
        {
            Discipline[] discs = new Discipline[1];
            discs[0] = new Discipline("Math");
            User[] usrs = new User[1];
            usrs[0] = new Student("John");
            Group gr = new Group("PI",discs,usrs);
            Console.WriteLine(gr.toString());
            Group g = (Group)gr.Clone();
            g.Students[0].Name = "Mark";
            Console.WriteLine(gr.toString());
            Test[] tsts = new Test[1];
            tsts[0] = new Test("Test 1");
            Group[] grps = new Group[] { gr };
            Discipline disc = new Discipline("Physics", tsts, grps);
            Console.WriteLine(disc.toString());
            Discipline d = (Discipline)disc.Clone();
            d.Groups[0].Name = "PS";
            Console.WriteLine(disc.toString());
        }
    }
}