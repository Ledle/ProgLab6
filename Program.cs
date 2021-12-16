using System;
using System.Collections.Generic;

namespace ProgLab6
{ 
    class Program {
        static void Main(string[] args)
        {
            Question q0 = new Question();
            Question q1 = new Question("2+20");
            Question qall = new Question("2+2", "4", 15);
            Question[] qs = { new Question("First"), new Question("Second"), new Question("Third") };
            Test t0 = new Test();
            Test t1 = new Test("NameOnly");
            Test tall = new Test(qs,"AllParms");
            Test[] tsts = { t0, t1, tall };
            User u0 = new User();
            User u1 = new User("Bob");
            User uall = new User(836, 444, "John");
            User[] usrs = { u0, u1, uall };
            Discipline d0 = new Discipline();
            Discipline d1 = new Discipline("JustName");
            Discipline[] dscps = { d0, d1};
            Group g0 = new Group();
            Group g1 = new Group("OnlyName");
            Group gall = new Group("AllParms");
            Group[] groups = { g0, g1, gall };
            Discipline dall = new Discipline("AllParms",tsts,groups);
        }
    }
}